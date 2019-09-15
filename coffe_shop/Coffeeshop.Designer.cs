namespace coffe_shop
{
    partial class Coffeeshop

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
            this.displayrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savebutton1 = new System.Windows.Forms.Button();
            this.ordercomboBox1 = new System.Windows.Forms.ComboBox();
            this.quantitytextBox4 = new System.Windows.Forms.TextBox();
            this.addresstextBox3 = new System.Windows.Forms.TextBox();
            this.contacttextBox2 = new System.Windows.Forms.TextBox();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.quantitylabel5 = new System.Windows.Forms.Label();
            this.orderlabel4 = new System.Windows.Forms.Label();
            this.addresslabel3 = new System.Windows.Forms.Label();
            this.contactnolabel2 = new System.Windows.Forms.Label();
            this.customernamelabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayrichTextBox1
            // 
            this.displayrichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayrichTextBox1.Location = new System.Drawing.Point(493, 50);
            this.displayrichTextBox1.Name = "displayrichTextBox1";
            this.displayrichTextBox1.ReadOnly = true;
            this.displayrichTextBox1.Size = new System.Drawing.Size(200, 332);
            this.displayrichTextBox1.TabIndex = 0;
            this.displayrichTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savebutton1);
            this.groupBox1.Controls.Add(this.ordercomboBox1);
            this.groupBox1.Controls.Add(this.quantitytextBox4);
            this.groupBox1.Controls.Add(this.addresstextBox3);
            this.groupBox1.Controls.Add(this.contacttextBox2);
            this.groupBox1.Controls.Add(this.nametextBox1);
            this.groupBox1.Controls.Add(this.quantitylabel5);
            this.groupBox1.Controls.Add(this.orderlabel4);
            this.groupBox1.Controls.Add(this.addresslabel3);
            this.groupBox1.Controls.Add(this.contactnolabel2);
            this.groupBox1.Controls.Add(this.customernamelabel1);
            this.groupBox1.Location = new System.Drawing.Point(64, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // savebutton1
            // 
            this.savebutton1.Location = new System.Drawing.Point(183, 282);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(75, 23);
            this.savebutton1.TabIndex = 10;
            this.savebutton1.Text = "Save";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // ordercomboBox1
            // 
            this.ordercomboBox1.FormattingEnabled = true;
            this.ordercomboBox1.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Regular-80"});
            this.ordercomboBox1.Location = new System.Drawing.Point(183, 188);
            this.ordercomboBox1.Name = "ordercomboBox1";
            this.ordercomboBox1.Size = new System.Drawing.Size(183, 21);
            this.ordercomboBox1.TabIndex = 9;
            // 
            // quantitytextBox4
            // 
            this.quantitytextBox4.Location = new System.Drawing.Point(183, 226);
            this.quantitytextBox4.Name = "quantitytextBox4";
            this.quantitytextBox4.Size = new System.Drawing.Size(183, 20);
            this.quantitytextBox4.TabIndex = 8;
            this.quantitytextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytextBox4_KeyPress);
            // 
            // addresstextBox3
            // 
            this.addresstextBox3.Location = new System.Drawing.Point(183, 138);
            this.addresstextBox3.Name = "addresstextBox3";
            this.addresstextBox3.Size = new System.Drawing.Size(183, 20);
            this.addresstextBox3.TabIndex = 7;
            // 
            // contacttextBox2
            // 
            this.contacttextBox2.Location = new System.Drawing.Point(183, 93);
            this.contacttextBox2.MaxLength = 11;
            this.contacttextBox2.Name = "contacttextBox2";
            this.contacttextBox2.Size = new System.Drawing.Size(183, 20);
            this.contacttextBox2.TabIndex = 6;
            this.contacttextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttextBox2_KeyPress);
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(183, 51);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(183, 20);
            this.nametextBox1.TabIndex = 5;
            // 
            // quantitylabel5
            // 
            this.quantitylabel5.AutoSize = true;
            this.quantitylabel5.Location = new System.Drawing.Point(39, 233);
            this.quantitylabel5.Name = "quantitylabel5";
            this.quantitylabel5.Size = new System.Drawing.Size(46, 13);
            this.quantitylabel5.TabIndex = 4;
            this.quantitylabel5.Text = "Quantity";
            
            // 
            // orderlabel4
            // 
            this.orderlabel4.AutoSize = true;
            this.orderlabel4.Location = new System.Drawing.Point(39, 188);
            this.orderlabel4.Name = "orderlabel4";
            this.orderlabel4.Size = new System.Drawing.Size(33, 13);
            this.orderlabel4.TabIndex = 3;
            this.orderlabel4.Text = "Order";
            
            // 
            // addresslabel3
            // 
            this.addresslabel3.AutoSize = true;
            this.addresslabel3.Location = new System.Drawing.Point(39, 141);
            this.addresslabel3.Name = "addresslabel3";
            this.addresslabel3.Size = new System.Drawing.Size(45, 13);
            this.addresslabel3.TabIndex = 2;
            this.addresslabel3.Text = "Address";
            // 
            // contactnolabel2
            // 
            this.contactnolabel2.AutoSize = true;
            this.contactnolabel2.Location = new System.Drawing.Point(39, 93);
            this.contactnolabel2.Name = "contactnolabel2";
            this.contactnolabel2.Size = new System.Drawing.Size(61, 13);
            this.contactnolabel2.TabIndex = 1;
            this.contactnolabel2.Text = "Contact No";
            // 
            // customernamelabel1
            // 
            this.customernamelabel1.AutoSize = true;
            this.customernamelabel1.Location = new System.Drawing.Point(39, 54);
            this.customernamelabel1.Name = "customernamelabel1";
            this.customernamelabel1.Size = new System.Drawing.Size(82, 13);
            this.customernamelabel1.TabIndex = 0;
            this.customernamelabel1.Text = "Customer Name";
            // 
            // Coffeeshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayrichTextBox1);
            this.Name = "Coffeeshop";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayrichTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ordercomboBox1;
        private System.Windows.Forms.TextBox quantitytextBox4;
        private System.Windows.Forms.TextBox addresstextBox3;
        private System.Windows.Forms.TextBox contacttextBox2;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Label quantitylabel5;
        private System.Windows.Forms.Label orderlabel4;
        private System.Windows.Forms.Label addresslabel3;
        private System.Windows.Forms.Label contactnolabel2;
        private System.Windows.Forms.Label customernamelabel1;
        private System.Windows.Forms.Button savebutton1;
    }
}

