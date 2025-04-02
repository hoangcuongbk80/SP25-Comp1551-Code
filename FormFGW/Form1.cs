using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFGW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += tb_name.Text + "    " + tb_id.Text + "    " + cb_level.Text + "\n";
        }

        private void cb_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_level.SelectedIndex == 0)
            {
                tb_name.Text = "10000";
            }
            if (cb_level.SelectedIndex == 1)
            {
                tb_name.Text = "20000";
            }
            if (cb_level.SelectedIndex == 2)
            {
                tb_name.Text = "30000";
            }
            if (cb_level.SelectedIndex == 3)
            {
                tb_name.Text = "50000";
            }
        }
    }
}
