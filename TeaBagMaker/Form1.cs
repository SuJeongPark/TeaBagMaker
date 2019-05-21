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
        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }

        private void TeaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.teaList.Text != "")
            {
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
