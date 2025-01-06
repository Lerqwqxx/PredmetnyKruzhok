using MySql.Data.MySqlClient;
using PredmetnyKruzhok.Classes;
using System;
using System.Windows.Forms;

namespace PredmetnyKruzhok
{
    public partial class AddUchashchiesya : Form
    {
        private string idUchashchiesya = null;

        public AddUchashchiesya(string id)
        {
            InitializeComponent();
            this.idUchashchiesya = id;

            if (idUchashchiesya != null)
            {
                guna2HtmlLabel1.Text = "Изменить учащегося";
                guna2Button1.Text = "Изменить";
                loadInfoForUchashchiesya();
            }
        }

        // Загрузка информации о выбранном учащемся
        private void loadInfoForUchashchiesya()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM uchashchiesya WHERE kod_uchashchikhsya = '{idUchashchiesya}'";

            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());
            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                guna2TextBox1.Text = reader[1].ToString(); // familya
                guna2TextBox2.Text = reader[2].ToString(); // imya
                guna2TextBox3.Text = reader[3].ToString(); // otchestvo
                dateTimePicker1.Value = Convert.ToDateTime(reader[4]); // data_rozhdeniya
                guna2TextBox5.Text = reader[5].ToString(); // telefon
            }

            reader.Close();
            db.closeConnection();
        }

        // Кнопка для добавления или изменения записи
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command;

            if (idUchashchiesya == null)
            {
                // Добавление новой записи
                command = new MySqlCommand(
                    "INSERT INTO uchashchiesya (familya, imya, otchestvo, data_rozhdeniya, telefon) " +
                    "VALUES (@familya, @imya, @otchestvo, @data_rozhdeniya, @telefon)", db.getConnection());
            }
            else
            {
                // Обновление записи
                command = new MySqlCommand(
                    "UPDATE uchashchiesya SET familya = @familya, imya = @imya, otchestvo = @otchestvo, " +
                    "data_rozhdeniya = @data_rozhdeniya, telefon = @telefon WHERE kod_uchashchikhsya = @id", db.getConnection());
                command.Parameters.AddWithValue("@id", idUchashchiesya);
            }

            command.Parameters.AddWithValue("@familya", guna2TextBox1.Text);
            command.Parameters.AddWithValue("@imya", guna2TextBox2.Text);
            command.Parameters.AddWithValue("@otchestvo", guna2TextBox3.Text);
            command.Parameters.AddWithValue("@data_rozhdeniya", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@telefon", guna2TextBox5.Text);

            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show(idUchashchiesya == null ? "Учащийся добавлен" : "Информация изменена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}