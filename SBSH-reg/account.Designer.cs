namespace SBSH_reg
{
    partial class Account
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
            this.accRegistreren = new System.Windows.Forms.Button();
            this.accOpzoeken = new System.Windows.Forms.Button();
            this.accBewerken = new System.Windows.Forms.Button();
            this.accVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accRegistreren
            // 
            this.accRegistreren.Location = new System.Drawing.Point(33, 44);
            this.accRegistreren.Name = "accRegistreren";
            this.accRegistreren.Size = new System.Drawing.Size(145, 34);
            this.accRegistreren.TabIndex = 1;
            this.accRegistreren.Text = "Account registratie";
            this.accRegistreren.UseVisualStyleBackColor = true;
            this.accRegistreren.Click += new System.EventHandler(this.button1_Click);
            // 
            // accOpzoeken
            // 
            this.accOpzoeken.Location = new System.Drawing.Point(33, 106);
            this.accOpzoeken.Name = "accOpzoeken";
            this.accOpzoeken.Size = new System.Drawing.Size(145, 34);
            this.accOpzoeken.TabIndex = 2;
            this.accOpzoeken.Text = "Account opzoeken";
            this.accOpzoeken.UseVisualStyleBackColor = true;
            // 
            // accBewerken
            // 
            this.accBewerken.Location = new System.Drawing.Point(33, 170);
            this.accBewerken.Name = "accBewerken";
            this.accBewerken.Size = new System.Drawing.Size(145, 34);
            this.accBewerken.TabIndex = 3;
            this.accBewerken.Text = "Account bewerken";
            this.accBewerken.UseVisualStyleBackColor = true;
            // 
            // accVerwijderen
            // 
            this.accVerwijderen.Location = new System.Drawing.Point(33, 234);
            this.accVerwijderen.Name = "accVerwijderen";
            this.accVerwijderen.Size = new System.Drawing.Size(145, 34);
            this.accVerwijderen.TabIndex = 4;
            this.accVerwijderen.Text = "Account verwijderen";
            this.accVerwijderen.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.accVerwijderen);
            this.Controls.Add(this.accBewerken);
            this.Controls.Add(this.accOpzoeken);
            this.Controls.Add(this.accRegistreren);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accRegistreren;
        private System.Windows.Forms.Button accOpzoeken;
        private System.Windows.Forms.Button accBewerken;
        private System.Windows.Forms.Button accVerwijderen;
    }
}