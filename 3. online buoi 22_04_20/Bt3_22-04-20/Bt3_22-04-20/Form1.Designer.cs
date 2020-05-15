namespace Bt3_22_04_20
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
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoaHet = new System.Windows.Forms.Button();
            this.btXemThongTin = new System.Windows.Forms.Button();
            this.lbKhachHang = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(12, 432);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(95, 34);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(159, 432);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(95, 34);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(314, 432);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(95, 34);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btXoaHet
            // 
            this.btXoaHet.Location = new System.Drawing.Point(462, 432);
            this.btXoaHet.Name = "btXoaHet";
            this.btXoaHet.Size = new System.Drawing.Size(95, 34);
            this.btXoaHet.TabIndex = 1;
            this.btXoaHet.Text = "xóa hết";
            this.btXoaHet.UseVisualStyleBackColor = true;
            this.btXoaHet.Click += new System.EventHandler(this.btXoaHet_Click);
            // 
            // btXemThongTin
            // 
            this.btXemThongTin.Location = new System.Drawing.Point(612, 432);
            this.btXemThongTin.Name = "btXemThongTin";
            this.btXemThongTin.Size = new System.Drawing.Size(95, 34);
            this.btXemThongTin.TabIndex = 1;
            this.btXemThongTin.Text = "thông tin";
            this.btXemThongTin.UseVisualStyleBackColor = true;
            this.btXemThongTin.Click += new System.EventHandler(this.btXemThongTin_Click);
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.FormattingEnabled = true;
            this.lbKhachHang.ItemHeight = 16;
            this.lbKhachHang.Location = new System.Drawing.Point(12, 30);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(695, 372);
            this.lbKhachHang.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 499);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.btXemThongTin);
            this.Controls.Add(this.btXoaHet);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoaHet;
        private System.Windows.Forms.Button btXemThongTin;
        private System.Windows.Forms.ListBox lbKhachHang;
    }
}

