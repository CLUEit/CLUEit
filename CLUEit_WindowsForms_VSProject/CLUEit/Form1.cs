using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLUEit
{
    public partial class mainWindow : Form
    {
        public mainWindow(string[] args)
        {
            InitializeComponent();

            string[] words = parseInitialInput(args);
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
            //webBrowserImages.Navigate("www.youtube.com");
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




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tBoxSearchTerms.Text == "")
            {
                MessageBox.Show("No search terms were entered");
                return;
            }
            string[] args = tBoxSearchTerms.Text.Split(' ');
            loadWikipediaTab(args);
            loadGoogleTab(args);
            loadImagesTab(args);
            loadYouTubeTab(args);
            loadDictionaryTab(args);
        }

        private void loadWikipediaTab(string[] args)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "_";
            }
             
            webBrowserWikipedia.Navigate("http://en.wikipedia.org/wiki/" + searchPart);
        }

        private void loadGoogleTab(string[] args)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }

            webBrowserGoogle.Navigate("https://www.google.com/search?rlz=1C1CHFX_enUS454US454&gcx=w&ix=c1&sourceid=chrome&ie=UTF-8&q="
            + searchPart);
        }

        private void loadImagesTab(string[] args)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }

            webBrowserImages.Navigate("http://www.google.com/search?tbm=isch&hl=en&source=hp&biw=1366&bih=635&q="
            + searchPart
            + "&gbv=2&oq="
            + searchPart
            + "&aq=f&aqi=g5g-m5&aql=1&gs_sm=e&gs_upl=1761l2788l0l2849l8l3l0l0l0l0l137l371l0.3l3l0");

             //webBrowserWikipedia.Navigate("http://www.google.com/search?tbm=isch&hl=en&source=hp&biw=1366&bih=674&gbv=2&oq=" 
                  //  + searchPart
                    //+ "&aq=f&aqi=g10&gs_upl=2303120l2305059l0l2306057l12l11l0l2l2l0l384l1587l1.5.2.1l9l0&q=vincent%20van&orq=vincent+van+");
        }

        private void loadYouTubeTab(string[] args)
        {
            string searchPart = "";
            foreach (string arg in args)
            {
                searchPart += arg + "+";
            }

            webBrowserYouTube.Navigate("http://www.youtube.com/results?search_query="
            + searchPart
            + "&aq=f");
        }

        private void loadDictionaryTab(string[] args)
        {
        }




    }
}
