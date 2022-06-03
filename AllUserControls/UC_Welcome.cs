using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lblBanner.Location = new Point(4, 327);
                lblBanner.ForeColor = Color.Orange;
                num++;

            }
            else if(num == 1)
            {
                lblBanner.Location = new Point(136, 327);
                lblBanner.ForeColor = Color.Green;
                num++;
            }
            else if(num == 2)
            {
                lblBanner.Location = new Point(240, 327);
                lblBanner.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
