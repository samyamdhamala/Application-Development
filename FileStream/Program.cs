using System;
using System.IO;
using System.Xml;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream sample = new FileStream("C:/Users/sam/Documents/3rd Year/Application Development/FileStream/test.xml",FileMode.Create);

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            XmlWriter writer = XmlWriter.Create(sample, writerSettings);
            {
                NewMethod(writer);
                writer.WriteStartElement("Employee");
                writer.WriteElementString("Name", "John Doe");
                writer.WriteElementString("Age", "54");
                writer.WriteEndElement();

                writer.WriteStartElement("Employee");
                writer.WriteElementString("Name", "Harry Styles");
                writer.WriteElementString("Age", "24");
                writer.WriteEndElement();

                writer.WriteStartElement("Employee");
                writer.WriteElementString("Name", "Taylor Swift");
                writer.WriteElementString("Age", "31");
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
        }

        private static void NewMethod(XmlWriter writer)
        {
            writer.WriteStartElement("Person");
        }
    }
}
