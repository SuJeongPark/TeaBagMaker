using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] tList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };

        int CountOrgNum = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<tList.Length;i++)
            {
                this.teaList.Items.Add(tList[i]);
            }
            if(teaList.Items.Count >0)
            {
                this.teaList.SelectedIndex = 0;
            }
            this.LabResult.Text = "";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (teaList.Text == "홍차")
                CountOrgNum = 60*2;
            else if (teaList.Text == "녹차")
                CountOrgNum = 60*3;
            else if (teaList.Text == "루이보스차")
                CountOrgNum = 60*5;
            else if (teaList.Text == "국화차")
                CountOrgNum = 60*2;

            this.Timer.Enabled = true;
        }

        private void TeaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.LabResult.Text = "";
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.teaList.Focus();
            }
            else
            {
                CountOrgNum--;
                int min = CountOrgNum/60;
                int sec = CountOrgNum % 60;
                this.LabResult.Text = Convert.ToString(min) + "분 " + Convert.ToString(sec) + "초 남았습니다!";
            }
        }
    }
}
