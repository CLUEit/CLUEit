using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace UserPreferences
{
    public enum settings {
        defaultDisplay = 0,
        alwaysDisplay = 1,
        neverDisplay = 2
    };

    public class Preference
    {
        //MEMBERS
        //name of the web service (read only)
        private string serviceName;
        public string ServiceName
        {
            get
            {
                return serviceName;
            }
        }

        //value of the setting of this service (read/write)
        private settings setting;
        public settings Setting
        {
            get
            {
                return setting;
            }
            set
            {
                setting = value;
            }
        }


        //METHODS
        //creates preference object from XMLElement
        public Preference(XmlElement fileElement)
        {
            serviceName = fileElement.GetAttribute("name");
            if (serviceName.Length == 0)
            {
                throw new Exception("XML Element was not well formed");
            }
            XmlNodeList children = fileElement.GetElementsByTagName("preference");
            if (children.Count != 1)
            {
                throw new Exception("XML Element was not well formed");
            }
            XmlElement preference = (XmlElement)children[0];
            string settingString = preference.GetAttribute("setting");
            if (settingString == "default")
            {
                setting = settings.defaultDisplay;
            }
            else if (settingString == "always")
            {
                setting = settings.alwaysDisplay;
            }
            else if (settingString == "never")
            {
                setting = settings.neverDisplay;
            }
            else
            {
                throw new Exception("XML Element was not well formed");
            }
        }
        //creates preference object from serviceName and setting values
        public Preference(string serviceName_, settings setting_)
        {
            serviceName = serviceName_;
            setting = setting_;
        }

        //creates xmlElement representation of this preference and appends it to parent's document element
        public XmlElement getXmlPreference(XmlDocument parent)
        {
            XmlElement serviceElement = parent.CreateElement("webservice");
            serviceElement.SetAttributeNode(parent.CreateAttribute("name"));
            serviceElement.SetAttribute("name", serviceName);
            XmlElement preferenceElement = parent.CreateElement("preference");
            preferenceElement.SetAttributeNode(parent.CreateAttribute("setting"));
            if (setting == settings.alwaysDisplay)
            {
                preferenceElement.SetAttribute("setting", "always");
            }
            else if (setting == settings.defaultDisplay)
            {
                preferenceElement.SetAttribute("setting", "default");
            }
            else
            {
                preferenceElement.SetAttribute("setting", "never");
            }
            serviceElement.AppendChild(preferenceElement);
            parent.DocumentElement.AppendChild(serviceElement);
            return serviceElement;
        }

    }
}
