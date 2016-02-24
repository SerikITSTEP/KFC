using KFC.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class MainForm : Form
    {
        User user = null;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            switch (user.role_id)
            {
                case "admin":
                        adminTSMI.Enabled = true;
                        reportTSMI.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        private void userEditTSMI_Click(object sender, EventArgs e)
        {
            UserEdit ue = new UserEdit();
            ue.MdiParent = this;
            ue.Show();
        }
        private void приходToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void reportTSMI_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.MdiParent = this;
            r.Show();
        }
    }
}
