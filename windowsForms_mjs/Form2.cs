using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace windowsForms_mjs
{
    public partial class Form2 : Form 
    {
        // 폼 간 데이터 전달

        public Form2()
        {
            InitializeComponent();
            // chart 리셋
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();

        }
        //private Form1 otherForm;
        public void Form2_Load(object sender, EventArgs e)
        {
            // form의 owner속성 이용
            // modifiers 속성을 public으로 해줘야함
            Form1 form1 = (Form1)this.Owner;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
        
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
}
