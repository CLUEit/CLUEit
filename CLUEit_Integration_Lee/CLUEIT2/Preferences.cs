using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CLUEIT2
{
    public class Preferences
    {
        //MEMBERS:
        //container of Preference objects
        public List<Preference> preferenceList;
        //name of the file containing the xml preferences
        private const string xmlFilename = @"C:\Program Files\CLUEit\preferences.xml";
        //xmldocument type containing xml data
        private XmlDocument preferenceDoc;

        //METHODS:
        //constructor from preferences file
        public Preferences()
        {
            preferenceList = new List<Preference>();
            preferenceDoc = new XmlDocument();
            preferenceDoc.Load(xmlFilename);
            XmlNodeList services = preferenceDoc.GetElementsByTagName("webservice");
            foreach(XmlNode service in services)
            {
                Preference newPref = new Preference((XmlElement)service);
                preferenceList.Add(newPref);
            }
        }
        public void AddPreference(Preference preference)
        {
            foreach (Preference preference_ in preferenceList)
            {
                if (preference_.ServiceName == preference.ServiceName)
                {
                    throw new Exception("That preference already exists!");
                }
            }
            preferenceList.Add(preference);
            //create xml for the preference and write to disk
            XmlElement newElement = preference.getXmlPreference(preferenceDoc);
            preferenceDoc.Save(xmlFilename);
        }

        public void AddPreference(string serviceName, settings setting)
        {
            Preference preference = new Preference(serviceName, setting);
            AddPreference(preference);
        }

        public void UpdatePreference(string serviceName, settings newSetting)
        {
            Preference preference = getPreferenceByName(serviceName);
            if (preference == null)
            {
                throw new Exception("the serviceName does not exist in the preference list");
            }
            preference.Setting = newSetting;
            XmlElement serviceElement = getPrefElementByName(serviceName);
            XmlElement pref = (XmlElement)serviceElement.GetElementsByTagName("preference")[0];
            if (newSetting == settings.alwaysDisplay)
            {
                pref.SetAttribute("setting", "always");
            }
            else if (newSetting == settings.neverDisplay)
            {
                pref.SetAttribute("setting", "never");
            }
            else //if (newSetting == settings.defaultDisplay)
            {
                pref.SetAttribute("setting", "default");
            }
            preferenceDoc.Save(xmlFilename);
        }

        private Preference getPreferenceByName(string serviceName)
        {
            foreach (Preference preference in preferenceList)
            {
                if (preference.ServiceName == serviceName)
                {
                    return preference;
                }
            }
            return null;
        }

        private XmlElement getPrefElementByName(string serviceName)
        {
            XmlNodeList preferences = preferenceDoc.DocumentElement.GetElementsByTagName("webservice");
            foreach (XmlElement service in preferences)
            {
                if (service.GetAttribute("name") == serviceName)
                {
                    return service;
                }
            }
            return null;
        }

        public settings getSettingOfService(string serviceName)
        {
            Preference preference = getPreferenceByName(serviceName);
            if (preference == null)
            {
                throw new Exception("the provided serviceName doesn't exist!");
            }
            return preference.Setting;
        }

        public void DeletePreference(string serviceName)
        {
            Preference preference = getPreferenceByName(serviceName);
            preferenceList.Remove(preference);
            XmlElement serviceElement = getPrefElementByName(serviceName);
            preferenceDoc.DocumentElement.RemoveChild(serviceElement);
            preferenceDoc.Save(xmlFilename);
        }
    }
}
