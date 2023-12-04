namespace QuanLyTrungTam
{
    partial class frmSV
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
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(267, 6);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(102, 37);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinhvien.Location = new System.Drawing.Point(12, 49);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.RowHeadersWidth = 51;
            this.dgvsinhvien.RowTemplate.Height = 24;
            this.dgvsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsinhvien.Size = new System.Drawing.Size(1095, 429);
            this.dgvsinhvien.TabIndex = 6;
            this.dgvsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellContentClick);
            this.dgvsinhvien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh Sách Học Viên";
            // 
            // btntim
            // 
            this.btntim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(533, 6);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(123, 37);
            this.btntim.TabIndex = 9;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(386, 6);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(102, 37);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(663, 9);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(444, 30);
            this.txttimkiem.TabIndex = 11;
            // 
            // frmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 490);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvsinhvien);
            this.Name = "frmSV";
            this.Text = "frmHV";
            this.Load += new System.EventHandler(this.frmSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvsinhvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}