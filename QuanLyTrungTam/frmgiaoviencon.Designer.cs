namespace QuanLyTrungTam
{
    partial class frmgiaoviencon
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
            this.txtHoTenGiaoVien = new System.Windows.Forms.TextBox();
            this.txtDiaChiGiaoVien = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiGiaoVien = new System.Windows.Forms.TextBox();
            this.mtbGiaoVien = new System.Windows.Forms.MaskedTextBox();
            this.rbtNamGiaoVien = new System.Windows.Forms.RadioButton();
            this.rbtNuGiaoVien = new System.Windows.Forms.RadioButton();
            this.btnLuuGiaoVien = new System.Windows.Forms.Button();
            this.btnHuyGiaoVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Điện Thoại";
            // 
            // txtHoTenGiaoVien
            // 
            this.txtHoTenGiaoVien.Location = new System.Drawing.Point(147, 23);
            this.txtHoTenGiaoVien.Name = "txtHoTenGiaoVien";
            this.txtHoTenGiaoVien.Size = new System.Drawing.Size(203, 22);
            this.txtHoTenGiaoVien.TabIndex = 5;
            this.txtHoTenGiaoVien.TextChanged += new System.EventHandler(this.txtHoTenGiaoVien_TextChanged);
            // 
            // txtDiaChiGiaoVien
            // 
            this.txtDiaChiGiaoVien.Location = new System.Drawing.Point(147, 150);
            this.txtDiaChiGiaoVien.Name = "txtDiaChiGiaoVien";
            this.txtDiaChiGiaoVien.Size = new System.Drawing.Size(203, 22);
            this.txtDiaChiGiaoVien.TabIndex = 6;
            // 
            // txtSoDienThoaiGiaoVien
            // 
            this.txtSoDienThoaiGiaoVien.Location = new System.Drawing.Point(147, 201);
            this.txtSoDienThoaiGiaoVien.Name = "txtSoDienThoaiGiaoVien";
            this.txtSoDienThoaiGiaoVien.Size = new System.Drawing.Size(203, 22);
            this.txtSoDienThoaiGiaoVien.TabIndex = 7;
            // 
            // mtbGiaoVien
            // 
            this.mtbGiaoVien.Location = new System.Drawing.Point(147, 62);
            this.mtbGiaoVien.Mask = "00/00/0000";
            this.mtbGiaoVien.Name = "mtbGiaoVien";
            this.mtbGiaoVien.Size = new System.Drawing.Size(80, 22);
            this.mtbGiaoVien.TabIndex = 8;
            this.mtbGiaoVien.ValidatingType = typeof(System.DateTime);
            // 
            // rbtNamGiaoVien
            // 
            this.rbtNamGiaoVien.AutoSize = true;
            this.rbtNamGiaoVien.Checked = true;
            this.rbtNamGiaoVien.Location = new System.Drawing.Point(147, 106);
            this.rbtNamGiaoVien.Name = "rbtNamGiaoVien";
            this.rbtNamGiaoVien.Size = new System.Drawing.Size(57, 20);
            this.rbtNamGiaoVien.TabIndex = 9;
            this.rbtNamGiaoVien.TabStop = true;
            this.rbtNamGiaoVien.Text = "Nam";
            this.rbtNamGiaoVien.UseVisualStyleBackColor = true;
            // 
            // rbtNuGiaoVien
            // 
            this.rbtNuGiaoVien.AutoSize = true;
            this.rbtNuGiaoVien.Location = new System.Drawing.Point(229, 106);
            this.rbtNuGiaoVien.Name = "rbtNuGiaoVien";
            this.rbtNuGiaoVien.Size = new System.Drawing.Size(45, 20);
            this.rbtNuGiaoVien.TabIndex = 10;
            this.rbtNuGiaoVien.TabStop = true;
            this.rbtNuGiaoVien.Text = "Nữ";
            this.rbtNuGiaoVien.UseVisualStyleBackColor = true;
            // 
            // btnLuuGiaoVien
            // 
            this.btnLuuGiaoVien.Location = new System.Drawing.Point(147, 257);
            this.btnLuuGiaoVien.Name = "btnLuuGiaoVien";
            this.btnLuuGiaoVien.Size = new System.Drawing.Size(75, 23);
            this.btnLuuGiaoVien.TabIndex = 11;
            this.btnLuuGiaoVien.Text = "Lưu";
            this.btnLuuGiaoVien.UseVisualStyleBackColor = true;
            this.btnLuuGiaoVien.Click += new System.EventHandler(this.btnLuuGiaoVien_Click);
            // 
            // btnHuyGiaoVien
            // 
            this.btnHuyGiaoVien.Location = new System.Drawing.Point(275, 257);
            this.btnHuyGiaoVien.Name = "btnHuyGiaoVien";
            this.btnHuyGiaoVien.Size = new System.Drawing.Size(75, 23);
            this.btnHuyGiaoVien.TabIndex = 12;
            this.btnHuyGiaoVien.Text = "Hủy";
            this.btnHuyGiaoVien.UseVisualStyleBackColor = true;
            this.btnHuyGiaoVien.Click += new System.EventHandler(this.btnHuyGiaoVien_Click);
            // 
            // frmgiaoviencon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 333);
            this.Controls.Add(this.btnHuyGiaoVien);
            this.Controls.Add(this.btnLuuGiaoVien);
            this.Controls.Add(this.rbtNuGiaoVien);
            this.Controls.Add(this.rbtNamGiaoVien);
            this.Controls.Add(this.mtbGiaoVien);
            this.Controls.Add(this.txtSoDienThoaiGiaoVien);
            this.Controls.Add(this.txtDiaChiGiaoVien);
            this.Controls.Add(this.txtHoTenGiaoVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmgiaoviencon";
            this.Text = "frmgiaoviencon";
            this.Load += new System.EventHandler(this.frmgiaoviencon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTenGiaoVien;
        private System.Windows.Forms.TextBox txtDiaChiGiaoVien;
        private System.Windows.Forms.TextBox txtSoDienThoaiGiaoVien;
        private System.Windows.Forms.MaskedTextBox mtbGiaoVien;
        private System.Windows.Forms.RadioButton rbtNamGiaoVien;
        private System.Windows.Forms.RadioButton rbtNuGiaoVien;
        private System.Windows.Forms.Button btnLuuGiaoVien;
        private System.Windows.Forms.Button btnHuyGiaoVien;
    }
}