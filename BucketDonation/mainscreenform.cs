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
            registro re = new registro();
            re.Show();
            this.Visible = false;
        }
    }
}
