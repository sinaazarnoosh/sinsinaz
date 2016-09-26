using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class Change_Password : Infrastructure.BaseForm
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CancleButton(object sender, EventArgs e)
        {
            Hide();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            Showusernamelabel.Text = Infrastructure.Utility.Authentication.Username;
        }

        private void Showusernamelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
