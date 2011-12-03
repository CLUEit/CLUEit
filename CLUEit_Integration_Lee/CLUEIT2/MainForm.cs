using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace CLUEIT2
{
    public partial class mainWindow : Form
    {
        public mainWindow(string[] args)
        {
            InitializeComponent();
            string[] words = parseInitialInput(args);
            tBoxSearchTerms.Text = string.Join<string>(" ", words);
           // tabControlPhrases.Appearance = TabAppearance.FlatButtons;
        }
        public static string ScreenScrape(string url)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                // set properties of the client 
                return client.DownloadString(url);
            }
        }

        void makeNewPhraseTab(string[] args)
        {
            string searchPart = string.Join<string>(" ", args);
            searchPart = searchPart.Trim();
            //maybe jsut call join instead of looping elsewhere

            tabControlPhrases.TabPages.Add(searchPart);
            TabControl searches = new TabControl();
            searches.Parent = tabControlPhrases.TabPages[tabControlPhrases.TabCount - 1];
            searches.Size = searches.Parent.Size;
            searches.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);

         
            Dictionary<string, bool> dictionary = new Dictionary<string, bool>();

            Preferences preferences = new Preferences();

            foreach (Preference preference_ in preferences.preferenceList)
            {
                if (preference_.Setting == settings.alwaysDisplay)
                {
                    dictionary.Add(preference_.ServiceName, true);
                }
                else if (preference_.Setting == settings.neverDisplay)
                {
                    dictionary.Add(preference_.ServiceName, false);
                }
                else
                {
                    if (preference_.ServiceName == "wikipedia")
                    {
                        dictionary.Add(preference_.ServiceName, true);
                    }
                    else if (preference_.ServiceName == "google")
                    {
                        dictionary.Add(preference_.ServiceName, true);
                    }
                    else if (preference_.ServiceName == "google_images")
                    {
                        dictionary.Add(preference_.ServiceName, true);
                    }
                    else if (preference_.ServiceName == "google_maps")
                    {
                        string addressPattern = @"(?<address1>((\d{1,5}(\ [a-z]+[.])?)(\ [a-z0-9]+)+)|(p\.o\.\ box\ \d{1,5}))((?<city>\ [A-Za-z]+,\ )(?<state>(A[LKSZRAP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])))?";
                       
                        if (System.Text.RegularExpressions.Regex.IsMatch(searchPart, addressPattern, System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace | System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            dictionary.Add(preference_.ServiceName, true);
                        }
                        else
                        {
                            dictionary.Add(preference_.ServiceName, false);
                        }
                    }
                    else if (preference_.ServiceName == "youtube")
                    {
                        string youtubeSearch = "";
                        foreach (string arg in args)
                        {
                            youtubeSearch += arg + "+";
                        }
                        string youtubePage = ScreenScrape("http://www.youtube.com/results?search_query=" + youtubeSearch);
                        string youtubePattern = @"(No\ video\ results\ for)";

                        if (System.Text.RegularExpressions.Regex.IsMatch(youtubePage, youtubePattern, System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace | System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            dictionary.Add(preference_.ServiceName, false);
                        }
                        else
                        {
                            dictionary.Add(preference_.ServiceName, true);
                        }
                    }
                    else if (preference_.ServiceName == "bing")
                    {
                        dictionary.Add(preference_.ServiceName, true);
                    }
                    else if (preference_.ServiceName == "yahoo")
                    {
                        dictionary.Add(preference_.ServiceName, true);
                    }
                    else if (preference_.ServiceName == "dictionary.com")
                    {
                        dictionary.Add(preference_.ServiceName, true);

                        for (int i = 0; i < searchPart.Length; i++)
                        {
                            if(!Char.IsLetter(searchPart[i]))
                            {
                                dictionary[preference_.ServiceName] = false;
                            }
                        }

                        if (dictionary[preference_.ServiceName])
                        {
                            string dictPage = ScreenScrape("http://dictionary.reference.com/browse/" + searchPart);
                            string dictPattern = @"(no\ dictionary\ results)";

                            if (System.Text.RegularExpressions.Regex.IsMatch(dictPage, dictPattern, System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace | System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                            {
                                dictionary[preference_.ServiceName] = false;
                            }
                        }
                    }
                    else if (preference_.ServiceName == "imdb")
                    {
                        string movieSearch = "";
                        foreach (string arg in args)
                        {
                            movieSearch += arg + "+";
                        }

                        string imdbPage = ScreenScrape("http://www.imdb.com/find?s=all&q=" + movieSearch);
                        string imdbPattern = @"(No\ Matches.)";

                        if (System.Text.RegularExpressions.Regex.IsMatch(imdbPage, imdbPattern, System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace | System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            dictionary.Add(preference_.ServiceName, false);
                        }
                        else
                        {
                            dictionary.Add(preference_.ServiceName, true);
                        }
                    }
                    else if (preference_.ServiceName == "amazon")
                    {
                        string amazonSearch = "";
                        foreach (string arg in args)
                        {
                            amazonSearch += arg + "+";
                        }
                        string amazonPage = ScreenScrape("http://www.amazon.com/s/ref=nb_sb_ss_i_7_5?url=search-alias%3Daps&field-keywords=" + amazonSearch);
                        string amazonPattern = @"(No\ Results\ Match\ Your\ Search)";

                        if (System.Text.RegularExpressions.Regex.IsMatch(amazonPage, amazonPattern, System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace | System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            dictionary.Add(preference_.ServiceName, false);
                        }
                        else
                        {
                            dictionary.Add(preference_.ServiceName, true);
                        }
                    }
                    else if (preference_.ServiceName == "ebay")
                    {
                        dictionary.Add(preference_.ServiceName, true);

                        try
                        {
                            if (dictionary["amazon"] == false)
                            {
                                dictionary[preference_.ServiceName] = false;
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("{0}: Amazon must come before ebay in preference xml", e);
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Error: Service Names incorrect");
                    }
                }
            }

            if (dictionary["google"])
            {
                searches.TabPages.Add("Google");
                WebBrowser googleBrowser = new WebBrowser();
                googleBrowser.Parent = searches.TabPages[searches.TabCount - 1];
                googleBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                    | AnchorStyles.Top | AnchorStyles.Left);
                loadGoogleTab(args, googleBrowser);
                googleBrowser.Size = googleBrowser.Parent.Size;
            }

            if (dictionary["google_images"])
            {
                searches.TabPages.Add("Images");
                WebBrowser imagesBrowser = new WebBrowser();
                imagesBrowser.Parent = searches.TabPages[searches.TabCount - 1];
                imagesBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                    | AnchorStyles.Top | AnchorStyles.Left);
                loadImagesTab(args, imagesBrowser);
                imagesBrowser.Size = imagesBrowser.Parent.Size;
            }

            if(dictionary["google_maps"])
            {
            searches.TabPages.Add("Maps");
            WebBrowser mapsBrowser = new WebBrowser();
            mapsBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            mapsBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadMapsTab(args, mapsBrowser);
            mapsBrowser.Size = mapsBrowser.Parent.Size;
            }
            
            if(dictionary["youtube"])
            {
            searches.TabPages.Add("YouTube");
            WebBrowser youTubeBrowser = new WebBrowser();
            youTubeBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            youTubeBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadYouTubeTab(args, youTubeBrowser);
            youTubeBrowser.Size = youTubeBrowser.Parent.Size;
            }

            if (dictionary["wikipedia"])
            {
                searches.TabPages.Add("Wikipedia");
                WebBrowser wikipediaBrowser = new WebBrowser();
                wikipediaBrowser.Parent = searches.TabPages[searches.TabCount - 1];
                wikipediaBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                    | AnchorStyles.Top | AnchorStyles.Left);
                loadWikipediaTab(args, wikipediaBrowser);
                wikipediaBrowser.Size = wikipediaBrowser.Parent.Size;
            }

            if(dictionary["bing"])
            {
            searches.TabPages.Add("Bing");
            WebBrowser bingBrowser = new WebBrowser();
            bingBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            bingBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadBingTab(args, bingBrowser);
            bingBrowser.Size = bingBrowser.Parent.Size;
            }

            if(dictionary["yahoo"])
            {
            searches.TabPages.Add("Yahoo");
            WebBrowser yahooBrowser = new WebBrowser();
            yahooBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            yahooBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadYahooTab(args, yahooBrowser);
            yahooBrowser.Size = yahooBrowser.Parent.Size;
            }

            if(dictionary["dictionary.com"])
            {
            searches.TabPages.Add("Dictionary");
            WebBrowser dictionaryBrowser = new WebBrowser();
            dictionaryBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            dictionaryBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadDictionaryTab(args, dictionaryBrowser);
            dictionaryBrowser.Size = dictionaryBrowser.Parent.Size;
            }

            if(dictionary["imdb"])
            {
            searches.TabPages.Add("IMDB");
            WebBrowser imdbBrowser = new WebBrowser();
            imdbBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            imdbBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadImdbTab(args, imdbBrowser);
            imdbBrowser.Size = imdbBrowser.Parent.Size;
            }

            if(dictionary["ebay"])
            {
            searches.TabPages.Add("Ebay");
            WebBrowser ebayBrowser = new WebBrowser();
            ebayBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            ebayBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadEbayTab(args, ebayBrowser);
            ebayBrowser.Size = ebayBrowser.Parent.Size;
            }

            if(dictionary["amazon"])
            {
            searches.TabPages.Add("Amazon");
            WebBrowser amazonBrowser = new WebBrowser();
            amazonBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            amazonBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadAmazonTab(args, amazonBrowser);
            amazonBrowser.Size = amazonBrowser.Parent.Size;
            }

            tabControlPhrases.SelectedIndex = tabControlPhrases.TabCount - 1;
            tabControlPhrases.SelectedTab.BackColor = Color.White;
        }

        string[] parseInitialInput(string[] args)
        {
            char[] delimiters = new char[] { '\r', '\n', '\t', ' ' };
            string[] words = { };
            string[] someWords = { };
            List<string> wordsList = new List<string>();

            foreach (string arg in args)
            {
                someWords = arg.Split(delimiters,
                 StringSplitOptions.RemoveEmptyEntries);
                wordsList = new List<string>(wordsList.Concat<string>(someWords));
            }

            words = wordsList.ToArray();
            return words;

        }

        private void loadDictionaryTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("http://dictionary.reference.com/browse/" + searchPart);
        }

        private void loadWikipediaTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "_";
            }

            browser.Navigate("http://en.wikipedia.org/wiki/" + searchPart);
        }

        private void loadImdbTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("http://www.imdb.com/find?s=all&q=" + searchPart);
        }

        private void loadEbayTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("http://www.ebay.com/sch/i.html?_nkw=" + searchPart);
        }


        private void loadBingTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("http://www.bing.com/search?q=" + searchPart);
        }

        private void loadYahooTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("http://search.yahoo.com/search;_ylt=Aohh5VayDzLsk0P2xG_Fq5.bvZx4?p=" + searchPart);
        }

        private void loadAmazonTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("http://www.amazon.com/s/ref=nb_sb_ss_i_7_5?url=search-alias%3Daps&field-keywords=" + searchPart);
        }

        private void loadMapsTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("http://maps.google.com/maps?hl=en&sugexp=cpsugrstla&cp=5&gs_id=n&xhr=t&q=" + searchPart);
        }

        private void loadGoogleTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }
            browser.Navigate("https://www.google.com/search?rlz=1C1CHFX_enUS454US454&gcx=w&ix=c1&sourceid=chrome&ie=UTF-8&q="
            + searchPart);
        }

        private void loadImagesTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }

            browser.Navigate("http://www.google.com/search?tbm=isch&hl=en&source=hp&biw=1366&bih=635&q="
            + searchPart
            + "&gbv=2&oq="
            + searchPart
            + "&aq=f&aqi=g5g-m5&aql=1&gs_sm=e&gs_upl=1761l2788l0l2849l8l3l0l0l0l0l137l371l0.3l3l0");
        }

        private void loadYouTubeTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }

            browser.Navigate("http://www.youtube.com/results?search_query="
            + searchPart
            + "&aq=f");
        }

        private void loadSettingsForm()
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tBoxSearchTerms.Text == "")
            {
                MessageBox.Show("No search terms were entered");
                return;
            }

            makeNewPhraseTab(tBoxSearchTerms.Text.Split(' '));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadSettingsForm();
        }

        private void tabControlPhrases_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //tabControlPhrases.SelectedTab.BackColor = Color.BlanchedAlmond;
           // I think setting the ForeColor of the selected tab to SystemColors.ControlLightLight will
          //  tabControlPhrases.SelectedTab.ForeColor = SystemColors.Highlight;
        }

        private void tabControlPhrases_Deselecting(object sender, TabControlCancelEventArgs e)
        {
           // tabControlPhrases.SelectedTab.ForeColor = SystemColors.Control
        }
    }
}
