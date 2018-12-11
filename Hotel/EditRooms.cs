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
    public partial class EditRooms : Form
    {
        private List<string[]> roomList;
        public EditRooms()
        {
            InitializeComponent();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            EditRoom form = new EditRoom();
            form.TextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.TextBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.TextBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.TextBox4.Text = richTextBox1.Text;
            form.TextBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            form.ShowDialog();

        }

        private void EditRooms_Load(object sender, EventArgs e)
        {
            roomList = new List<string[]>();
            SortedSet<string> setDescriptions = new SortedSet<string>();

            using (HotelEntities entities = new HotelEntities())
            {

                foreach (Room room in entities.Rooms)
                {
                    roomList.Add(new string[7]);
                    roomList[roomList.Count - 1][0] = room.Id.ToString();
                    roomList[roomList.Count - 1][1] = room.Category.ToString();
                    roomList[roomList.Count - 1][2] = room.Number.ToString();
                    roomList[roomList.Count - 1][3] = room.Price.ToString();
                    //roomList[roomList.Count - 1][0] = room.Id.ToString();
                    //roomList[roomList.Count - 1][1] = room.Category;
                    //roomList[roomList.Count - 1][2] = room.Number.ToString();
                    //roomList[roomList.Count - 1][3] = room.Price.ToString();
                    roomList[roomList.Count - 1][4] = room.CountOfPlaces.ToString();
                    roomList[roomList.Count - 1][5] = room.CountOfPartRooms.ToString();
                    roomList[roomList.Count - 1][6] = room.Statut.ToString();
                    setDescriptions.Add(room.Description);
                }
            }


            List<string> prescriptions = new List<string>();

            foreach (string[] s in roomList)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormForNewRoom f = new FormForNewRoom();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].ToString();
            string c = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            using (HotelEntities entities = new HotelEntities())
            {
                foreach (Room room in entities.Rooms)
                {
                    if (room.Id.ToString() == c)
                    {
                        richTextBox1.Text = room.Description.ToString();                        
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            using (HotelEntities entities = new HotelEntities())
            {
                foreach(Room r in entities.Rooms)
                {
                    if(r.Id.ToString()==c)
                    {
                        MessageBox.Show("Вы действительно хотите удалить эту путевку?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        entities.Rooms.Remove(r);
                        break;
                    }
                }
                entities.SaveChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditRooms.ActiveForm.Close();
        }
    }
}
