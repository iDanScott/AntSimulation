﻿namespace AntSimulation
{
    partial class FrmAntJournal
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
            this.txtAntHistory = new System.Windows.Forms.TextBox();
            this.antSelector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.antSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAntHistory
            // 
            this.txtAntHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntHistory.Location = new System.Drawing.Point(0, 23);
            this.txtAntHistory.Multiline = true;
            this.txtAntHistory.Name = "txtAntHistory";
            this.txtAntHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAntHistory.Size = new System.Drawing.Size(284, 407);
            this.txtAntHistory.TabIndex = 0;
            // 
            // antSelector
            // 
            this.antSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.antSelector.Location = new System.Drawing.Point(0, 0);
            this.antSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.antSelector.Name = "antSelector";
            this.antSelector.Size = new System.Drawing.Size(284, 20);
            this.antSelector.TabIndex = 2;
            this.antSelector.ValueChanged += new System.EventHandler(this.antSelector_ValueChanged);
            // 
            // FrmAntJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 430);
            this.Controls.Add(this.antSelector);
            this.Controls.Add(this.txtAntHistory);
            this.Name = "FrmAntJournal";
            this.Text = "AntJournal";
            ((System.ComponentModel.ISupportInitialize)(this.antSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAntHistory;
        private System.Windows.Forms.NumericUpDown antSelector;
    }
}