namespace ProjectPAS
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNama = new TextBox();
            txtUmur = new TextBox();
            txtAlamat = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            btnClear = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            pictureBox2 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            btnPrint = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(445, 35);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 5;
            label2.Text = "Care";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(377, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 4;
            label1.Text = "Pharma";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(47, 133);
            label3.Name = "label3";
            label3.Size = new Size(44, 18);
            label3.TabIndex = 6;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(47, 255);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 7;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(47, 196);
            label5.Name = "label5";
            label5.Size = new Size(43, 18);
            label5.TabIndex = 8;
            label5.Text = "Umur";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(140, 133);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(220, 27);
            txtNama.TabIndex = 9;
            // 
            // txtUmur
            // 
            txtUmur.Location = new Point(140, 196);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(220, 27);
            txtUmur.TabIndex = 10;
            txtUmur.TextChanged += txtUmur_TextChanged;
            txtUmur.KeyPress += textBox2_KeyPress;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(140, 246);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(220, 27);
            txtAlamat.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(105, 133);
            label6.Name = "label6";
            label6.Size = new Size(12, 18);
            label6.TabIndex = 12;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(105, 196);
            label7.Name = "label7";
            label7.Size = new Size(12, 18);
            label7.TabIndex = 13;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(105, 255);
            label8.Name = "label8";
            label8.Size = new Size(12, 18);
            label8.TabIndex = 14;
            label8.Text = ":";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.Navy;
            radioButton1.Location = new Point(550, 133);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 22);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Laki-Laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.Navy;
            radioButton2.Location = new Point(654, 133);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 22);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(423, 133);
            label9.Name = "label9";
            label9.Size = new Size(93, 18);
            label9.TabIndex = 17;
            label9.Text = "Jenis Kelamin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(522, 133);
            label10.Name = "label10";
            label10.Size = new Size(12, 18);
            label10.TabIndex = 18;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(423, 200);
            label11.Name = "label11";
            label11.Size = new Size(50, 18);
            label11.TabIndex = 19;
            label11.Text = "Dokter";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(522, 196);
            label12.Name = "label12";
            label12.Size = new Size(12, 18);
            label12.TabIndex = 20;
            label12.Text = ":";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "dr. Ahmad Fauzin, Sp.A     ", "dr. Agung Saputro, Sp.M ", "drg. Adia Laksita A", "dr. Afda Nakita               ", "dr. Andi Darwin, Sp.THT-kl    " });
            comboBox1.Location = new Point(550, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 28);
            comboBox1.TabIndex = 21;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Navy;
            btnClear.Location = new Point(313, 516);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreate
            // 
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Navy;
            btnCreate.Location = new Point(186, 516);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 24;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Navy;
            btnDelete.Location = new Point(445, 515);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(550, 248);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(522, 248);
            label13.Name = "label13";
            label13.Size = new Size(12, 18);
            label13.TabIndex = 30;
            label13.Text = ":";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(423, 255);
            label14.Name = "label14";
            label14.Size = new Size(54, 18);
            label14.TabIndex = 31;
            label14.Text = "Tanggal";
            // 
            // btnPrint
            // 
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Navy;
            btnPrint.Location = new Point(706, 515);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 32;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Navy;
            btnUpdate.Location = new Point(584, 514);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(790, 188);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnShow
            // 
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.ForeColor = Color.Navy;
            btnShow.Location = new Point(70, 516);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 35;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(858, 557);
            Controls.Add(btnShow);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnPrint);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox2);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnClear);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtAlamat);
            Controls.Add(txtUmur);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNama;
        private TextBox txtUmur;
        private TextBox txtAlamat;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboBox1;
        private Button btnClear;
        private Button btnCreate;
        private Button btnDelete;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private Label label14;
        private Button btnPrint;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnShow;
    }
}