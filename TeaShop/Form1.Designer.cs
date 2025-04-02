namespace TeaShop
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
            this.gb_Menu = new System.Windows.Forms.GroupBox();
            this.gb_Orders = new System.Windows.Forms.GroupBox();
            this.gb_Customer = new System.Windows.Forms.GroupBox();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.bt_Add_customer = new System.Windows.Forms.Button();
            this.gb_Menu.SuspendLayout();
            this.gb_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Menu
            // 
            this.gb_Menu.BackColor = System.Drawing.Color.LightBlue;
            this.gb_Menu.Controls.Add(this.label6);
            this.gb_Menu.Controls.Add(this.tb_Quantity);
            this.gb_Menu.Controls.Add(this.label5);
            this.gb_Menu.Controls.Add(this.label4);
            this.gb_Menu.Controls.Add(this.textBox1);
            this.gb_Menu.Controls.Add(this.cb_item);
            this.gb_Menu.Location = new System.Drawing.Point(12, 12);
            this.gb_Menu.Name = "gb_Menu";
            this.gb_Menu.Size = new System.Drawing.Size(906, 512);
            this.gb_Menu.TabIndex = 0;
            this.gb_Menu.TabStop = false;
            this.gb_Menu.Text = "Menu";
            // 
            // gb_Orders
            // 
            this.gb_Orders.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gb_Orders.Location = new System.Drawing.Point(975, 12);
            this.gb_Orders.Name = "gb_Orders";
            this.gb_Orders.Size = new System.Drawing.Size(832, 1089);
            this.gb_Orders.TabIndex = 1;
            this.gb_Orders.TabStop = false;
            this.gb_Orders.Text = "Order";
            // 
            // gb_Customer
            // 
            this.gb_Customer.BackColor = System.Drawing.Color.Thistle;
            this.gb_Customer.Controls.Add(this.bt_Add_customer);
            this.gb_Customer.Controls.Add(this.bt_Save);
            this.gb_Customer.Controls.Add(this.label3);
            this.gb_Customer.Controls.Add(this.tb_address);
            this.gb_Customer.Controls.Add(this.label2);
            this.gb_Customer.Controls.Add(this.tb_phone);
            this.gb_Customer.Controls.Add(this.label1);
            this.gb_Customer.Controls.Add(this.tb_name);
            this.gb_Customer.Location = new System.Drawing.Point(12, 564);
            this.gb_Customer.Name = "gb_Customer";
            this.gb_Customer.Size = new System.Drawing.Size(906, 537);
            this.gb_Customer.TabIndex = 2;
            this.gb_Customer.TabStop = false;
            this.gb_Customer.Text = "Customer";
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(128, 96);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(458, 39);
            this.cb_item.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 38);
            this.textBox1.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(39, 112);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(384, 38);
            this.tb_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(39, 228);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(384, 38);
            this.tb_phone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(39, 359);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(384, 38);
            this.tb_address.TabIndex = 4;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(693, 287);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(189, 56);
            this.bt_Save.TabIndex = 6;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Location = new System.Drawing.Point(128, 357);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(334, 38);
            this.tb_Quantity.TabIndex = 4;
            // 
            // bt_Add_customer
            // 
            this.bt_Add_customer.Location = new System.Drawing.Point(693, 150);
            this.bt_Add_customer.Name = "bt_Add_customer";
            this.bt_Add_customer.Size = new System.Drawing.Size(189, 53);
            this.bt_Add_customer.TabIndex = 7;
            this.bt_Add_customer.Text = "Add";
            this.bt_Add_customer.UseVisualStyleBackColor = true;
            this.bt_Add_customer.Click += new System.EventHandler(this.bt_Add_customer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1839, 1113);
            this.Controls.Add(this.gb_Customer);
            this.Controls.Add(this.gb_Orders);
            this.Controls.Add(this.gb_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Menu.ResumeLayout(false);
            this.gb_Menu.PerformLayout();
            this.gb_Customer.ResumeLayout(false);
            this.gb_Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Menu;
        private System.Windows.Forms.GroupBox gb_Orders;
        private System.Windows.Forms.GroupBox gb_Customer;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Add_customer;
    }
}

