using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Xpense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConsoleOperations.CloseConsole();
        }


       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // has no account
            Form f1 = new CreateAccount();
            f1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //login
            UserData.Username = textBox2.Text;
            if (UserData.Username == "") UserData.Username = "testAccount";
            ConsoleOperations.ShowConsole();
            Form f2 = new Form2();
            f2.Show();
            this.Hide();

            //Console.WriteLine("Button1 Clicked");
            //UserData.AdminAccess = Convert.ToBoolean(textBox2.Text);
            //ConsoleOperations.ShowConsole();
            //LogfileManagement.Read_Logfile();
        }
    }
}
