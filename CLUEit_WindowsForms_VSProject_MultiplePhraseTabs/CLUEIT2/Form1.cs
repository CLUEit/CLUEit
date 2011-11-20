using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLUEIT2
{
    public partial class mainWindow : Form
    {
        public mainWindow(string[] args)
        {
            InitializeComponent();
           // tabControlPhrases.SelectedTab = tabControlPhrases.TabPages[1];
            tabControlPhrases.TabPages.Remove(tabControlPhrases.TabPages[1]);
            tabControlPhrases.TabPages.Remove(tabControlPhrases.TabPages[0]);

           /* string[] words = parseInitialInput(args);
            tBoxSearchTerms.Text = string.Join<string>(" ", words);

            tabControlMain.TabPages[0].Text = "Wikipedia";
            loadWikipediaTab(words);
            //webBrowserWikipedia.Navigate("www.wikipedia.org");

            tabControlMain.TabPages[1].Text = "Google";
            loadGoogleTab(words);
            //webBrowserGoogle.Navigate("www.google.com");

            tabControlMain.TabPages[2].Text = "Images";
            loadImagesTab(words);
            //webBrowserImages.Navigate("www.google.com/imghp?hl=en&tab=wi");

            tabControlMain.TabPages[3].Text = "YouTube";
            loadYouTubeTab(words);
            //webBrowserImages.Navigate("www.youtube.com");*/
        }

        void makeNewPhraseTab(string[] args)
        {
            string searchPart = string.Join<string>(" ", args);
            //maybe jsut call join instead of looping elsewhere

            tabControlPhrases.TabPages.Add(searchPart);
            TabControl searches = new TabControl();
            searches.Parent = tabControlPhrases.TabPages[tabControlPhrases.TabCount - 1];
            searches.Size = searches.Parent.Size;
            searches.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);


            searches.TabPages.Add("Wikipedia");
            WebBrowser wikipediaBrowser = new WebBrowser();
            wikipediaBrowser.Parent = searches.TabPages[searches.TabCount-1];
            wikipediaBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadWikipediaTab(args, wikipediaBrowser);
            wikipediaBrowser.Size = wikipediaBrowser.Parent.Size;

            searches.TabPages.Add("Google");
            WebBrowser googleBrowser = new WebBrowser();
            googleBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            googleBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadGoogleTab(args, googleBrowser);
            googleBrowser.Size = googleBrowser.Parent.Size;

            searches.TabPages.Add("Images");
            WebBrowser imagesBrowser = new WebBrowser();
            imagesBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            imagesBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadImagesTab(args, imagesBrowser);
            imagesBrowser.Size = imagesBrowser.Parent.Size;

            searches.TabPages.Add("YouTube");
            WebBrowser youTubeBrowser = new WebBrowser();
            youTubeBrowser.Parent = searches.TabPages[searches.TabCount - 1];
            youTubeBrowser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Left);
            loadYouTubeTab(args, youTubeBrowser);
            youTubeBrowser.Size = youTubeBrowser.Parent.Size;

            tabControlPhrases.SelectedIndex = tabControlPhrases.TabCount - 1;

        }


         private void loadWikipediaTab(string[] args, WebBrowser browser)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "_";
            }
             
             browser.Navigate("http://en.wikipedia.org/wiki/" + searchPart);
            //webBrowserWikipedia.Navigate("http://en.wikipedia.org/wiki/" + searchPart);
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
           // webBrowserGoogle.Navigate("https://www.google.com/search?rlz=1C1CHFX_enUS454US454&gcx=w&ix=c1&sourceid=chrome&ie=UTF-8&q="
           // + searchPart);
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
           // webBrowserImages.Navigate("http://www.google.com/search?tbm=isch&hl=en&source=hp&biw=1366&bih=635&q="
            //+ searchPart
            //+ "&gbv=2&oq="
            //+ searchPart
            //+ "&aq=f&aqi=g5g-m5&aql=1&gs_sm=e&gs_upl=1761l2788l0l2849l8l3l0l0l0l0l137l371l0.3l3l0");

             //webBrowserWikipedia.Navigate("http://www.google.com/search?tbm=isch&hl=en&source=hp&biw=1366&bih=674&gbv=2&oq=" 
                  //  + searchPart
                    //+ "&aq=f&aqi=g10&gs_upl=2303120l2305059l0l2306057l12l11l0l2l2l0l384l1587l1.5.2.1l9l0&q=vincent%20van&orq=vincent+van+");
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
          //  webBrowserYouTube.Navigate("http://www.youtube.com/results?search_query="
            //+ searchPart
            //+ "&aq=f");
        }

        private void loadDictionaryTab(string[] args)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tBoxSearchTerms.Text == "")
            {
                MessageBox.Show("No search terms were entered");
                return;
            }

            makeNewPhraseTab(tBoxSearchTerms.Text.Split(' '));
            /*string[] args = tBoxSearchTerms.Text.Split(' ');
            loadWikipediaTab(args);
            loadGoogleTab(args);
            loadImagesTab(args);
            loadYouTubeTab(args);
            loadDictionaryTab(args);*/
        }




    






    }
}
