using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Messaging;

namespace CLUEIT2
{
    public partial class mainWindow : Form
    {
        public mainWindow(string[] args)
        {
            InitializeComponent();
            makeNewPhraseTab(args);
            //string[] words = parseInitialInput(args);
            tBoxSearchTerms.Text = string.Join<string>(" ", args);
           // string mqPath = @"FormatName:DIRECT=OS:.\PRIVATE$\mq";
            ////string mqPath = @"FormatName:DIRECT=OS:.\private$\mq";
            //"DIRECT=OS:.\PRIVATE$\MyQueue";

          //  mq = new MessageQueue();
            ////mq.Path = mqPath;

           // mq = new MessageQueue
             //                       ("FormatName:Direct=OS:Nisha-PC\\private$\\mq");

          //  mq.
          //  if (MessageQueue.Exists("mq"))
            {
              //  MSG msg;

                ////mq.MachineName = ".";
                ////mq.QueueName = "mq";
                ////mq.BeginReceive();
            }
           // tabControlPhrases.Appearance = TabAppearance.FlatButtons;
        }

        void makeNewPhraseTab(string[] args)
        {
            string searchPart = string.Join<string>(" ", args);
            //maybe just call join instead of looping elsewhere

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

            tabControlPhrases.SelectedTab.BackColor = Color.White;
                //usevisualstylebackcolor

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

        private void mq_ReceiveCompleted(object sender, System.Messaging.ReceiveCompletedEventArgs e)
        {
            System.Messaging.Message m = mq.EndReceive(e.AsyncResult);
            m.Formatter = new System.Messaging.XmlMessageFormatter(
               new string[] { "System.String,mscorlib" });
           // Console.WriteLine("Message: " + (string)m.Body);
            string[] words = { (string)m.Body };// new string[1];
           // words[0]= (string)m.Body;

            words = parseInitialInput(words);
            makeNewPhraseTab(words);

            mq.BeginReceive();
        }



        private void ReceiveCallback(System.IAsyncResult result)
        {
         //   makeNewPhraseTab phrase buyer = (Customer)result.AsyncState;
         //   string buyerName = buyer.Name;
        }
    






    }
}
