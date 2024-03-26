using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btb_fh_Click(object sender, EventArgs e)
        {

            convertFromFH();
            
        }

        private void convertFromFH()
        {
            float f = 0;
            try
            {
                f = float.Parse(txt_fh.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers");
            }

            float c = 5f / 9 * (f - 32);
            txt_cl.Text = c.ToString();

            float k = c + 273;
            txt_cl.Text = c.ToString();
            txt_kl.Text = k.ToString();
        }

        private void btn_cl_Click(object sender, EventArgs e)
        {
            convertFromCL();        
        }

        private void convertFromCL()
        {
            float c = 0;
            try
            {
                c = float.Parse(txt_cl.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers");
            }

            float f = (c * (9f / 5) + 32);
            txt_fh.Text = f.ToString();

            float k = c + 273.15f;
            txt_fh.Text = f.ToString();
            txt_kl.Text = k.ToString();
        }

        private void btn_kl_Click(object sender, EventArgs e)
        {
            convertFromKL();
        }

        private void convertFromKL()
        {
            float k = 0;
            try
            {
                k = float.Parse(txt_kl.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers");
            }

            float f = (k - 273.15f) * (9f / 5) + 32;
            txt_fh.Text = f.ToString();

            float c = k - 273.15f;
            txt_cl.Text = c.ToString();
            txt_kl.Text = k.ToString();
        }

        private void onTextChange(object sender, EventArgs e)
        {
            convertFromFH();
        }

        private void onTextChangeCL(object sender, EventArgs e)
        {
            convertFromCL();
        }

    }
}
