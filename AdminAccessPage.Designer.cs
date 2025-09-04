namespace Perfume_Store
{
    partial class AdminAccessPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccessPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radBrands = new System.Windows.Forms.RadioButton();
            this.radPerfumes = new System.Windows.Forms.RadioButton();
            this.radCustomers = new System.Windows.Forms.RadioButton();
            this.radSales = new System.Windows.Forms.RadioButton();
            this.radSale_Items = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radOrders = new System.Windows.Forms.RadioButton();
            this.radOrderItems = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASTER_PERFUME-ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(67, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Tables";
            // 
            // radBrands
            // 
            this.radBrands.AutoSize = true;
            this.radBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radBrands.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBrands.ForeColor = System.Drawing.Color.Black;
            this.radBrands.Location = new System.Drawing.Point(72, 133);
            this.radBrands.Name = "radBrands";
            this.radBrands.Size = new System.Drawing.Size(95, 26);
            this.radBrands.TabIndex = 2;
            this.radBrands.TabStop = true;
            this.radBrands.Text = "Brands";
            this.radBrands.UseVisualStyleBackColor = false;
            this.radBrands.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radPerfumes
            // 
            this.radPerfumes.AutoSize = true;
            this.radPerfumes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radPerfumes.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPerfumes.Location = new System.Drawing.Point(72, 177);
            this.radPerfumes.Name = "radPerfumes";
            this.radPerfumes.Size = new System.Drawing.Size(113, 26);
            this.radPerfumes.TabIndex = 3;
            this.radPerfumes.TabStop = true;
            this.radPerfumes.Text = "Perfumes";
            this.radPerfumes.UseVisualStyleBackColor = false;
            // 
            // radCustomers
            // 
            this.radCustomers.AutoSize = true;
            this.radCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radCustomers.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCustomers.Location = new System.Drawing.Point(73, 220);
            this.radCustomers.Name = "radCustomers";
            this.radCustomers.Size = new System.Drawing.Size(122, 26);
            this.radCustomers.TabIndex = 4;
            this.radCustomers.TabStop = true;
            this.radCustomers.Text = "Customers";
            this.radCustomers.UseVisualStyleBackColor = false;
            // 
            // radSales
            // 
            this.radSales.AutoSize = true;
            this.radSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radSales.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSales.Location = new System.Drawing.Point(72, 261);
            this.radSales.Name = "radSales";
            this.radSales.Size = new System.Drawing.Size(76, 26);
            this.radSales.TabIndex = 5;
            this.radSales.TabStop = true;
            this.radSales.Text = "Sales";
            this.radSales.UseVisualStyleBackColor = false;
            this.radSales.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radSale_Items
            // 
            this.radSale_Items.AutoSize = true;
            this.radSale_Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radSale_Items.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSale_Items.Location = new System.Drawing.Point(72, 302);
            this.radSale_Items.Name = "radSale_Items";
            this.radSale_Items.Size = new System.Drawing.Size(125, 26);
            this.radSale_Items.TabIndex = 6;
            this.radSale_Items.TabStop = true;
            this.radSale_Items.Text = "Sale_Items";
            this.radSale_Items.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "View_Table";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Elephant", 9F);
            this.button2.Location = new System.Drawing.Point(627, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add_Brand";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(627, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 49);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add Perfumes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(627, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 43);
            this.button4.TabIndex = 13;
            this.button4.Text = "Add Customers";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(627, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "Add Sales";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(627, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 43);
            this.button6.TabIndex = 15;
            this.button6.Text = "Add Sale_Items";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(605, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Update Tables";
            // 
            // radOrders
            // 
            this.radOrders.AutoSize = true;
            this.radOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radOrders.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrders.Location = new System.Drawing.Point(72, 350);
            this.radOrders.Name = "radOrders";
            this.radOrders.Size = new System.Drawing.Size(92, 26);
            this.radOrders.TabIndex = 17;
            this.radOrders.TabStop = true;
            this.radOrders.Text = "Orders";
            this.radOrders.UseVisualStyleBackColor = false;
            this.radOrders.CheckedChanged += new System.EventHandler(this.radOrders_CheckedChanged);
            // 
            // radOrderItems
            // 
            this.radOrderItems.AutoSize = true;
            this.radOrderItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radOrderItems.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrderItems.Location = new System.Drawing.Point(72, 393);
            this.radOrderItems.Name = "radOrderItems";
            this.radOrderItems.Size = new System.Drawing.Size(141, 26);
            this.radOrderItems.TabIndex = 18;
            this.radOrderItems.TabStop = true;
            this.radOrderItems.Text = "Order_Items";
            this.radOrderItems.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button7.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(627, 382);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 51);
            this.button7.TabIndex = 19;
            this.button7.Text = "Add Orders";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button8.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(627, 439);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(161, 49);
            this.button8.TabIndex = 20;
            this.button8.Text = "Add Order_Items";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button9.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(370, 489);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 36);
            this.button9.TabIndex = 21;
            this.button9.Text = "Close";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // AdminAccessPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 595);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.radOrderItems);
            this.Controls.Add(this.radOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radSale_Items);
            this.Controls.Add(this.radSales);
            this.Controls.Add(this.radCustomers);
            this.Controls.Add(this.radPerfumes);
            this.Controls.Add(this.radBrands);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminAccessPage";
            this.Text = "AccessPage";
            this.Load += new System.EventHandler(this.AdminAccessPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radBrands;
        private System.Windows.Forms.RadioButton radPerfumes;
        private System.Windows.Forms.RadioButton radCustomers;
        private System.Windows.Forms.RadioButton radSales;
        private System.Windows.Forms.RadioButton radSale_Items;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radOrders;
        private System.Windows.Forms.RadioButton radOrderItems;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}