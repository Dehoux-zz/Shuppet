namespace StoreClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.cashAmount = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.ListBox();
            this.Products = new System.Windows.Forms.ListBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(34, 202);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(68, 13);
            this.moneyLabel.TabIndex = 4;
            this.moneyLabel.Text = "Money left: €";
            // 
            // cashAmount
            // 
            this.cashAmount.AutoSize = true;
            this.cashAmount.Location = new System.Drawing.Point(95, 203);
            this.cashAmount.Name = "cashAmount";
            this.cashAmount.Size = new System.Drawing.Size(0, 13);
            this.cashAmount.TabIndex = 5;
            // 
            // Inventory
            // 
            this.Inventory.FormattingEnabled = true;
            this.Inventory.Location = new System.Drawing.Point(37, 54);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(219, 134);
            this.Inventory.TabIndex = 6;
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(391, 54);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(208, 134);
            this.Products.TabIndex = 7;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(388, 191);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(67, 13);
            this.errorMessage.TabIndex = 8;
            this.errorMessage.Text = "Not in stock.";
            this.errorMessage.UseWaitCursor = true;
            this.errorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(625, 265);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.cashAmount);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label cashAmount;
        private System.Windows.Forms.ListBox Inventory;
        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.Label errorMessage;
    }
}

