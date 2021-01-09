using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Factory
{
    public partial class Form3 : Form
    {
        public delegate void FormSendDataHandler(string sendstring);
        public event FormSendDataHandler FormSendEvent;
        private string selected = "";
        private string num = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected != "")
            {
                num = M_K1.Text;
                if (num != "")
                {
                    this.FormSendEvent($"{selected}/{num}");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("제작할 제품 선택","error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RK1_CheckedChanged(object sender, EventArgs e)
        {
            selected = RK1.Text;
        }

        private void RR1_CheckedChanged(object sender, EventArgs e)
        {
            selected = RR1.Text;
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            selected = RB1.Text;
        }

        private void RC2_CheckedChanged(object sender, EventArgs e)
        {
            selected = RC2.Text;
        }

        private void RC3_CheckedChanged(object sender, EventArgs e)
        {
            selected = RC3.Text;
        }
    }
}
