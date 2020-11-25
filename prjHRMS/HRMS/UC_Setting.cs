using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class UC_Setting : UserControl
    {
        public UC_Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Branch br = new Branch())
            {
                br.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Personal_DEsignation pd = new Personal_DEsignation())
            {
                pd.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Category ca = new Category())
            {
                ca.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Functional_DEsignation fd = new Functional_DEsignation())
            {
                fd.ShowDialog();
            }    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
