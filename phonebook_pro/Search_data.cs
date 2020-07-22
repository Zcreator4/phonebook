using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebook_pro
{
    public partial class Search_data : Form
    {
        public Search_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox9.Text == "")
            {
                MessageBox.Show("You must enter an ID number.");
                return;
            }

            string fn;
            fn = "C:\\Users\\Zander\\Desktop\\Phonebook\\";
            string p;
            string r;

            //First Name
            p = fn + this.textBox9.Text + "_fn.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.textBox7.Text = r;
            }
            //Last Name
            p = fn + this.textBox9.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.textBox5.Text = r;
            }
            //Tele
            p = fn + this.textBox9.Text + "_tele.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.textBox6.Text = r;
            }
            //Cell
            p = fn + this.textBox9.Text + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.textBox2.Text = r;
            }
            //Email
            p = fn + this.textBox9.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.textBox3.Text = r;
            }
            //Adress
            p = fn + this.textBox9.Text + "_adress.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.textBox4.Text = r;
            }
            //Comment
            p = fn + this.textBox9.Text + "_comment.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.textBox8.Text = r;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
