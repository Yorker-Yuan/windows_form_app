using HRMS.Advertisment;
using HRMS.Applicant;
using HRMS.Employee;
using HRMS.Exam_Section;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void movesidepanel(Button btn)
        {
            plSlide.Top = btn.Top;
            plSlide.Height = btn.Height;
        }

        private void addUserControl(Control uc)
        {
            plCenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            plCenter.Controls.Clear();
            plCenter.Controls.Add(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movesidepanel(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movesidepanel(button4);
            UC_Advertisment ads = new UC_Advertisment();
            addUserControl(ads);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            movesidepanel(button5);
            UC_Applicant uca = new UC_Applicant();
            addUserControl(uca);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            movesidepanel(button6);
            UC_NewPaper ucn = new UC_NewPaper();
            addUserControl(ucn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            movesidepanel(button7);
            UC_Employee uce = new UC_Employee();
            addUserControl(uce);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            movesidepanel(button8);
            UC_Setting us = new UC_Setting();
            addUserControl(us);

        }
    }
}
