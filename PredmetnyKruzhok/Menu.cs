using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace PredmetnyKruzhok
{
    public partial class Menu : Form
    {
        private object id;
        public static string idInfo = null;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(object id)
        {
            this.id = id;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Uchashchiesya(idInfo).Show();
        }
    }
}
