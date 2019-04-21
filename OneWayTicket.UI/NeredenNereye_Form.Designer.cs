namespace OneWayTicket.UI
{
    partial class Main_Form
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
            this.cmb_Nereden = new System.Windows.Forms.ComboBox();
            this.cmb_Nereye = new System.Windows.Forms.ComboBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEREDEN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEREYE :";
            // 
            // cmb_Nereden
            // 
            this.cmb_Nereden.FormattingEnabled = true;
            this.cmb_Nereden.Location = new System.Drawing.Point(149, 29);
            this.cmb_Nereden.Name = "cmb_Nereden";
            this.cmb_Nereden.Size = new System.Drawing.Size(121, 33);
            this.cmb_Nereden.TabIndex = 1;
            // 
            // cmb_Nereye
            // 
            this.cmb_Nereye.FormattingEnabled = true;
            this.cmb_Nereye.Location = new System.Drawing.Point(419, 29);
            this.cmb_Nereye.Name = "cmb_Nereye";
            this.cmb_Nereye.Size = new System.Drawing.Size(121, 33);
            this.cmb_Nereye.TabIndex = 1;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(31, 79);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(509, 43);
            this.btn_Ara.TabIndex = 2;
            this.btn_Ara.Text = "ARA";
            this.btn_Ara.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 137);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.cmb_Nereye);
            this.Controls.Add(this.cmb_Nereden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main_Form";
            this.Text = "One Way Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Nereden;
        private System.Windows.Forms.ComboBox cmb_Nereye;
        private System.Windows.Forms.Button btn_Ara;
    }
}

