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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            List<string[]> roomList = new List<string[]>();


            using (HotelEntities entities = new HotelEntities())
            {

                foreach (Room room in entities.Rooms)
                {
                    roomList.Add(new string[7]);
                    roomList[roomList.Count - 1][0] = room.Id.ToString();
                    roomList[roomList.Count - 1][1] = room.Category.ToString();
                    roomList[roomList.Count - 1][2] = room.Price.ToString();                    
                    richTextBox1.Text = room.Description;
                }
            }

            foreach (string[] s in roomList)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
