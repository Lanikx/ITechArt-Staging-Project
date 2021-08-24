using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Staging_project.Helpers
{
    class XMLRead
    {
        public static object[] ReadFile(string path)
        {
            object[] inputData = new object[2];
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlElement xRoot = xmlDocument.DocumentElement;
            foreach (XmlNode node in xRoot.ChildNodes[0])
            {
                if (node.Name == "input")
                {
                    inputData[0] = node.InnerText;
                }
                if (node.Name == "result")
                {
                    inputData[1] = node.InnerText;
                }
            }
            return inputData;

        }

        
    }
}
