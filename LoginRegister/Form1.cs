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
    public partial class Form1 : Form
    {
        XmlSerializer xmlSerializer;
        List<UserDetails> users;
        public Form1()
        {
            InitializeComponent();
            users = new List<UserDetails>();
            xmlSerializer = new XmlSerializer(typeof(List<UserDetails>));
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:/Users/sam/Documents/3rd Year/Application Development/git/Application-Development/FormWorkshop/userfile.xml", FileMode.Create, FileAccess.Write);
            UserDetails user = new UserDetails();
            user.Name = nameTxtbox.Text;
            user.Address = addressTxtbox.Text;
            user.DOB = DateTime.Parse(dateTimePicker1.Text);
            user.PhoneNumber = Int32.Parse(phnTxtbox.Text);
            user.Username = usernameTxtBox.Text;
            user.Password = passwordTxtbox.Text;

            users.Add(user);

            xmlSerializer.Serialize(fileStream, users); //Serializer writes on the xml file
            fileStream.Close();
        }

        private void loginBtn1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
