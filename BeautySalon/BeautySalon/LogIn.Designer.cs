namespace BeautySalon
{
    partial class LogIn
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
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.uNametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(296, 175);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(125, 31);
            this.userName.TabIndex = 0;
            this.userName.Text = "Uername";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(289, 284);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(134, 31);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // uNametxt
            // 
            this.uNametxt.Location = new System.Drawing.Point(455, 161);
            this.uNametxt.Multiline = true;
            this.uNametxt.Name = "uNametxt";
            this.uNametxt.Size = new System.Drawing.Size(263, 57);
            this.uNametxt.TabIndex = 2;
            this.uNametxt.TextChanged += new System.EventHandler(this.uName_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(455, 269);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(263, 59);
            this.passtxt.TabIndex = 3;
            // 
            // logIn_btn
            // 
            this.logIn_btn.Location = new System.Drawing.Point(455, 396);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(233, 71);
            this.logIn_btn.TabIndex = 4;
            this.logIn_btn.Text = "Log in";
            this.logIn_btn.UseVisualStyleBackColor = true;
            this.logIn_btn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 663);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.uNametxt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox uNametxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button logIn_btn;
    }
}