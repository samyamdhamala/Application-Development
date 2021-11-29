using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LoginRegister
{
    public partial class Form2 : Form
    {
        XmlSerializer xmlSerializer;
        List<UserDetails> users;
        bool validCustomer;
        public Form2()
        {
            InitializeComponent();
            users = new List<UserDetails>();
            xmlSerializer = new XmlSerializer(typeof(List<UserDetails>));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameTxtbox.Text;
            String password = pwTxtbox.Text;

            FileStream fileStream = new FileStream("C:/Users/sam/Documents/3rd Year/Application Development/git/Application-Development/FormWorkshop/userfile.xml", FileMode.Open, FileAccess.Read);
            users = (List<UserDetails>)xmlSerializer.Deserialize(fileStream); //casting filestream object to model
            fileStream.Close();

            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                  validCustomer   = true;
                }
            }

            if (validCustomer)
            {
                statusLoginValueLabel.Text = "Login Successful !";
            }
            else
            {
                statusLoginValueLabel.Text = "Login Unsuccessful !";
            }

            validCustomer = false;
            fileStream.Close();
        }








    }
    }
