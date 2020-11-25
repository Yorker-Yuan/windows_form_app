using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Advertisment
{
    public partial class UC_Advertisment : UserControl
    {
        public UC_Advertisment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Add_Source ads = new Add_Source())
            {
                ads.ShowDialog();
            }
        }
    }
}
