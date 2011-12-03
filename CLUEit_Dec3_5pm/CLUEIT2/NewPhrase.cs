using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLUEIT2
{
    class NewPhrase
    {
        public
        NewPhrase(string[] words_)
        {
            words = words_;
        }

        string[] getWords()
        {
            return words;
        }


        private
            string[] words;

    }
}
