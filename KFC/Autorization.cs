using KFC.DATA;
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
    public partial class Autorization : Form
    {
        KFCDbContext context = new KFCDbContext();
        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(s => (string.Compare(s.login, tbLogin.Text) == 0) && s.password == tbPass.Text);
            if (user != null)
            {
                MainForm ad = new MainForm(user);
                this.Hide();
                ad.Show();
            }
            else
                MessageBox.Show("Логин или пароль неверный", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
