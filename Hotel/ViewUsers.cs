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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            List<string[]> data = new List<string[]>();
            using (HotelEntities entities = new HotelEntities())
            {
                foreach(User u in entities.Users)
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = u.Id.ToString();
                    data[data.Count - 1][1] = u.Firstname.ToString();
                    data[data.Count - 1][2] = u.Lastname.ToString();
                    data[data.Count - 1][3] = u.Phone.ToString();
                    data[data.Count - 1][4] = u.Passport.ToString();                    
                }
            }

            foreach(string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}
