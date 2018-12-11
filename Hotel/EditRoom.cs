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
    public partial class EditRoom : Form
    {
        public EditRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(textBox2.Text)<50 && Int32.Parse(TextBox2.Text)<100)
            {
                MessageBox.Show("Значение цены должно быть от 50 до 100", "Сообщение об ошибке!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (HotelEntities entities = new HotelEntities())
                {
                    foreach(Room r in entities.Rooms)
                    {
                        if(r.Number==Int32.Parse(textBox1.Text))
                        {
                            r.Price = Single.Parse(textBox2.Text);
                            r.CountOfPlaces = Int32.Parse(textBox3.Text);
                            r.CountOfPartRooms = Int32.Parse(TextBox5.Text);
                            r.Description = textBox4.Text;
                            r.Statut = comboBox2.SelectedText;
                            break;
                        }
                    }
                    entities.SaveChanges();
                    MessageBox.Show("Редактирование данных завршено успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public System.Windows.Forms.TextBox TextBox1 { get { return this.textBox1; } }
        public System.Windows.Forms.TextBox TextBox2 { get { return this.textBox2; } }
        public System.Windows.Forms.TextBox TextBox3 { get { return this.textBox3; } }
        public System.Windows.Forms.TextBox TextBox4 { get { return this.textBox4; } }
        public System.Windows.Forms.TextBox TextBox5 { get { return this.textBox5; } }
        public System.Windows.Forms.ComboBox ComboBox2 { get { return this.comboBox2; } }
        


        private void EditRoom_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            
        }
    }
}
