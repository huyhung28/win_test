namespace win_test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timkiem = new System.Windows.Forms.TextBox();
            this.txtmas = new System.Windows.Forms.TextBox();
            this.txtsol = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "tim kiem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "số lượng";
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(190, 28);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(441, 22);
            this.timkiem.TabIndex = 5;
            // 
            // txtmas
            // 
            this.txtmas.Location = new System.Drawing.Point(190, 99);
            this.txtmas.Name = "txtmas";
            this.txtmas.Size = new System.Drawing.Size(136, 22);
            this.txtmas.TabIndex = 6;
            // 
            // txtsol
            // 
            this.txtsol.Location = new System.Drawing.Point(507, 164);
            this.txtsol.Name = "txtsol";
            this.txtsol.Size = new System.Drawing.Size(136, 22);
            this.txtsol.TabIndex = 7;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(507, 99);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(136, 22);
            this.txttensach.TabIndex = 8;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(190, 161);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(136, 22);
            this.txtgia.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 141);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "them sach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "xoa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "sua";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timk
            // 
            this.timk.Location = new System.Drawing.Point(654, 28);
            this.timk.Name = "timk";
            this.timk.Size = new System.Drawing.Size(78, 28);
            this.timk.TabIndex = 14;
            this.timk.Text = "timkiem";
            this.timk.UseVisualStyleBackColor = true;
            this.timk.Click += new System.EventHandler(this.timk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timk);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtsol);
            this.Controls.Add(this.txtmas);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "quanlysach";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timkiem;
        private System.Windows.Forms.TextBox txtmas;
        private System.Windows.Forms.TextBox txtsol;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button timk;
    }
}

