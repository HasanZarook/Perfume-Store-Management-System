namespace Perfume_Store
{
    partial class UserAccessPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccessPage));
            this.label1 = new System.Windows.Forms.Label();
            this.radBrands = new System.Windows.Forms.RadioButton();
            this.radPerfumes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASTER_PERFUME-USER";
            // 
            // radBrands
            // 
            this.radBrands.AutoSize = true;
            this.radBrands.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radBrands.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBrands.Location = new System.Drawing.Point(123, 178);
            this.radBrands.Name = "radBrands";
            this.radBrands.Size = new System.Drawing.Size(177, 26);
            this.radBrands.TabIndex = 1;
            this.radBrands.TabStop = true;
            this.radBrands.Text = "Perfume_Brands";
            this.radBrands.UseVisualStyleBackColor = false;
            // 
            // radPerfumes
            // 
            this.radPerfumes.AutoSize = true;
            this.radPerfumes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radPerfumes.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPerfumes.Location = new System.Drawing.Point(152, 247);
            this.radPerfumes.Name = "radPerfumes";
            this.radPerfumes.Size = new System.Drawing.Size(113, 26);
            this.radPerfumes.TabIndex = 2;
            this.radPerfumes.TabStop = true;
            this.radPerfumes.Text = "Perfumes";
            this.radPerfumes.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(100, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Tables";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "View_Table";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(477, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Place Your Order";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(528, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserAccessPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radPerfumes);
            this.Controls.Add(this.radBrands);
            this.Controls.Add(this.label1);
            this.Name = "UserAccessPage";
            this.Text = "UserAccessPage";
            this.Load += new System.EventHandler(this.UserAccessPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radBrands;
        private System.Windows.Forms.RadioButton radPerfumes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}