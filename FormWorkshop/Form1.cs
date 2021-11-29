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

namespace FormWorkshop
{
    public partial class Form1 : Form
    {
        XmlSerializer xmlSerializer;
        List<EmployeeDetails> employees;
        public Form1()
        {
            InitializeComponent();
            employees = new List<EmployeeDetails>();
            xmlSerializer = new XmlSerializer(typeof(List<EmployeeDetails>));
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:/Users/sam/Documents/3rd Year/Application Development/FormWorkshop/file.xml", FileMode.Create, FileAccess.Write );
            EmployeeDetails employee = new EmployeeDetails();
            employee.EmployeeID = Int32.Parse(empTxtbox.Text);
            employee.Name = nameTxtbox.Text;
            employee.Designation = designationTxtbox.Text;
            employee.Department = departmentTxtbox.Text;
            employee.Salary = Double.Parse(salaryTxtbox.Text);
            employee.JoinDate = DateTime.Parse(joindateTxtbox.Text);
            employee.Address = addressTxtbox.Text;
            employee.ContactNumber = Int32.Parse(contactTxtbox.Text);
            employee.MaritalStatus = maritalstsTxtbox.Text;
            employee.Age = Int32.Parse(ageTxtbox.Text);

            employees.Add(employee);

            xmlSerializer.Serialize(fileStream, employees); //Serializer writes on the xml file
            fileStream.Close();
            //empTxtbox.Clear();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:/Users/sam/Documents/3rd Year/Application Development/FormWorkshop/file.xml", FileMode.Open, FileAccess.Read);
            employees = (List<EmployeeDetails>)xmlSerializer.Deserialize(fileStream); //casting filestream object to model

            dataGridView1.DataSource = employees;
            fileStream.Close();
        }

    }
}
