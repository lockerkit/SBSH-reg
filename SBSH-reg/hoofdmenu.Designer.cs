namespace SBSH_reg
{
    partial class hoofdmenu
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
            this.account = new System.Windows.Forms.Button();
            this.batch = new System.Windows.Forms.Button();
            this.opbrengst = new System.Windows.Forms.Button();
            this.sloop = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(27, 27);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(145, 34);
            this.account.TabIndex = 0;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // batch
            // 
            this.batch.Location = new System.Drawing.Point(27, 88);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(145, 34);
            this.batch.TabIndex = 1;
            this.batch.Text = "Batch";
            this.batch.UseVisualStyleBackColor = true;
            this.batch.Click += new System.EventHandler(this.button2_Click);
            // 
            // opbrengst
            // 
            this.opbrengst.Location = new System.Drawing.Point(27, 150);
            this.opbrengst.Name = "opbrengst";
            this.opbrengst.Size = new System.Drawing.Size(145, 34);
            this.opbrengst.TabIndex = 2;
            this.opbrengst.Text = "Opbrengst";
            this.opbrengst.UseVisualStyleBackColor = true;
            this.opbrengst.Click += new System.EventHandler(this.button3_Click);
            // 
            // sloop
            // 
            this.sloop.Location = new System.Drawing.Point(27, 213);
            this.sloop.Name = "sloop";
            this.sloop.Size = new System.Drawing.Size(145, 34);
            this.sloop.TabIndex = 3;
            this.sloop.Text = "Slooplocatie";
            this.sloop.UseVisualStyleBackColor = true;
            this.sloop.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 631);
            this.Controls.Add(this.sloop);
            this.Controls.Add(this.opbrengst);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.account);
            this.Name = "hoofdmenu";
            this.Text = "Hoofdmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button batch;
        private System.Windows.Forms.Button opbrengst;
        private System.Windows.Forms.Button sloop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}