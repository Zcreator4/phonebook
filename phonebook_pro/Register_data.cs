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
    public partial class Register_data : Form
    {
        public Register_data()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.toolStripButton2.Enabled = false;
            this.toolStripButton1.Enabled = true;
            this.groupBox1.Enabled = true;

            //------Clear Text------

            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            this.textBox8.ResetText();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter an ID number.");
                return;
            }
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = true;
            this.groupBox1.Enabled = false;

            //------id-------
            string fn;
            fn = "C:\\Users\\Zander\\Desktop\\Phonebook\\";
            string p;
            p = fn + this.textBox1.Text + "_id.txt";
            System.IO.File.WriteAllText(p, this.textBox1.Text, Encoding.UTF8);
            //First name
            p = fn + this.textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.textBox7.Text, Encoding.UTF8);
            //last name
            p = fn + this.textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.textBox5.Text, Encoding.UTF8);
            //Tele
            p = fn + this.textBox1.Text + "_tele.txt";
            System.IO.File.WriteAllText(p, this.textBox6.Text, Encoding.UTF8);
            //Cell
            p = fn + this.textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.textBox2.Text, Encoding.UTF8);
            //email
            p = fn + this.textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.textBox3.Text, Encoding.UTF8);
            //address
            p = fn + this.textBox1.Text + "_adress.txt";
            System.IO.File.WriteAllText(p, this.textBox4.Text, Encoding.UTF8);
            //comment
            p = fn + this.textBox1.Text + "_comment.txt";
            System.IO.File.WriteAllText(p, this.textBox8.Text, Encoding.UTF8);

            MessageBox.Show("Saved!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Register_data_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
        }
    }
}
