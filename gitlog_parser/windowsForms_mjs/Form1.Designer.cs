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
            this.textBoxSFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.tabPage1.Controls.Add(this.textBoxSFile);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "개인별";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "분석시작";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
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
            // buttonT5
            // 
            this.buttonT5.Location = new System.Drawing.Point(405, 244);
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
            this.buttonT4.Location = new System.Drawing.Point(405, 205);
            this.buttonT4.Name = "buttonT4";
            this.buttonT4.Size = new System.Drawing.Size(75, 23);
            this.buttonT4.TabIndex = 11;
            this.buttonT4.Text = "불러오기";
            this.buttonT4.UseVisualStyleBackColor = true;
            this.buttonT4.Click += new System.EventHandler(this.buttonT4_Click);
            // 
            // textBoxT5
            // 
            this.textBoxT5.Location = new System.Drawing.Point(37, 247);
            this.textBoxT5.Name = "textBoxT5";
            this.textBoxT5.Size = new System.Drawing.Size(354, 21);
            this.textBoxT5.TabIndex = 10;
            this.textBoxT5.Visible = false;
            this.textBoxT5.TextChanged += new System.EventHandler(this.textBoxT5_TextChanged);
            // 
            // textBoxT4
            // 
            this.textBoxT4.Location = new System.Drawing.Point(37, 208);
            this.textBoxT4.Name = "textBoxT4";
            this.textBoxT4.Size = new System.Drawing.Size(355, 21);
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
            this.buttonT3.Location = new System.Drawing.Point(403, 169);
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
            this.buttonT2.Location = new System.Drawing.Point(405, 129);
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
            this.textBoxT3.Location = new System.Drawing.Point(36, 167);
            this.textBoxT3.Name = "textBoxT3";
            this.textBoxT3.Size = new System.Drawing.Size(355, 21);
            this.textBoxT3.TabIndex = 4;
            this.textBoxT3.Visible = false;
            this.textBoxT3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxT2
            // 
            this.textBoxT2.Location = new System.Drawing.Point(35, 129);
            this.textBoxT2.Name = "textBoxT2";
            this.textBoxT2.Size = new System.Drawing.Size(356, 21);
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
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 310);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(491, 214);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(7, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "option";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(364, 43);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(86, 16);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(364, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(86, 16);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(26, 43);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 16);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(184, 42);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 16);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(184, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 16);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(26, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(521, 327);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxSFile;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
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


    }
}

