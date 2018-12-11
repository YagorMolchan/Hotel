using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditRooms f = new EditRooms();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewUsers f = new ViewUsers();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeOfPassword f = new ChangeOfPassword();
            f.ShowDialog();
        }
    }
}
