using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserStorage;

namespace ShopClient
{
    public partial class Form1 : Form
    {
        UserService us = new UserService();
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (pressed.Name == "registerButton")
            {
                User existingUser = us.GetUser(rUsernameText.Text);
                if (existingUser != null)
                {
                    newPass.Text = "User bestaat al!";
                }
                newPass.Text = Reverse(rUsernameText.Text);
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
