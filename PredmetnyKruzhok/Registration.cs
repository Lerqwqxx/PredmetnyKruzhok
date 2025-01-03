using MySql.Data.MySqlClient;
using PredmetnyKruzhok.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredmetnyKruzhok
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string query = "SELECT * FROM users ORDER BY login";
            MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection());

            db.openConnection();

            if (loginTextBox.Text == "" || passwordTextBox.Text == "" || RepeatPasswordTextBox.Text == "")
            {
                errorLabel.Text = "Вы не ввели данные!";
                errorLabel.Visible = true;
            }
            else
            {
                if (passwordTextBox.Text.Length >= 6)
                {
                    bool en = true;
                    bool symbol = false;
                    bool number = false;

                    for (int i = 0; i < passwordTextBox.Text.Length; i++)
                    {
                        if (passwordTextBox.Text[i] >= 'А' && passwordTextBox.Text[i] <= 'Я') en = false;
                        if (passwordTextBox.Text[i] >= '0' && passwordTextBox.Text[i] <= '9') number = true;
                        if (passwordTextBox.Text[i] == '_' || passwordTextBox.Text[i] == '-' || passwordTextBox.Text[i] == '!') symbol = true;
                    }
                    if (!en)
                    {
                        errorLabel.Text = "Доступна только английская раскладка";
                        errorLabel.Visible = true;
                    }
                    else if (!symbol)
                    {
                        errorLabel.Text = "Добавьте один из следующих символов: _, -, !";
                        errorLabel.Visible = true;
                    }
                    else if (!number)
                    {
                        errorLabel.Text = "Добавьте хотя бы одну цифру";
                        errorLabel.Visible = true;
                    }
                    if (en && symbol && number)
                    {
                        if (RepeatPasswordTextBox.Text == passwordTextBox.Text)
                        {
                            try
                            {
                                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                                {
                                    ApplyExecuteResults();

                                }
                            }
                            catch
                            {
                                errorLabel.Text = "Логин занят";
                                errorLabel.Visible = true;
                            }
                        }
                        else
                        {
                            errorLabel.Text = "Пароли не совпадают";
                            errorLabel.Visible = true;
                        }
                    }

                }
                else
                {
                    errorLabel.Text = "Пароль слишком короткий, минимум 6 символов!";
                    errorLabel.Visible = true;
                }
            }
            db.closeConnection();
        }
        private void ApplyExecuteResults()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginTextBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordTextBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!");
                this.Close();
                new Autorization().Show();
            }
            else
            {
                errorLabel.Text = "Ошибка создания аккаунта";
                errorLabel.Visible = true;
            }

            db.closeConnection();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Close();
            new Autorization().Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
