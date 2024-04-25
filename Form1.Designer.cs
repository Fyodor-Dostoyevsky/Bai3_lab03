namespace Bai3_lab03
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
            this.lsbBangSo = new System.Windows.Forms.ListBox();
            this.btnTatCaBangSo = new System.Windows.Forms.Button();
            this.btn9nut = new System.Windows.Forms.Button();
            this.btnDoixung = new System.Windows.Forms.Button();
            this.btnGanh = new System.Windows.Forms.Button();
            this.btnTangLienTiep = new System.Windows.Forms.Button();
            this.btnKhonggiam = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbDem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbBangSo
            // 
            this.lsbBangSo.BackColor = System.Drawing.Color.GhostWhite;
            this.lsbBangSo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbBangSo.FormattingEnabled = true;
            this.lsbBangSo.ItemHeight = 25;
            this.lsbBangSo.Location = new System.Drawing.Point(21, 29);
            this.lsbBangSo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbBangSo.Name = "lsbBangSo";
            this.lsbBangSo.Size = new System.Drawing.Size(212, 529);
            this.lsbBangSo.TabIndex = 0;
            this.lsbBangSo.SelectedIndexChanged += new System.EventHandler(this.lsbBangSo_SelectedIndexChanged);
            // 
            // btnTatCaBangSo
            // 
            this.btnTatCaBangSo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTatCaBangSo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCaBangSo.Location = new System.Drawing.Point(256, 29);
            this.btnTatCaBangSo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTatCaBangSo.Name = "btnTatCaBangSo";
            this.btnTatCaBangSo.Size = new System.Drawing.Size(278, 41);
            this.btnTatCaBangSo.TabIndex = 1;
            this.btnTatCaBangSo.Text = "Tất cả các bảng số";
            this.btnTatCaBangSo.UseVisualStyleBackColor = false;
            this.btnTatCaBangSo.Click += new System.EventHandler(this.btnTatCaBangSo_Click);
            // 
            // btn9nut
            // 
            this.btn9nut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn9nut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9nut.Location = new System.Drawing.Point(256, 94);
            this.btn9nut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn9nut.Name = "btn9nut";
            this.btn9nut.Size = new System.Drawing.Size(278, 41);
            this.btn9nut.TabIndex = 2;
            this.btn9nut.Text = "Bảng số 9 nút: ";
            this.btn9nut.UseVisualStyleBackColor = false;
            this.btn9nut.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDoixung
            // 
            this.btnDoixung.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDoixung.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoixung.Location = new System.Drawing.Point(256, 159);
            this.btnDoixung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoixung.Name = "btnDoixung";
            this.btnDoixung.Size = new System.Drawing.Size(278, 41);
            this.btnDoixung.TabIndex = 3;
            this.btnDoixung.Text = "Bảng số đối xứng";
            this.btnDoixung.UseVisualStyleBackColor = false;
            this.btnDoixung.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGanh
            // 
            this.btnGanh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGanh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanh.Location = new System.Drawing.Point(256, 224);
            this.btnGanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGanh.Name = "btnGanh";
            this.btnGanh.Size = new System.Drawing.Size(278, 41);
            this.btnGanh.TabIndex = 4;
            this.btnGanh.Text = "Bảng số gánh";
            this.btnGanh.UseVisualStyleBackColor = false;
            this.btnGanh.Click += new System.EventHandler(this.btnGanh_Click);
            // 
            // btnTangLienTiep
            // 
            this.btnTangLienTiep.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTangLienTiep.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangLienTiep.Location = new System.Drawing.Point(256, 289);
            this.btnTangLienTiep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTangLienTiep.Name = "btnTangLienTiep";
            this.btnTangLienTiep.Size = new System.Drawing.Size(278, 41);
            this.btnTangLienTiep.TabIndex = 5;
            this.btnTangLienTiep.Text = "Bảng số có 3 số tăng liên tiếp ";
            this.btnTangLienTiep.UseVisualStyleBackColor = false;
            this.btnTangLienTiep.Click += new System.EventHandler(this.btnTangLienTiep_Click);
            // 
            // btnKhonggiam
            // 
            this.btnKhonggiam.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKhonggiam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhonggiam.Location = new System.Drawing.Point(256, 354);
            this.btnKhonggiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKhonggiam.Name = "btnKhonggiam";
            this.btnKhonggiam.Size = new System.Drawing.Size(278, 41);
            this.btnKhonggiam.TabIndex = 6;
            this.btnKhonggiam.Text = "Bảng số không giảm";
            this.btnKhonggiam.UseVisualStyleBackColor = false;
            this.btnKhonggiam.Click += new System.EventHandler(this.btnKhonggiam_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(256, 419);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(278, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button7_Click);
            // 
            // lbDem
            // 
            this.lbDem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDem.Location = new System.Drawing.Point(256, 485);
            this.lbDem.Name = "lbDem";
            this.lbDem.Size = new System.Drawing.Size(278, 73);
            this.lbDem.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(558, 625);
            this.Controls.Add(this.lbDem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhonggiam);
            this.Controls.Add(this.btnTangLienTiep);
            this.Controls.Add(this.btnGanh);
            this.Controls.Add(this.btnDoixung);
            this.Controls.Add(this.btn9nut);
            this.Controls.Add(this.btnTatCaBangSo);
            this.Controls.Add(this.lsbBangSo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbBangSo;
        private System.Windows.Forms.Button btnTatCaBangSo;
        private System.Windows.Forms.Button btn9nut;
        private System.Windows.Forms.Button btnDoixung;
        private System.Windows.Forms.Button btnGanh;
        private System.Windows.Forms.Button btnTangLienTiep;
        private System.Windows.Forms.Button btnKhonggiam;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbDem;
    }
}

