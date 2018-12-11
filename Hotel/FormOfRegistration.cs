﻿using System;
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
    public partial class FormOfRegistration : Form
    {
        public FormOfRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Фамилия должна быть обязательно заполнена!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Имя должно быть обязательно заполнено!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(textBox3.Text.Length<3)
            {
                MessageBox.Show("Малое значение длины телефона!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Телефолн должен быть обязательно заполнен!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (textBox4.Text == "")
            {
                MessageBox.Show("Имя пользователя должно быть обязательно заполнено!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Пароль должен быть обязательно заполнен!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Пароль должен быть обязательно подтвержден!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Не соотвествуют пароли!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("Паспортные данные должны быть обязательно заполнены!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Почта должна быть обязательно заполнена!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User
                {
                    //Id = Int32.Parse(textBox9.Text),
                    Lastname = textBox1.Text,
                    Firstname = textBox2.Text,
                    Phone = textBox3.Text,
                    E_mail = textBox8.Text,
                    Passport = textBox7.Text,
                    Username = textBox4.Text,
                    Password = textBox6.Text
                };


                //string connectionString = "Data Source=COMPUTER\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(connectionString);
                //sqlConnection.Open();
                //SqlCommand sqlCommand = new SqlCommand("INSERT INTO Users (Id,Lastname,Firstname,Phone,[E-mail],Passport,Username,Password) VALUES (@id,@lName,@fName,@phone,@e_mail,@passport,@username,@password)", sqlConnection);
                //sqlCommand.Parameters.AddWithValue("id", user.Id);
                //sqlCommand.Parameters.AddWithValue("lName", user.Lastname);
                //sqlCommand.Parameters.AddWithValue("fName", user.Firstname);
                //sqlCommand.Parameters.AddWithValue("phone", user.Phone);
                //sqlCommand.Parameters.AddWithValue("e_mail", user.E_mail);
                //sqlCommand.Parameters.AddWithValue("passport", user.Passport);
                //sqlCommand.Parameters.AddWithValue("username", user.Username);
                //sqlCommand.Parameters.AddWithValue("password", user.Password);
                //sqlCommand.ExecuteNonQuery();


                using (HotelEntities entities = new HotelEntities())
                {
                    entities.Users.Add(user);
                    entities.SaveChanges();
                }

                MessageBox.Show("Регистрация завершена успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOfRegistration_Load(object sender, EventArgs e)
        {
            //label9.Visible = false;
            //textBox9.Visible = false;
        }
    }
}
