using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Exam_Section
{
    public partial class UC_NewPaper : UserControl
    {
        public UC_NewPaper()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Add_Test at = new Add_Test())
            {
                at.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Add_Result adr = new Add_Result())
            {
                adr.ShowDialog();
            }
        }
    }
}
