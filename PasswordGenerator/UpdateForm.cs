using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationForm = System.Windows.Forms.Application;

namespace PasswordGenerator
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();

            //Timer Setup
            timer1.Interval = 1000;
            timer1.Start();
        }

        public int time = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                time += 60;
                checkHostStatus();
            }
            else
            {
                time--;
            }
            lcheck.Text = "next check: " + time;
        }

        public void errorBox(System.Exception exception)
        {
            MessageBox.Show("Errore inaspettato: \n\n" + exception, ":: ERRORE FATALE ::", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
        }

        public string log(string log)
        {
            return TBLog.Text += DateTime.Now.ToString("HH:mm:ss") + ": " + log + "\n";
        }

        private string ver_str;
        private void bCheckUpdate_Click(object sender, EventArgs e)
        {
            isUpdateReadyAsync();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            label1.Text += ApplicationForm.ProductVersion;

            if (checkHostStatus() == true)
            {
                if (checkHostStatus() == true)
                {
                    label3.Text += "Online";
                    label3.ForeColor = Color.Green;
                }
                else
                {
                    label3.Text += "Offline";
                    label3.ForeColor = Color.DarkRed;
                    bCheckUpdate.Enabled = false;

                }
            }
        }

        private bool checkHostStatus()
        {
            try
            {
                log("Checking host status...");
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://github.com");
                request.Timeout = 3000;
                request.AllowAutoRedirect = false; // find out if this site is up and don't follow a redirector
                request.Method = "HEAD";

                using (WebResponse response = request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private async Task<string> GetReleaseVersionAsync()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("Password-Generator"));
            IReadOnlyList<Release> tmp = await client.Repository.Release.GetAll("habby1337", "PasswordGenerator");

            Release latest = tmp[0];
            string version = latest.TagName;

            log("La versione più recente è: [" + latest.TagName + "] - Risale al: [" + latest.PublishedAt + "]");

            return Convert.ToString(version);
        }

        private void downloadUpdate()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    log("Richiesta web creata!");
                    log("Cercando aggiornamenti da github...");

                    string versione_string = ver_str;

                    if (Convert.ToDecimal(versione_string) > Convert.ToDecimal(ApplicationForm.ProductVersion))
                    {
                        DialogResult result = MessageBox.Show("è stato trovato un aggiornamento...\n Vuoi scaricarlo?", "Aggiornamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        log("Aggiornamento trovato!");

                        if (result == DialogResult.Yes)
                        {
                            //AGGIORNARE IL DOWNLOAD
                            //https://github.com/habby1337/Percentuale_Alunni/releases/download/1.0.0.1/PercentualeAlunni.exe
                            // Uri uri = new Uri("https://github.com/habby1337/Percentuale_Alunni/releases/download/" + GetReleaseVersionAsync() + "/PercentualeAlunni.exe"); //
                            //client.DownloadFileAsync(uri, "PercentualeAlunni_new.exe");

                            Uri uri = new Uri("https://github.com/habby1337/PasswordGenerator/releases/download/" + versione_string + "/PasswordGenerator.exe"); //

                            client.DownloadFileAsync(uri, "PasswordGenerator_new.exe");

                            log("Scaricando l'aggionamento...[0%]");
                            log("Scaricando l'aggionamento...[50%]");
                            log("Aggiornamento scaricato!...[100%]");

                            client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completato);
                        }
                        else
                        {
                            log("Aggiornamento annullato!");
                            MessageBox.Show("Non verrà eseguito l'aggiornamento", "Aggiornamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (Convert.ToDecimal(versione_string) <= Convert.ToDecimal(ApplicationForm.ProductVersion))
                    {
                        log("Aggiornamento non trovato!");
                        MessageBox.Show("Nessun aggiornamento trovato", "Aggiornamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                errorBox(ex);
            }
        }

        public void Completato(object o, AsyncCompletedEventArgs args)
        {
            log("Disinstallando la vecchia versione...[0%]");
            log("Disinstallata la vecchia verisone[40%]");

            MessageBox.Show("Disintallando la vecchia versione", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            string app_name = ApplicationForm.StartupPath + "\\" + ApplicationForm.ProductName + ".exe";
            string bat_name = app_name + ".bat";

            string bat =
                "@echo off\n"                                                                                          //CHECK BEFORE RELEASE
                + ":loop\n"
                + "del \"" + app_name + "\"\n"
                + "if Exist \"" + app_name + "\" GOTO loop\n"
                + "ren PasswordGenerator_new.exe PasswordGenerator.exe\n"
                + "del %0\n"
                + "start PasswordGenerator.exe";

            StreamWriter file = new StreamWriter(bat_name);
            file.Write(bat);
            file.Close();

            Process bat_call = new Process();
            bat_call.StartInfo.FileName = bat_name;
            bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            bat_call.StartInfo.UseShellExecute = true;
            bat_call.Start();

            log("Disinstallata la vecchia verisone[100%]");
            log("Download terminato.");

            ApplicationForm.Exit();
        }

        private async void isUpdateReadyAsync()
        {
            ver_str = await GetReleaseVersionAsync();
            downloadUpdate();
        }
    }
}


