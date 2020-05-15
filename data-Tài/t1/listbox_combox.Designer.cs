namespace t1
{
    partial class listbox_combox
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
            this.ltb = new System.Windows.Forms.ListBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.btt_add = new System.Windows.Forms.Button();
            this.btt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltb
            // 
            this.ltb.FormattingEnabled = true;
            this.ltb.ItemHeight = 16;
            this.ltb.Items.AddRange(new object[] {
            "Món 1",
            "Món 2",
            "Món 3",
            "Món 4",
            "Món 5"});
            this.ltb.Location = new System.Drawing.Point(15, 60);
            this.ltb.Name = "ltb";
            this.ltb.Size = new System.Drawing.Size(153, 100);
            this.ltb.TabIndex = 0;
            this.ltb.SelectedIndexChanged += new System.EventHandler(this.ltb_SelectedIndexChanged);
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(15, 32);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(153, 22);
            this.txt_add.TabIndex = 1;
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(174, 32);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(75, 23);
            this.btt_add.TabIndex = 2;
            this.btt_add.Text = "Add";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // btt_exit
            // 
            this.btt_exit.Location = new System.Drawing.Point(342, 314);
            this.btt_exit.Name = "btt_exit";
            this.btt_exit.Size = new System.Drawing.Size(75, 23);
            this.btt_exit.TabIndex = 2;
            this.btt_exit.Text = "Exit";
            this.btt_exit.UseVisualStyleBackColor = true;
            // 
            // listbox_combox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 349);
            this.Controls.Add(this.btt_exit);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.ltb);
            this.Name = "listbox_combox";
            this.Text = "listbox_combox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.Button btt_exit;
    }
}