using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreClient;
namespace ShopClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            //User selecteert Register button
            if (pressed.Name == "registerButton")
            {
                //Naam controleren in DB of al bestaat: 
                if(true) {
                    newPass.ForeColor = System.Drawing.Color.Black;
                    newPass.Text = Reverse(rUsernameText.Text);
                    //Nieuwe user aanmaken in DB

                }
                //Anders:
                else
                {
                    newPass.Text = "This user already exists.";
                    newPass.ForeColor = System.Drawing.Color.Red;
                }
            }
            //User selecteert Login button
            if (pressed.Name == "loginButton")
            {
                //Controleren of user bestaat in DB, zo ja: inloggen
                if (lUsernameText.Text.Equals("Samme") && lPasswordText.Text.Equals("Emmas"))
                {
                    StoreClient.Form1 form = new StoreClient.Form1();

                    // Exit sluit beide, fix voor nodig: Application.Exit();
                    form.Show();        
                }
                else
                {
                    //Invalid credentials error
                    lErrorMessage.Visible = true;
                }
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
