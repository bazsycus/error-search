using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hibakezeles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iSzam1, iSzam2;
           

            if (int.TryParse(textBox1.Text, out iSzam1)&& int.TryParse(textBox2.Text, out iSzam2))
            {
                label1.Text = (iSzam1 / iSzam2).ToString();
            } else
            {
                MessageBox.Show("Az ön által megadott bemenet hibás!", "Hiba történt", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iSzam1, iSzam2;
            try
            {
                iSzam1 = int.Parse(textBox1.Text);
                iSzam2 = int.Parse(textBox2.Text);
                label1.Text = (iSzam1 / iSzam2).ToString();
            }
            catch (Exception Ex)
            {
                label1.Text = Ex.Message;
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text="";
            }
            
        }
    }
}
