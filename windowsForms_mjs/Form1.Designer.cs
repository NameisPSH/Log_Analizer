namespace windowsForms_mjs
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonPerson = new System.Windows.Forms.Button();
            this.textBoxSFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonTeam = new System.Windows.Forms.Button();
            this.buttonT5 = new System.Windows.Forms.Button();
            this.buttonT4 = new System.Windows.Forms.Button();
            this.textBoxT5 = new System.Windows.Forms.TextBox();
            this.textBoxT4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonT5 = new System.Windows.Forms.RadioButton();
            this.radioButtonT4 = new System.Windows.Forms.RadioButton();
            this.radioButtonT3 = new System.Windows.Forms.RadioButton();
            this.radioButtonT2 = new System.Windows.Forms.RadioButton();
            this.buttonT3 = new System.Windows.Forms.Button();
            this.buttonT2 = new System.Windows.Forms.Button();
            this.buttonT1 = new System.Windows.Forms.Button();
            this.textBoxT3 = new System.Windows.Forms.TextBox();
            this.textBoxT2 = new System.Windows.Forms.TextBox();
            this.textBoxT1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_graph = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_bmp_save = new System.Windows.Forms.Button();
            this.button_excel_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog5 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog6 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPerson);
            this.tabPage1.Controls.Add(this.textBoxSFile);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "개인별";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonPerson
            // 
            this.buttonPerson.Location = new System.Drawing.Point(184, 161);
            this.buttonPerson.Name = "buttonPerson";
            this.buttonPerson.Size = new System.Drawing.Size(127, 39);
            this.buttonPerson.TabIndex = 1;
            this.buttonPerson.Text = "분석시작";
            this.buttonPerson.UseVisualStyleBackColor = true;
            this.buttonPerson.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSFile
            // 
            this.textBoxSFile.Location = new System.Drawing.Point(37, 85);
            this.textBoxSFile.Name = "textBoxSFile";
            this.textBoxSFile.Size = new System.Drawing.Size(321, 21);
            this.textBoxSFile.TabIndex = 2;
            this.textBoxSFile.TextChanged += new System.EventHandler(this.textBoxSFile_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "불러오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonTeam);
            this.tabPage2.Controls.Add(this.buttonT5);
            this.tabPage2.Controls.Add(this.buttonT4);
            this.tabPage2.Controls.Add(this.textBoxT5);
            this.tabPage2.Controls.Add(this.textBoxT4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonT3);
            this.tabPage2.Controls.Add(this.buttonT2);
            this.tabPage2.Controls.Add(this.buttonT1);
            this.tabPage2.Controls.Add(this.textBoxT3);
            this.tabPage2.Controls.Add(this.textBoxT2);
            this.tabPage2.Controls.Add(this.textBoxT1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "팀별";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonTeam
            // 
            this.buttonTeam.Location = new System.Drawing.Point(184, 225);
            this.buttonTeam.Name = "buttonTeam";
            this.buttonTeam.Size = new System.Drawing.Size(130, 38);
            this.buttonTeam.TabIndex = 13;
            this.buttonTeam.Text = "분석시작";
            this.buttonTeam.UseVisualStyleBackColor = true;
            this.buttonTeam.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonT5
            // 
            this.buttonT5.Location = new System.Drawing.Point(403, 196);
            this.buttonT5.Name = "buttonT5";
            this.buttonT5.Size = new System.Drawing.Size(75, 23);
            this.buttonT5.TabIndex = 12;
            this.buttonT5.Text = "불러오기";
            this.buttonT5.UseVisualStyleBackColor = true;
            this.buttonT5.Visible = false;
            this.buttonT5.Click += new System.EventHandler(this.buttonT5_Click);
            // 
            // buttonT4
            // 
            this.buttonT4.Location = new System.Drawing.Point(403, 167);
            this.buttonT4.Name = "buttonT4";
            this.buttonT4.Size = new System.Drawing.Size(75, 23);
            this.buttonT4.TabIndex = 11;
            this.buttonT4.Text = "불러오기";
            this.buttonT4.UseVisualStyleBackColor = true;
            this.buttonT4.Click += new System.EventHandler(this.buttonT4_Click);
            // 
            // textBoxT5
            // 
            this.textBoxT5.Location = new System.Drawing.Point(36, 198);
            this.textBoxT5.Name = "textBoxT5";
            this.textBoxT5.Size = new System.Drawing.Size(356, 21);
            this.textBoxT5.TabIndex = 10;
            this.textBoxT5.Visible = false;
            this.textBoxT5.TextChanged += new System.EventHandler(this.textBoxT5_TextChanged);
            // 
            // textBoxT4
            // 
            this.textBoxT4.Location = new System.Drawing.Point(36, 167);
            this.textBoxT4.Name = "textBoxT4";
            this.textBoxT4.Size = new System.Drawing.Size(357, 21);
            this.textBoxT4.TabIndex = 9;
            this.textBoxT4.TextChanged += new System.EventHandler(this.textBoxT4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonT5);
            this.groupBox1.Controls.Add(this.radioButtonT4);
            this.groupBox1.Controls.Add(this.radioButtonT3);
            this.groupBox1.Controls.Add(this.radioButtonT2);
            this.groupBox1.Location = new System.Drawing.Point(36, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "팀 수";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonT5
            // 
            this.radioButtonT5.AutoSize = true;
            this.radioButtonT5.Location = new System.Drawing.Point(354, 20);
            this.radioButtonT5.Name = "radioButtonT5";
            this.radioButtonT5.Size = new System.Drawing.Size(29, 16);
            this.radioButtonT5.TabIndex = 3;
            this.radioButtonT5.Text = "5";
            this.radioButtonT5.UseVisualStyleBackColor = true;
            this.radioButtonT5.CheckedChanged += new System.EventHandler(this.radioButtonT5_CheckedChanged);
            // 
            // radioButtonT4
            // 
            this.radioButtonT4.AutoSize = true;
            this.radioButtonT4.Location = new System.Drawing.Point(249, 20);
            this.radioButtonT4.Name = "radioButtonT4";
            this.radioButtonT4.Size = new System.Drawing.Size(29, 16);
            this.radioButtonT4.TabIndex = 2;
            this.radioButtonT4.Text = "4";
            this.radioButtonT4.UseVisualStyleBackColor = true;
            this.radioButtonT4.CheckedChanged += new System.EventHandler(this.radioButtonT4_CheckedChanged);
            // 
            // radioButtonT3
            // 
            this.radioButtonT3.AutoSize = true;
            this.radioButtonT3.Location = new System.Drawing.Point(148, 18);
            this.radioButtonT3.Name = "radioButtonT3";
            this.radioButtonT3.Size = new System.Drawing.Size(29, 16);
            this.radioButtonT3.TabIndex = 1;
            this.radioButtonT3.Text = "3";
            this.radioButtonT3.UseVisualStyleBackColor = true;
            this.radioButtonT3.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonT2
            // 
            this.radioButtonT2.AutoSize = true;
            this.radioButtonT2.Checked = true;
            this.radioButtonT2.Location = new System.Drawing.Point(37, 18);
            this.radioButtonT2.Name = "radioButtonT2";
            this.radioButtonT2.Size = new System.Drawing.Size(29, 16);
            this.radioButtonT2.TabIndex = 0;
            this.radioButtonT2.TabStop = true;
            this.radioButtonT2.Text = "2";
            this.radioButtonT2.UseVisualStyleBackColor = true;
            this.radioButtonT2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonT3
            // 
            this.buttonT3.Location = new System.Drawing.Point(403, 142);
            this.buttonT3.Name = "buttonT3";
            this.buttonT3.Size = new System.Drawing.Size(78, 19);
            this.buttonT3.TabIndex = 7;
            this.buttonT3.Text = "불러오기";
            this.buttonT3.UseVisualStyleBackColor = true;
            this.buttonT3.Visible = false;
            this.buttonT3.Click += new System.EventHandler(this.buttonT3_Click);
            // 
            // buttonT2
            // 
            this.buttonT2.Location = new System.Drawing.Point(404, 113);
            this.buttonT2.Name = "buttonT2";
            this.buttonT2.Size = new System.Drawing.Size(76, 21);
            this.buttonT2.TabIndex = 6;
            this.buttonT2.Text = "불러오기";
            this.buttonT2.UseVisualStyleBackColor = true;
            this.buttonT2.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonT1
            // 
            this.buttonT1.Location = new System.Drawing.Point(404, 85);
            this.buttonT1.Name = "buttonT1";
            this.buttonT1.Size = new System.Drawing.Size(77, 20);
            this.buttonT1.TabIndex = 5;
            this.buttonT1.Text = "불러오기";
            this.buttonT1.UseVisualStyleBackColor = true;
            this.buttonT1.Visible = false;
            this.buttonT1.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxT3
            // 
            this.textBoxT3.Location = new System.Drawing.Point(36, 140);
            this.textBoxT3.Name = "textBoxT3";
            this.textBoxT3.Size = new System.Drawing.Size(357, 21);
            this.textBoxT3.TabIndex = 4;
            this.textBoxT3.Visible = false;
            this.textBoxT3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxT2
            // 
            this.textBoxT2.Location = new System.Drawing.Point(36, 113);
            this.textBoxT2.Name = "textBoxT2";
            this.textBoxT2.Size = new System.Drawing.Size(357, 21);
            this.textBoxT2.TabIndex = 3;
            this.textBoxT2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxT1
            // 
            this.textBoxT1.Location = new System.Drawing.Point(36, 86);
            this.textBoxT1.Name = "textBoxT1";
            this.textBoxT1.Size = new System.Drawing.Size(356, 21);
            this.textBoxT1.TabIndex = 2;
            this.textBoxT1.Visible = false;
            this.textBoxT1.TextChanged += new System.EventHandler(this.textBox1T1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_graph);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_bmp_save);
            this.panel1.Controls.Add(this.button_excel_save);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(533, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 410);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_graph
            // 
            this.button_graph.Location = new System.Drawing.Point(396, 80);
            this.button_graph.Name = "button_graph";
            this.button_graph.Size = new System.Drawing.Size(114, 60);
            this.button_graph.TabIndex = 10;
            this.button_graph.Text = "그래프보기";
            this.button_graph.UseVisualStyleBackColor = true;
            this.button_graph.Click += new System.EventHandler(this.button_graph_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(392, 362);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(99, 23);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Try Again";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(265, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "총 commit 수 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "총 Loc수 :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(265, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "총 개발기간 :";
            // 
            // button_bmp_save
            // 
            this.button_bmp_save.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_bmp_save.Location = new System.Drawing.Point(175, 360);
            this.button_bmp_save.Name = "button_bmp_save";
            this.button_bmp_save.Size = new System.Drawing.Size(107, 25);
            this.button_bmp_save.TabIndex = 3;
            this.button_bmp_save.Text = "bmp파일저장";
            this.button_bmp_save.UseVisualStyleBackColor = true;
            this.button_bmp_save.Visible = false;
            this.button_bmp_save.Click += new System.EventHandler(this.button_bmp_save_Click);
            // 
            // button_excel_save
            // 
            this.button_excel_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_excel_save.Location = new System.Drawing.Point(45, 360);
            this.button_excel_save.Name = "button_excel_save";
            this.button_excel_save.Size = new System.Drawing.Size(105, 25);
            this.button_excel_save.TabIndex = 2;
            this.button_excel_save.Text = "엑셀파일저장";
            this.button_excel_save.UseVisualStyleBackColor = true;
            this.button_excel_save.Visible = false;
            this.button_excel_save.Click += new System.EventHandler(this.button_excel_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(19, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(491, 183);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(19, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "option";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(272, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "성실도";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(156, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "LoC 수";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "commit 수";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 353);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            this.openFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog4_FileOk);
            // 
            // openFileDialog5
            // 
            this.openFileDialog5.FileName = "openFileDialog5";
            this.openFileDialog5.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog5_FileOk);
            // 
            // openFileDialog6
            // 
            this.openFileDialog6.FileName = "openFileDialog6";
            this.openFileDialog6.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog6_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxSFile;
        private System.Windows.Forms.Button buttonPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonT3;
        private System.Windows.Forms.Button buttonT2;
        private System.Windows.Forms.Button buttonT1;
        private System.Windows.Forms.TextBox textBoxT3;
        private System.Windows.Forms.TextBox textBoxT2;
        private System.Windows.Forms.TextBox textBoxT1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonT5;
        private System.Windows.Forms.RadioButton radioButtonT4;
        private System.Windows.Forms.RadioButton radioButtonT3;
        private System.Windows.Forms.RadioButton radioButtonT2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonT5;
        private System.Windows.Forms.Button buttonT4;
        private System.Windows.Forms.TextBox textBoxT5;
        private System.Windows.Forms.TextBox textBoxT4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.OpenFileDialog openFileDialog5;
        private System.Windows.Forms.OpenFileDialog openFileDialog6;
        private System.Windows.Forms.Button buttonTeam;
        private System.Windows.Forms.Button button_bmp_save;
        private System.Windows.Forms.Button button_excel_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_graph;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;


    }
}

