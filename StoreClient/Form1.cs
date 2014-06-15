using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreClient
{
    public partial class Form1 : Form
    {
        List<Product> producten = new List<Product>();
        List<Product> inventory = new List<Product>();
        User user;
        public Form1()
        {
            InitializeComponent();
            user = this.GetUser();
            this.GetProducten();
            this.GetInventory();
        }
        public void GetProducten()
        {
            //leeghalen
            producten.Clear();
            Products.Items.Clear();

            //Get alle producten van de DB
            producten.Add(new Product(1, "Appel", 5.6, 5));
            producten.Add(new Product(2, "Banaan", 1, 2));
            foreach (Product p in producten)
            {
                Products.Items.Add(p);     
            }
        }
        public void GetInventory()
        {
            //Order gebruiken ipv producten!!

            //leeghalen
            inventory.Clear();
            Inventory.Items.Clear();
            //Get alle producten van desbetreffende klant in DB
            inventory.Add(new Product(1, "Peer", 3, 1));
            foreach (Product p in inventory)
            {
                Inventory.Items.Add(p.name + ": " + p.amount);
            }
        }
        public User GetUser()
        {
            //Get user uit DB
            cashAmount.Text = "500";
            return new User(1, "Samme", "Emmas", 500);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (pressed.Text == "Refresh")
            {
                this.GetProducten();
                this.GetInventory();
            }
            else if (pressed.Text == "Buy")
            {
                // Check of voldoende geld
                Product currentItem = (Product)Products.SelectedItem;
                if (user.cashAmount >= currentItem.price)
                {
                    if (this.BuyProduct(currentItem))
                    {
                        // Haal geld weg van cashAmount
                        user.cashAmount -= currentItem.price;
                    }
                }       
            }
        }
        public bool BuyProduct(Product currentItem)
        {
            Debug.WriteLine(currentItem.id);
            foreach (Product p in producten)
            {
                if (p.id.Equals(currentItem.id))
                {
                    if (p.amount >= 2)
                    {
                        errorMessage.Visible = false;
                        p.amount -= 1;
                        inventory.Add(currentItem);
                    }
                    else if (p.amount == 1)
                    {
                        errorMessage.Visible = false;
                        producten.Remove(p);
                        inventory.Add(currentItem);
                        break;
                    }
                    else
                    {
                        errorMessage.Visible = true;
                        return false;
                    }
                } 
            }
            Products.Items.Clear();
            foreach (Product p in producten)
            {
                Products.Items.Add(p);
            }
            //Order gebruiken ipv producten!!
            Inventory.Items.Clear();
            foreach (Product p in inventory)
            {
                Inventory.Items.Add(p.name + ": " + p.amount);
            }
            return true;
        }
    }
}
