using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PasswordGenerator
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TBpw.Click += new System.EventHandler(TBpw_Click);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets the timer interval to 5 seconds.
            timer1.Interval = 1000;
            timer1.Start();

            generatePW(4);

            /*EVITA IL GLITCH GRAFICO*/
            lTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void TBpw_Click(object sender, System.EventArgs e)
        {
            TBpw.SelectAll();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lValue.Text = "Valore: " + trackBar1.Value.ToString();

            generatePW(trackBar1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }
                

        public void generatePW(int lenght)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            string maiusc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string inusual = "\\|¬¦`!\"£$%^&*()_+-=[]{};:'@#~<>,./? ";
            string numb = "0123456789";



            char[] stringChars = new char[lenght];
            Random random = new Random();

            if (CBmaiusc.Checked) { chars += maiusc; }

            if (CBinusual.Checked) { chars += inusual; }

            if (CBnumb.Checked) { chars += numb; }

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new string(stringChars);

            progressBar1.Value = Convert.ToInt16(checkStrenght(finalString));

            if (progressBar1.Value < 120)
            {
                ModifyProgressBarColor.SetState(progressBar1, 2);
            }
            else if (progressBar1.Value > 120 && progressBar1.Value < 239)
            {
                ModifyProgressBarColor.SetState(progressBar1, 3);
            }
            else if (progressBar1.Value > 239)
            {
                ModifyProgressBarColor.SetState(progressBar1, 1);
            }

            TBstrenght.Text = "Punteggio: " + checkStrenght(finalString).ToString("0.00");
            TBpw.Text = finalString;
        }

        public double checkStrenght(string password)
        {
            int cardinality = 0;

            // Password contains lowercase letters.
            if (password.Any(c => char.IsLower(c)))
                cardinality = 26;
           

            // Password contains uppercase letters.
            if (password.Any(c => char.IsUpper(c)))
                cardinality += 26;
          

            // Password contains numbers.
            if (password.Any(c => char.IsDigit(c)))
                cardinality += 10;
            

            // Password contains symbols.
            if (password.IndexOfAny("\\|¬¦`!\"£$%^&*()_+-=[]{};:'@#~<>,./? ".ToCharArray()) >= 0)
                cardinality += 36;

            return Math.Log(cardinality, 2) * password.Length;
        }

        private void Bupdate_Click(object sender, EventArgs e)
        {
           
            Form form = new UpdateForm();
            form.Show();

        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}

