namespace QuanLyHoaDon
{
    partial class frmTraCuuHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.rdoMaHD = new System.Windows.Forms.RadioButton();
            this.rdoMaKH = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnTimTiep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoMaKH);
            this.groupBox1.Controls.Add(this.rdoMaHD);
            this.groupBox1.Controls.Add(this.txtThongTin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(171, 50);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(249, 20);
            this.txtThongTin.TabIndex = 1;
            // 
            // rdoMaHD
            // 
            this.rdoMaHD.AutoSize = true;
            this.rdoMaHD.Location = new System.Drawing.Point(128, 106);
            this.rdoMaHD.Name = "rdoMaHD";
            this.rdoMaHD.Size = new System.Drawing.Size(59, 17);
            this.rdoMaHD.TabIndex = 2;
            this.rdoMaHD.TabStop = true;
            this.rdoMaHD.Text = "Mã HĐ";
            this.rdoMaHD.UseVisualStyleBackColor = true;
            // 
            // rdoMaKH
            // 
            this.rdoMaKH.AutoSize = true;
            this.rdoMaKH.Location = new System.Drawing.Point(285, 106);
            this.rdoMaKH.Name = "rdoMaKH";
            this.rdoMaKH.Size = new System.Drawing.Size(100, 17);
            this.rdoMaKH.TabIndex = 2;
            this.rdoMaKH.TabStop = true;
            this.rdoMaKH.Text = "Mã khách hàng";
            this.rdoMaKH.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(140, 204);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(85, 23);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 233);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(760, 316);
            this.dgvHoaDon.TabIndex = 2;
            // 
            // btnTimTiep
            // 
            this.btnTimTiep.Location = new System.Drawing.Point(231, 204);
            this.btnTimTiep.Name = "btnTimTiep";
            this.btnTimTiep.Size = new System.Drawing.Size(85, 23);
            this.btnTimTiep.TabIndex = 1;
            this.btnTimTiep.Text = "Tìm tiếp";
            this.btnTimTiep.UseVisualStyleBackColor = true;
            this.btnTimTiep.Click += new System.EventHandler(this.btnTimTiep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(338, 204);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTraCuuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimTiep);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuHoaDon";
            this.Text = "frmTraCuuHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoMaKH;
        private System.Windows.Forms.RadioButton rdoMaHD;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnTimTiep;
        private System.Windows.Forms.Button btnThoat;
    }
}