namespace SBSH_reg
{
    partial class batchCategorie
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
            this.cbWeg = new System.Windows.Forms.CheckBox();
            this.cbBouw = new System.Windows.Forms.CheckBox();
            this.cbStorten = new System.Windows.Forms.CheckBox();
            this.dgvBouw = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.batch = new System.Windows.Forms.Button();
            this.catDeelbatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBouw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWeg
            // 
            this.cbWeg.AutoSize = true;
            this.cbWeg.Location = new System.Drawing.Point(71, 168);
            this.cbWeg.Name = "cbWeg";
            this.cbWeg.Size = new System.Drawing.Size(107, 17);
            this.cbWeg.TabIndex = 0;
            this.cbWeg.Text = "Weg- waterbouw";
            this.cbWeg.UseVisualStyleBackColor = true;
            this.cbWeg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbBouw
            // 
            this.cbBouw.AutoSize = true;
            this.cbBouw.Location = new System.Drawing.Point(71, 12);
            this.cbBouw.Name = "cbBouw";
            this.cbBouw.Size = new System.Drawing.Size(96, 17);
            this.cbBouw.TabIndex = 1;
            this.cbBouw.Text = "Bouwbedrijven";
            this.cbBouw.UseVisualStyleBackColor = true;
            this.cbBouw.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbStorten
            // 
            this.cbStorten.AutoSize = true;
            this.cbStorten.Location = new System.Drawing.Point(71, 324);
            this.cbStorten.Name = "cbStorten";
            this.cbStorten.Size = new System.Drawing.Size(60, 17);
            this.cbStorten.TabIndex = 2;
            this.cbStorten.Text = "Storten";
            this.cbStorten.UseVisualStyleBackColor = true;
            // 
            // dgvBouw
            // 
            this.dgvBouw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBouw.Location = new System.Drawing.Point(187, 12);
            this.dgvBouw.Name = "dgvBouw";
            this.dgvBouw.Size = new System.Drawing.Size(767, 141);
            this.dgvBouw.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 141);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(187, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(767, 141);
            this.dataGridView2.TabIndex = 6;
            // 
            // batch
            // 
            this.batch.Location = new System.Drawing.Point(187, 486);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(145, 34);
            this.batch.TabIndex = 7;
            this.batch.Text = "Registreren";
            this.batch.UseVisualStyleBackColor = true;
            this.batch.Click += new System.EventHandler(this.batch_Click);
            // 
            // catDeelbatch
            // 
            this.catDeelbatch.Location = new System.Drawing.Point(361, 486);
            this.catDeelbatch.Name = "catDeelbatch";
            this.catDeelbatch.Size = new System.Drawing.Size(145, 34);
            this.catDeelbatch.TabIndex = 8;
            this.catDeelbatch.Text = "Deelbatch";
            this.catDeelbatch.UseVisualStyleBackColor = true;
            // 
            // batchCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.catDeelbatch);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvBouw);
            this.Controls.Add(this.cbStorten);
            this.Controls.Add(this.cbBouw);
            this.Controls.Add(this.cbWeg);
            this.Name = "batchCategorie";
            this.Text = "Categorie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBouw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbWeg;
        private System.Windows.Forms.CheckBox cbBouw;
        private System.Windows.Forms.CheckBox cbStorten;
        private System.Windows.Forms.DataGridView dgvBouw;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button batch;
        private System.Windows.Forms.Button catDeelbatch;
    }
}