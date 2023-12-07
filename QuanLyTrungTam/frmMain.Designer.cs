namespace QuanLyTrungTam
{
    partial class frmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnngoaingu = new System.Windows.Forms.Button();
            this.btnlop = new System.Windows.Forms.Button();
            this.btnhocvien = new System.Windows.Forms.Button();
            this.btngiaovien = new System.Windows.Forms.Button();
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 24);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.btnthoat);
            this.panel3.Controls.Add(this.btnngoaingu);
            this.panel3.Controls.Add(this.btnlop);
            this.panel3.Controls.Add(this.btnhocvien);
            this.panel3.Controls.Add(this.btngiaovien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 38);
            this.panel3.TabIndex = 6;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnthoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnthoat.Location = new System.Drawing.Point(537, 0);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 38);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnngoaingu
            // 
            this.btnngoaingu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnngoaingu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnngoaingu.FlatAppearance.BorderSize = 0;
            this.btnngoaingu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnngoaingu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnngoaingu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnngoaingu.Location = new System.Drawing.Point(409, 0);
            this.btnngoaingu.Name = "btnngoaingu";
            this.btnngoaingu.Size = new System.Drawing.Size(128, 38);
            this.btnngoaingu.TabIndex = 4;
            this.btnngoaingu.Text = "Ngoại Ngữ";
            this.btnngoaingu.UseVisualStyleBackColor = false;
            this.btnngoaingu.Click += new System.EventHandler(this.btntrogiup_Click);
            // 
            // btnlop
            // 
            this.btnlop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnlop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnlop.FlatAppearance.BorderSize = 0;
            this.btnlop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnlop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnlop.Location = new System.Drawing.Point(244, 0);
            this.btnlop.Name = "btnlop";
            this.btnlop.Size = new System.Drawing.Size(165, 38);
            this.btnlop.TabIndex = 3;
            this.btnlop.Text = "Lớp ngọai ngữ";
            this.btnlop.UseVisualStyleBackColor = false;
            this.btnlop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnhocvien
            // 
            this.btnhocvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnhocvien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnhocvien.FlatAppearance.BorderSize = 0;
            this.btnhocvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhocvien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnhocvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnhocvien.Location = new System.Drawing.Point(122, 0);
            this.btnhocvien.Name = "btnhocvien";
            this.btnhocvien.Size = new System.Drawing.Size(122, 38);
            this.btnhocvien.TabIndex = 2;
            this.btnhocvien.Text = "Học viên";
            this.btnhocvien.UseVisualStyleBackColor = false;
            this.btnhocvien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngiaovien
            // 
            this.btngiaovien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btngiaovien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btngiaovien.FlatAppearance.BorderSize = 0;
            this.btngiaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiaovien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btngiaovien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btngiaovien.Location = new System.Drawing.Point(0, 0);
            this.btngiaovien.Name = "btngiaovien";
            this.btngiaovien.Size = new System.Drawing.Size(122, 38);
            this.btngiaovien.TabIndex = 1;
            this.btngiaovien.Text = "Giảng viên";
            this.btngiaovien.UseVisualStyleBackColor = false;
            this.btngiaovien.Click += new System.EventHandler(this.btnNhanVienTitle_Click_1);
            // 
            // dgvmain
            // 
            this.dgvmain.AllowUserToAddRows = false;
            this.dgvmain.AllowUserToDeleteRows = false;
            this.dgvmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Location = new System.Drawing.Point(13, 44);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.ReadOnly = true;
            this.dgvmain.RowHeadersWidth = 51;
            this.dgvmain.RowTemplate.Height = 24;
            this.dgvmain.Size = new System.Drawing.Size(1000, 486);
            this.dgvmain.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 560);
            this.Controls.Add(this.dgvmain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmMain";
            this.Text = "Quản Lý Trung Tâm Ngoại Ngữ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnngoaingu;
        private System.Windows.Forms.Button btnlop;
        private System.Windows.Forms.Button btnhocvien;
        private System.Windows.Forms.Button btngiaovien;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvmain;
    }
}

