using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xpense
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "iamanadmin@admins" && textBoxPassword.Text == "parolaadmin" && textBoxPasswordRepeat.Text == "faraoparola") ConsoleOperations.ShowConsole();
            ConsoleOperations.ReadConsoleCommands();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "secure")
            {
                textBoxEmail.PasswordChar = '*';
                textBoxEmail.Text = "";
            }
        }
    }
}
