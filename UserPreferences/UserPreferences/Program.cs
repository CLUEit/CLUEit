using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UserPreferences
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //here's an example of how to use the preferences interface.

            //first, at the start of the first phrase tab of clueit, load the preferences from the file
            //this occurs in the Preferences constructor:
            Preferences preferences = new Preferences();

            //this adds a new preference to the preferences list (I don't think we'll ever use this)
            //settings is an enum, which contains "defaultDisplay" "alwaysDisplay" and "neverDisplay"
            preferences.AddPreference("newServiceName", settings.defaultDisplay);

            //this changes the preference of "bing" from whatever it was to be alwaysDisplay
            //it throws and exception if the webservice doesn't exist in the preferences
            preferences.UpdatePreference("bing", settings.alwaysDisplay);

            //this returns the setting of the service parameter
            //it throws an excpetion if the string doesn't mat and existing service
            settings setting = preferences.getSettingOfService("wikipedia");

            //this deletes the preference element corresponding to the provided service name
            preferences.DeletePreference("newServiceName");

            //note that all of the functions which modify the file (update add delete) save the changes immediately
            //from within the function.  It isn't threaded as of right now, but when I run it on tests with lots of 
            //updates, there is no noticable lag time so I think we'll be ok without adding threading to this part.
        }
    }
}
