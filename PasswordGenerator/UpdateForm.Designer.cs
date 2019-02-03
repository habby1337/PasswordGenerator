namespace PasswordGenerator
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.bCheckUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCheckUpdate
            // 
            this.bCheckUpdate.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.bCheckUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.bCheckUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.bCheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCheckUpdate.ForeColor = System.Drawing.Color.White;
            this.bCheckUpdate.Location = new System.Drawing.Point(146, 309);
            this.bCheckUpdate.Name = "bCheckUpdate";
            this.bCheckUpdate.Size = new System.Drawing.Size(216, 32);
            this.bCheckUpdate.TabIndex = 13;
            this.bCheckUpdate.Text = "Check Update";
            this.bCheckUpdate.UseVisualStyleBackColor = true;
            this.bCheckUpdate.Click += new System.EventHandler(this.bCheckUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Versione Corrente: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBLog
            // 
            this.TBLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TBLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBLog.ForeColor = System.Drawing.Color.White;
            this.TBLog.Location = new System.Drawing.Point(63, 111);
            this.TBLog.Name = "TBLog";
            this.TBLog.Size = new System.Drawing.Size(382, 174);
            this.TBLog.TabIndex = 15;
            this.TBLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Server:  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 17;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(526, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCheckUpdate);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator :: Update | Habby1337";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCheckUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TBLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}