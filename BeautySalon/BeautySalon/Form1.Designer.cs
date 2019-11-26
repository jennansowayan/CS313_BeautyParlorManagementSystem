namespace BeautySalon
{
    partial class beautySalon
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
            this.logIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(295, 420);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(223, 69);
            this.logIn.TabIndex = 0;
            this.logIn.Text = "Log in";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(755, 420);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(230, 69);
            this.signUp.TabIndex = 1;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = true;
            // 
            // beautySalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 641);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.logIn);
            this.Name = "beautySalon";
            this.Text = "Beauty Salon";
            this.Load += new System.EventHandler(this.beautySalon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button signUp;
    }
}

