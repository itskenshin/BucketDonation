using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BucketDonation
{
    public partial class registro : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public registro()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
          if (textBoxNombre.Text == "")
            {
                labelErrNombre.Visible = true;
            }
          if (textBoxCorreo.Text == "")
            {
                labelErrCorreo.Visible = true;
            }
          if (textBoxTelefono.Text == "")
            {
                labelErrTelefono.Visible = true;
            }

          else
            {   

                MessageBox.Show("Te has registrado correctamente!", "Registrado!", MessageBoxButtons.OK);
                
                MainScreen ms = new MainScreen();
               
                ms.activar();
                ms.Show();
                this.Close();

                

           
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
