using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppDevProject
{
    internal class ChangeLanguage
    {
        public void UpdateConfig(string key, string value)
        {
            // Load app.config XML
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            // Find appSettings section
            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name == "appSettings")
                {
                    foreach (XmlNode node in xmlElement.ChildNodes)
                    {
                        if (node.Attributes[0].Value == key)
                        {
                            node.Attributes[1].Value = value;
                        }
                    }
                }
            }

            // Save updated config file
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            // Refresh configuration
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
