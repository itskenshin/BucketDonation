using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BucketDonation
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (checktoys.Checked == false && checkblood.Checked == false && checkfood.Checked == false && checkmoney.Checked == false && clothcheck.Checked == false)
            {
                MessageBox.Show("Por favor seleccione su donacion.");
            }
            
            else
            {
                registro re = new registro();
                re.Show();
                
            }
            
            
        }

        public void activar()
        {
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
        }

        private void label_donadoresrecientes_Click(object sender, EventArgs e)
        {

        }

        private void tipo_donacion_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
