using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebook_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Register_data rg = new Register_data();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Search_data sd = new Search_data();
            sd.MdiParent = this;
            sd.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            About_us au = new About_us();
            au.MdiParent = this;
            au.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Users\\Zander\\source\\repos\\calc_pro_ns\\calc_pro\\bin\\Debug\\calc_pro.exe";
            process1.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                this.toolStripButton5_Click(sender, e);
            }
            if (e.KeyCode == Keys.F6)
            {
                this.toolStripButton4_Click(sender, e);
            }
            if (e.KeyCode == Keys.F7)
            {
                this.toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F8)
            {
                this.toolStripButton3_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.toolStripButton1_Click(sender, e);
            }
        }
    }
}
