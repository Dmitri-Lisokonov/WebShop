namespace WebShop
{
    partial class CustomerDashBoard
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelStreetName = new System.Windows.Forms.Label();
            this.labelStreetNumber = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(24, 27);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 40);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelStreetName
            // 
            this.labelStreetName.AutoSize = true;
            this.labelStreetName.Location = new System.Drawing.Point(24, 53);
            this.labelStreetName.Name = "labelStreetName";
            this.labelStreetName.Size = new System.Drawing.Size(66, 13);
            this.labelStreetName.TabIndex = 2;
            this.labelStreetName.Text = "Street Name";
            // 
            // labelStreetNumber
            // 
            this.labelStreetNumber.AutoSize = true;
            this.labelStreetNumber.Location = new System.Drawing.Point(24, 66);
            this.labelStreetNumber.Name = "labelStreetNumber";
            this.labelStreetNumber.Size = new System.Drawing.Size(75, 13);
            this.labelStreetNumber.TabIndex = 3;
            this.labelStreetNumber.Text = "Street Number";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(24, 79);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(24, 92);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(64, 13);
            this.labelPostalCode.TabIndex = 5;
            this.labelPostalCode.Text = "Postal Code";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(24, 105);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Country";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(24, 118);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.labelPaymentMethod.TabIndex = 7;
            this.labelPaymentMethod.Text = "Payment Method";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(211, 118);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 154);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStreetNumber);
            this.Controls.Add(this.labelStreetName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "CustomerDashBoard";
            this.Text = "CustomerDashBoard";
            this.Load += new System.EventHandler(this.CustomerDashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelStreetName;
        private System.Windows.Forms.Label labelStreetNumber;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Button buttonEdit;
    }
}