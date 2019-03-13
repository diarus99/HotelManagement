namespace management_hotelier
{
    partial class Form2
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
            this.valabilitate = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valabilitate
            // 
            this.valabilitate.Location = new System.Drawing.Point(25, 38);
            this.valabilitate.Name = "valabilitate";
            this.valabilitate.Size = new System.Drawing.Size(75, 23);
            this.valabilitate.TabIndex = 3;
            this.valabilitate.Text = "Rezervare";
            this.valabilitate.UseVisualStyleBackColor = true;
            this.valabilitate.Click += new System.EventHandler(this.valabilitate_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(132, 38);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(81, 23);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 93);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.valabilitate);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button valabilitate;
        private System.Windows.Forms.Button logout;
    }
}