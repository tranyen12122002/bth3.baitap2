namespace bth3.baitap2
{
    partial class Pheptinh
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
            this.components = new System.ComponentModel.Container();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.rbcong = new System.Windows.Forms.RadioButton();
            this.rbtru = new System.Windows.Forms.RadioButton();
            this.rbchia = new System.Windows.Forms.RadioButton();
            this.rbnhan = new System.Windows.Forms.RadioButton();
            this.gbpheptinh = new System.Windows.Forms.GroupBox();
            this.lbketqua = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbpheptinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(55, 29);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 22);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Số 1";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(55, 71);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(46, 22);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Số 2";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(123, 26);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(348, 29);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(123, 68);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(348, 29);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // rbcong
            // 
            this.rbcong.AutoSize = true;
            this.rbcong.Location = new System.Drawing.Point(20, 28);
            this.rbcong.Name = "rbcong";
            this.rbcong.Size = new System.Drawing.Size(72, 26);
            this.rbcong.TabIndex = 4;
            this.rbcong.TabStop = true;
            this.rbcong.Text = "Cộng";
            this.rbcong.UseVisualStyleBackColor = true;
            this.rbcong.CheckedChanged += new System.EventHandler(this.rbcong_CheckedChanged);
            // 
            // rbtru
            // 
            this.rbtru.AutoSize = true;
            this.rbtru.Location = new System.Drawing.Point(119, 28);
            this.rbtru.Name = "rbtru";
            this.rbtru.Size = new System.Drawing.Size(59, 26);
            this.rbtru.TabIndex = 5;
            this.rbtru.TabStop = true;
            this.rbtru.Text = "Trừ";
            this.rbtru.UseVisualStyleBackColor = true;
            this.rbtru.CheckedChanged += new System.EventHandler(this.rbtru_CheckedChanged);
            // 
            // rbchia
            // 
            this.rbchia.AutoSize = true;
            this.rbchia.Location = new System.Drawing.Point(328, 28);
            this.rbchia.Name = "rbchia";
            this.rbchia.Size = new System.Drawing.Size(65, 26);
            this.rbchia.TabIndex = 6;
            this.rbchia.TabStop = true;
            this.rbchia.Text = "Chia";
            this.rbchia.UseVisualStyleBackColor = true;
            this.rbchia.CheckedChanged += new System.EventHandler(this.rbchia_CheckedChanged);
            // 
            // rbnhan
            // 
            this.rbnhan.AutoSize = true;
            this.rbnhan.Location = new System.Drawing.Point(217, 28);
            this.rbnhan.Name = "rbnhan";
            this.rbnhan.Size = new System.Drawing.Size(72, 26);
            this.rbnhan.TabIndex = 7;
            this.rbnhan.TabStop = true;
            this.rbnhan.Text = "Nhân";
            this.rbnhan.UseVisualStyleBackColor = true;
            this.rbnhan.CheckedChanged += new System.EventHandler(this.rbnhan_CheckedChanged);
            // 
            // gbpheptinh
            // 
            this.gbpheptinh.Controls.Add(this.rbchia);
            this.gbpheptinh.Controls.Add(this.rbcong);
            this.gbpheptinh.Controls.Add(this.rbtru);
            this.gbpheptinh.Controls.Add(this.rbnhan);
            this.gbpheptinh.Location = new System.Drawing.Point(54, 117);
            this.gbpheptinh.Name = "gbpheptinh";
            this.gbpheptinh.Size = new System.Drawing.Size(417, 68);
            this.gbpheptinh.TabIndex = 8;
            this.gbpheptinh.TabStop = false;
            this.gbpheptinh.Text = "Phép tính";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Location = new System.Drawing.Point(30, 203);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(71, 22);
            this.lbketqua.TabIndex = 9;
            this.lbketqua.Text = "Kết quả";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(123, 200);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(348, 29);
            this.txtketqua.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Pheptinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 255);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.gbpheptinh);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pheptinh";
            this.Text = "Phép tính";
            this.Load += new System.EventHandler(this.Pheptinh_Load);
            this.gbpheptinh.ResumeLayout(false);
            this.gbpheptinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RadioButton rbcong;
        private System.Windows.Forms.RadioButton rbtru;
        private System.Windows.Forms.RadioButton rbchia;
        private System.Windows.Forms.RadioButton rbnhan;
        private System.Windows.Forms.GroupBox gbpheptinh;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

