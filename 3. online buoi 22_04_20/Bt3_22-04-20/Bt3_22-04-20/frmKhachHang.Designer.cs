namespace Bt3_22_04_20
{
    partial class frmKhachHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbNamsinh = new System.Windows.Forms.TextBox();
            this.tbDienthoai = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.rbGioitinh = new System.Windows.Forms.RadioButton();
            this.rbaGioitinh = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm sinh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "SĐT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(248, 56);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(216, 22);
            this.tbHoten.TabIndex = 1;
            this.tbHoten.TextChanged += new System.EventHandler(this.tbHoten_TextChanged);
            // 
            // tbNamsinh
            // 
            this.tbNamsinh.Location = new System.Drawing.Point(248, 141);
            this.tbNamsinh.Name = "tbNamsinh";
            this.tbNamsinh.Size = new System.Drawing.Size(216, 22);
            this.tbNamsinh.TabIndex = 1;
            this.tbNamsinh.TextChanged += new System.EventHandler(this.tbNamsinh_TextChanged);
            // 
            // tbDienthoai
            // 
            this.tbDienthoai.Location = new System.Drawing.Point(248, 184);
            this.tbDienthoai.Name = "tbDienthoai";
            this.tbDienthoai.Size = new System.Drawing.Size(216, 22);
            this.tbDienthoai.TabIndex = 1;
            this.tbDienthoai.TextChanged += new System.EventHandler(this.tbDienthoai_TextChanged);
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(248, 235);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(216, 22);
            this.tbDiachi.TabIndex = 1;
            this.tbDiachi.TextChanged += new System.EventHandler(this.tbDiachi_TextChanged);
            // 
            // rbGioitinh
            // 
            this.rbGioitinh.AutoSize = true;
            this.rbGioitinh.Location = new System.Drawing.Point(248, 99);
            this.rbGioitinh.Name = "rbGioitinh";
            this.rbGioitinh.Size = new System.Drawing.Size(58, 21);
            this.rbGioitinh.TabIndex = 2;
            this.rbGioitinh.Text = "Nam";
            this.rbGioitinh.UseVisualStyleBackColor = true;
            this.rbGioitinh.CheckedChanged += new System.EventHandler(this.rbGioitinh_CheckedChanged);
            // 
            // rbaGioitinh
            // 
            this.rbaGioitinh.AutoSize = true;
            this.rbaGioitinh.Location = new System.Drawing.Point(364, 99);
            this.rbaGioitinh.Name = "rbaGioitinh";
            this.rbaGioitinh.Size = new System.Drawing.Size(47, 21);
            this.rbaGioitinh.TabIndex = 2;
            this.rbaGioitinh.Text = "Nữ";
            this.rbaGioitinh.UseVisualStyleBackColor = true;
            this.rbaGioitinh.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(471, 321);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(109, 32);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 365);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rbaGioitinh);
            this.Controls.Add(this.rbGioitinh);
            this.Controls.Add(this.tbDiachi);
            this.Controls.Add(this.tbDienthoai);
            this.Controls.Add(this.tbNamsinh);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbHoten;
        public System.Windows.Forms.TextBox tbNamsinh;
        public System.Windows.Forms.TextBox tbDienthoai;
        public System.Windows.Forms.TextBox tbDiachi;
        public System.Windows.Forms.RadioButton rbGioitinh;
        private System.Windows.Forms.Button btOk;
        public System.Windows.Forms.RadioButton rbaGioitinh;
    }
}