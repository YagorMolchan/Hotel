using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class FormForNewRoom : Form
    {
        private bool statut;

        public FormForNewRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (comboBox1.SelectedText == "Апартаменты")
            //{
            //    label6.Visible = true;
            //    textBox5.Visible = true;
            //}
            if (Double.Parse(textBox2.Text) <= 0)
            {
                MessageBox.Show("Значение цены номера должно быть больше 0!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Int32.Parse(textBox1.Text) <= 0)
            {
                MessageBox.Show("Значение номера должно быть больше 0!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Int32.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Значение количества мест должно быть больше 0!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                

                if (Int32.Parse(textBox5.Text) <= 0)
                {
                    MessageBox.Show("Значение количества комнат должно быть больше 0!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Room room = new Room
                {
                    Category = comboBox1.SelectedText,
                    Number = Int32.Parse(textBox1.Text),
                    Price = Single.Parse(textBox2.Text),
                    CountOfPlaces = Int32.Parse(textBox3.Text),
                    Description = textBox4.Text,
                    CountOfPartRooms = Int32.Parse(textBox5.Text),
                    Statut = comboBox2.SelectedText,
                };

                HotelEntities h = new HotelEntities();
                h.Rooms.Add(room);
                h.SaveChanges();
                //string connectionString = "Data Source=COMPUTER\\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(connectionString);
                //sqlConnection.Open();
                //SqlCommand sqlCommand = new SqlCommand("Insert into Rooms[Category,Number,Price,CountOfPlaces,Description,CountOfPartRooms,Statut] VALUES (@category,@number,@price,@countOfPlaces,@description,@countOfPartOfRooms,@statut)");
                //sqlCommand.Parameters.AddWithValue("Category", room.Category);
                //sqlCommand.Parameters.AddWithValue("Number", room.Number);
                //sqlCommand.Parameters.AddWithValue("Price", room.Price);
                //sqlCommand.Parameters.AddWithValue("CountOfPlaces", room.CountOfPlaces);
                //sqlCommand.Parameters.AddWithValue("Description", room.Description);
                //sqlCommand.Parameters.AddWithValue("CountOfPartRooms", room.CountOfPartRooms);
                //sqlCommand.Parameters.AddWithValue("Statut", room.Statut);
                //sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Информация о номере успешно добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void FormForNewRoom_Load(object sender, EventArgs e)
        {
            //label6.Visible = false;
            //textBox5.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //    statut = true;
            //else statut = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
