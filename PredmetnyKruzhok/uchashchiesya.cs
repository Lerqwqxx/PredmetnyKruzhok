using MySql.Data.MySqlClient;
using PredmetnyKruzhok.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PredmetnyKruzhok
{
    public partial class Uchashchiesya : Form
    {
        private string IdUchashchiesya;

        public Uchashchiesya(string id)
        {
            InitializeComponent();
            IdUchashchiesya = id;
        }

        // Загрузка данных из таблицы
        private void loadInfoForUchashchiesya()
        {
            DB db = new DB();
            dataGridView1.Rows.Clear();

            string query = "SELECT * FROM uchashchiesya";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                List<string[]> dataDB = new List<string[]>();

                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }

                reader.Close();
                foreach (string[] s in dataDB)
                    dataGridView1.Rows.Add(s);
            }

            db.closeConnection();
        }

        // Кнопка для возврата в меню
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        // Кнопка для добавления нового учащегося
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddUchashchiesya ad = new AddUchashchiesya(null);
            ad.Show();
        }

        // Кнопка для редактирования выбранного учащегося
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddUchashchiesya ad = new AddUchashchiesya(dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value.ToString());
            ad.Show();
        }

        // Кнопка для удаления выбранного учащегося
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"DELETE FROM uchashchiesya WHERE kod_uchashchikhsya = {dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Учащийся удален");
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoForUchashchiesya();
        }

        // Кнопка для обновления списка учащихся
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            loadInfoForUchashchiesya();
        }
    }
}