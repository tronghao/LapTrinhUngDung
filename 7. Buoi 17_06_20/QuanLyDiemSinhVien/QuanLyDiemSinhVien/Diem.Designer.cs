namespace QuanLyDiemSinhVien
{
    partial class Diem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtDL1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDL2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDKT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSV = new System.Windows.Forms.ComboBox();
            this.cbMH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Môn Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Sinh Viên:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(607, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(518, 359);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(323, 359);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(422, 359);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(226, 359);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(125, 359);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(35, 88);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(647, 257);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // txtDL1
            // 
            this.txtDL1.Location = new System.Drawing.Point(111, 48);
            this.txtDL1.Name = "txtDL1";
            this.txtDL1.Size = new System.Drawing.Size(121, 20);
            this.txtDL1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Điểm Lần 1:";
            // 
            // txtDL2
            // 
            this.txtDL2.Location = new System.Drawing.Point(335, 48);
            this.txtDL2.Name = "txtDL2";
            this.txtDL2.Size = new System.Drawing.Size(123, 20);
            this.txtDL2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Điểm Lần 2:";
            // 
            // txtDKT
            // 
            this.txtDKT.Location = new System.Drawing.Point(568, 50);
            this.txtDKT.Name = "txtDKT";
            this.txtDKT.Size = new System.Drawing.Size(111, 20);
            this.txtDKT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Điểm Kết Thúc:";
            // 
            // cbSV
            // 
            this.cbSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSV.FormattingEnabled = true;
            this.cbSV.Location = new System.Drawing.Point(111, 19);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(121, 21);
            this.cbSV.TabIndex = 15;
            // 
            // cbMH
            // 
            this.cbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMH.FormattingEnabled = true;
            this.cbMH.Location = new System.Drawing.Point(337, 19);
            this.cbMH.Name = "cbMH";
            this.cbMH.Size = new System.Drawing.Size(121, 21);
            this.cbMH.TabIndex = 16;
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 394);
            this.Controls.Add(this.cbMH);
            this.Controls.Add(this.cbSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDKT);
            this.Controls.Add(this.txtDL2);
            this.Controls.Add(this.txtDL1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvData);
            this.Name = "Diem";
            this.Text = "Diem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtDL1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDL2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDKT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSV;
        private System.Windows.Forms.ComboBox cbMH;
    }
}