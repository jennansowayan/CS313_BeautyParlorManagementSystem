namespace BeautySalon
{
    partial class Services
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salonlstbx = new System.Windows.Forms.CheckedListBox();
            this.citylbx = new System.Windows.Forms.CheckedListBox();
            this.servicelbx = new System.Windows.Forms.CheckedListBox();
            this.nextbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service";
            // 
            // salonlstbx
            // 
            this.salonlstbx.FormattingEnabled = true;
            this.salonlstbx.Items.AddRange(new object[] {
            "Salon1",
            "Salon2",
            "Salon3"});
            this.salonlstbx.Location = new System.Drawing.Point(482, 211);
            this.salonlstbx.Name = "salonlstbx";
            this.salonlstbx.Size = new System.Drawing.Size(436, 88);
            this.salonlstbx.TabIndex = 4;
            // 
            // citylbx
            // 
            this.citylbx.FormattingEnabled = true;
            this.citylbx.Items.AddRange(new object[] {
            "Riyadh",
            "Jeddah"});
            this.citylbx.Location = new System.Drawing.Point(482, 406);
            this.citylbx.Name = "citylbx";
            this.citylbx.Size = new System.Drawing.Size(436, 60);
            this.citylbx.TabIndex = 5;
            // 
            // servicelbx
            // 
            this.servicelbx.FormattingEnabled = true;
            this.servicelbx.Items.AddRange(new object[] {
            "Hair",
            "Nails"});
            this.servicelbx.Location = new System.Drawing.Point(482, 589);
            this.servicelbx.Name = "servicelbx";
            this.servicelbx.Size = new System.Drawing.Size(397, 60);
            this.servicelbx.TabIndex = 6;
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(1141, 604);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(245, 72);
            this.nextbtn.TabIndex = 7;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 782);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.servicelbx);
            this.Controls.Add(this.citylbx);
            this.Controls.Add(this.salonlstbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Services";
            this.Text = "Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox salonlstbx;
        private System.Windows.Forms.CheckedListBox citylbx;
        private System.Windows.Forms.CheckedListBox servicelbx;
        private System.Windows.Forms.Button nextbtn;
    }
}