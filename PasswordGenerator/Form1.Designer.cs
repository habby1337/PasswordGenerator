namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CBnumb = new System.Windows.Forms.CheckBox();
            this.CBinusual = new System.Windows.Forms.CheckBox();
            this.CBmaiusc = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TBpw = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TBstrenght = new System.Windows.Forms.TextBox();
            this.lTime = new System.Windows.Forms.Label();
            this.lData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBnumb
            // 
            this.CBnumb.AutoSize = true;
            this.CBnumb.ForeColor = System.Drawing.Color.White;
            this.CBnumb.Location = new System.Drawing.Point(31, 102);
            this.CBnumb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBnumb.Name = "CBnumb";
            this.CBnumb.Size = new System.Drawing.Size(64, 20);
            this.CBnumb.TabIndex = 1;
            this.CBnumb.Text = "Numeri";
            this.CBnumb.UseVisualStyleBackColor = true;
            // 
            // CBinusual
            // 
            this.CBinusual.AutoSize = true;
            this.CBinusual.ForeColor = System.Drawing.Color.White;
            this.CBinusual.Location = new System.Drawing.Point(31, 144);
            this.CBinusual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBinusual.Name = "CBinusual";
            this.CBinusual.Size = new System.Drawing.Size(118, 20);
            this.CBinusual.TabIndex = 2;
            this.CBinusual.Text = "Caratteri Inusuali";
            this.CBinusual.UseVisualStyleBackColor = true;
            // 
            // CBmaiusc
            // 
            this.CBmaiusc.AutoSize = true;
            this.CBmaiusc.ForeColor = System.Drawing.Color.White;
            this.CBmaiusc.Location = new System.Drawing.Point(31, 185);
            this.CBmaiusc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBmaiusc.Name = "CBmaiusc";
            this.CBmaiusc.Size = new System.Drawing.Size(82, 20);
            this.CBmaiusc.TabIndex = 3;
            this.CBmaiusc.Text = "Maiuscole";
            this.CBmaiusc.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(31, 223);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Maximum = 52;
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(460, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.ForeColor = System.Drawing.Color.White;
            this.lValue.Location = new System.Drawing.Point(30, 261);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(54, 16);
            this.lValue.TabIndex = 6;
            this.lValue.Text = "Valore: 4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TBpw
            // 
            this.TBpw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TBpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBpw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBpw.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpw.ForeColor = System.Drawing.Color.White;
            this.TBpw.Location = new System.Drawing.Point(33, 60);
            this.TBpw.Name = "TBpw";
            this.TBpw.Size = new System.Drawing.Size(458, 21);
            this.TBpw.TabIndex = 7;
            this.TBpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(318, 31);
            this.progressBar1.Maximum = 344;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // TBstrenght
            // 
            this.TBstrenght.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TBstrenght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBstrenght.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBstrenght.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBstrenght.ForeColor = System.Drawing.Color.White;
            this.TBstrenght.Location = new System.Drawing.Point(318, 87);
            this.TBstrenght.MaxLength = 10000;
            this.TBstrenght.Name = "TBstrenght";
            this.TBstrenght.Size = new System.Drawing.Size(173, 21);
            this.TBstrenght.TabIndex = 9;
            this.TBstrenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.lTime.ForeColor = System.Drawing.Color.White;
            this.lTime.Location = new System.Drawing.Point(455, 313);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(59, 15);
            this.lTime.TabIndex = 10;
            this.lTime.Text = "HH:mm:ss";
            this.lTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.lData.ForeColor = System.Drawing.Color.White;
            this.lData.Location = new System.Drawing.Point(437, 328);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(77, 15);
            this.lData.TabIndex = 11;
            this.lData.Text = "dd/MM/yyyy";
            this.lData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(526, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lData);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.TBstrenght);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TBpw);
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.CBmaiusc);
            this.Controls.Add(this.CBinusual);
            this.Controls.Add(this.CBnumb);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator :: Main | Habby1337";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CBnumb;
        private System.Windows.Forms.CheckBox CBinusual;
        private System.Windows.Forms.CheckBox CBmaiusc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TBpw;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox TBstrenght;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.Button button1;
    }
}

