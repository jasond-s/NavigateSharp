namespace NavigateSharp.Forms.Presentation.Presenters
{
    partial class Welcome
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.welcomeOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Location = new System.Drawing.Point(13, 13);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(153, 25);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome - xxx";
            // 
            // welcomeOk
            // 
            this.welcomeOk.Location = new System.Drawing.Point(126, 149);
            this.welcomeOk.Name = "welcomeOk";
            this.welcomeOk.Size = new System.Drawing.Size(136, 68);
            this.welcomeOk.TabIndex = 1;
            this.welcomeOk.Text = "OK";
            this.welcomeOk.UseVisualStyleBackColor = true;
            this.welcomeOk.Click += new System.EventHandler(this.WelcomeOk_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Controls.Add(this.welcomeOk);
            this.Controls.Add(this.welcomeText);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button welcomeOk;
    }
}

