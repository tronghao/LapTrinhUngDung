namespace winform_b2
{
    partial class frm_phu
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
            this.dtgv_acc = new System.Windows.Forms.DataGridView();
            this.col_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_acc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // dtgv_acc
            // 
            this.dtgv_acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_acc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_hoten,
            this.col_sdt});
            this.dtgv_acc.Location = new System.Drawing.Point(38, 103);
            this.dtgv_acc.Name = "dtgv_acc";
            this.dtgv_acc.RowHeadersWidth = 51;
            this.dtgv_acc.RowTemplate.Height = 24;
            this.dtgv_acc.Size = new System.Drawing.Size(371, 256);
            this.dtgv_acc.TabIndex = 1;
            this.dtgv_acc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_acc_CellClick);
            // 
            // col_hoten
            // 
            this.col_hoten.HeaderText = "Họ Tên";
            this.col_hoten.MinimumWidth = 6;
            this.col_hoten.Name = "col_hoten";
            this.col_hoten.Width = 125;
            // 
            // col_sdt
            // 
            this.col_sdt.HeaderText = "SĐT";
            this.col_sdt.MinimumWidth = 6;
            this.col_sdt.Name = "col_sdt";
            this.col_sdt.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "SĐT:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(109, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 2;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(309, 46);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 22);
            this.txt_phone.TabIndex = 2;
            // 
            // frm_phu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 396);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dtgv_acc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_phu";
            this.Text = "frm_phu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_acc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        public System.Windows.Forms.DataGridView dtgv_acc;
    }
}