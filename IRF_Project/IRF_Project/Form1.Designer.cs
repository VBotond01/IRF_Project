﻿namespace IRF_Project
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.tmrSeconds = new System.Windows.Forms.Timer(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buttonback1 = new IRF_Project.Buttonback();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelBack1 = new IRF_Project.LabelBack();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 515);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.SystemColors.Control;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSeconds.Location = new System.Drawing.Point(643, 18);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(129, 20);
            this.lblSeconds.TabIndex = 5;
            this.lblSeconds.Text = "Eltöltött idő (mp):";
            // 
            // tmrSeconds
            // 
            this.tmrSeconds.Enabled = true;
            this.tmrSeconds.Interval = 1000;
            this.tmrSeconds.Tick += new System.EventHandler(this.tmrSeconds_Tick);
            // 
            // txtSearch
            // 
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txtSearch.Location = new System.Drawing.Point(170, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(149, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // buttonback1
            // 
            this.buttonback1.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonback1.Location = new System.Drawing.Point(12, 11);
            this.buttonback1.Name = "buttonback1";
            this.buttonback1.Size = new System.Drawing.Size(75, 23);
            this.buttonback1.TabIndex = 8;
            this.buttonback1.Text = "Mentés";
            this.buttonback1.UseVisualStyleBackColor = false;
            this.buttonback1.Click += new System.EventHandler(this.buttonback1_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(IRF_Project.Book);
            // 
            // labelBack1
            // 
            this.labelBack1.AutoSize = true;
            this.labelBack1.BackColor = System.Drawing.Color.AliceBlue;
            this.labelBack1.Location = new System.Drawing.Point(111, 17);
            this.labelBack1.Name = "labelBack1";
            this.labelBack1.Size = new System.Drawing.Size(42, 13);
            this.labelBack1.TabIndex = 9;
            this.labelBack1.Text = "Szerző:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(861, 595);
            this.Controls.Add(this.labelBack1);
            this.Controls.Add(this.buttonback1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Timer tmrSeconds;
        private System.Windows.Forms.TextBox txtSearch;
        private Buttonback buttonback1;
        private LabelBack labelBack1;
    }
}

