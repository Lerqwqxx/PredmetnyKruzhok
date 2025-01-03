using MySql.Data.MySqlClient;
using PredmetnyKruzhok.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace PredmetnyKruzhok
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string loginUser = loginTextBox.Text;
            string passUser = passwordTextBox.Text;



            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string queryAccount = $"SELECT id FROM users WHERE login = '{loginUser}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryAccount, db.getConnection());
                Menu apppage = new Menu();

                db.openConnection();

                Menu.idInfo = mySqlCommand.ExecuteScalar().ToString();

                db.closeConnection();

                errorText.Text = "Добро пожаловать ";
                errorText.Visible = true;

                this.Hide();
                apppage.Show();
            }
            else
            {
                errorText.Text = "Неправильный логин или пароль";
                errorText.Visible = true;
            }
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = passwordTextBox.PasswordChar == '*' ? '\0' : '*';
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
