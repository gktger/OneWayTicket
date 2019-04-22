namespace OneWayTicket.UI
{
    partial class SeferSecimi_Form
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
            this.dgw_seferListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_seferListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_seferListesi
            // 
            this.dgw_seferListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_seferListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_seferListesi.Location = new System.Drawing.Point(9, 10);
            this.dgw_seferListesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw_seferListesi.Name = "dgw_seferListesi";
            this.dgw_seferListesi.RowTemplate.Height = 24;
            this.dgw_seferListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_seferListesi.Size = new System.Drawing.Size(582, 346);
            this.dgw_seferListesi.TabIndex = 0;
            this.dgw_seferListesi.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_seferListesi_RowHeaderMouseDoubleClick);
            // 
            // SeferSecimi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgw_seferListesi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SeferSecimi_Form";
            this.Text = "One Way Ticket - Seferler";
            this.Load += new System.EventHandler(this.SeferSecimi_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_seferListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_seferListesi;
    }
}