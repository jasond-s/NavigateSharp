namespace NavigateSharp.Example.Forms.Presenters
{
    partial class Products
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
            this.productsText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productsText
            // 
            this.productsText.AutoSize = true;
            this.productsText.Location = new System.Drawing.Point(101, 117);
            this.productsText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productsText.Name = "productsText";
            this.productsText.Size = new System.Drawing.Size(67, 13);
            this.productsText.TabIndex = 0;
            this.productsText.Text = "PRODUCTS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productsText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Products";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productsText;
        private System.Windows.Forms.Button button1;
    }
}