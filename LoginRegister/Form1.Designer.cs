
namespace LoginRegister
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.addressTxtbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.regButton = new System.Windows.Forms.Button();
            this.phnTxtbox = new System.Windows.Forms.TextBox();
            this.phnLbl = new System.Windows.Forms.Label();
            this.loginBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(35, 61);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 17);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(35, 236);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(73, 17);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(35, 276);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(35, 153);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(90, 17);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "Date Of Birth";
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Location = new System.Drawing.Point(175, 56);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(200, 22);
            this.nameTxtbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(175, 231);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(200, 22);
            this.usernameTxtBox.TabIndex = 7;
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Location = new System.Drawing.Point(175, 271);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.PasswordChar = '*';
            this.passwordTxtbox.Size = new System.Drawing.Size(200, 22);
            this.passwordTxtbox.TabIndex = 8;
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.Location = new System.Drawing.Point(175, 102);
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.Size = new System.Drawing.Size(200, 22);
            this.addressTxtbox.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(166, 316);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 28);
            this.regButton.TabIndex = 12;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // phnTxtbox
            // 
            this.phnTxtbox.Location = new System.Drawing.Point(175, 190);
            this.phnTxtbox.Name = "phnTxtbox";
            this.phnTxtbox.Size = new System.Drawing.Size(200, 22);
            this.phnTxtbox.TabIndex = 14;
            // 
            // phnLbl
            // 
            this.phnLbl.AutoSize = true;
            this.phnLbl.Location = new System.Drawing.Point(35, 195);
            this.phnLbl.Name = "phnLbl";
            this.phnLbl.Size = new System.Drawing.Size(103, 17);
            this.phnLbl.TabIndex = 13;
            this.phnLbl.Text = "Phone Number";
            // 
            // loginBtn1
            // 
            this.loginBtn1.Location = new System.Drawing.Point(274, 380);
            this.loginBtn1.Name = "loginBtn1";
            this.loginBtn1.Size = new System.Drawing.Size(112, 29);
            this.loginBtn1.TabIndex = 16;
            this.loginBtn1.Text = "Login Here ->";
            this.loginBtn1.UseVisualStyleBackColor = true;
            this.loginBtn1.Click += new System.EventHandler(this.loginBtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 415);
            this.Controls.Add(this.loginBtn1);
            this.Controls.Add(this.phnTxtbox);
            this.Controls.Add(this.phnLbl);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.addressTxtbox);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxtbox);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtbox;
        private System.Windows.Forms.TextBox addressTxtbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox phnTxtbox;
        private System.Windows.Forms.Label phnLbl;
        private System.Windows.Forms.Button loginBtn1;
    }
}

