using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterValues
{
    class LetterValuesConsole
    {
        private const string INPUT_FILE_NAME = "american-words.txt";
        private const int TARGET_LETTER_SUM = 100;

        /// <summary>
        /// Console app to sum letter values for each set of words and find words that sum 100
        /// 
        /// Note: this may not be the most performant approach - in a real world situation where
        /// this processing occurs repeatedly there may be value in storing the sums in a dictionary or similar
        /// cache.  This approach is chosen mainly for simplicity and clarity.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Letter values: run started at {0} reading from file '{1}'...", DateTime.Now.ToLongTimeString(), INPUT_FILE_NAME));
            try
            {
                // this assumes all words are on separate lines
                var wordList = File.ReadAllLines(INPUT_FILE_NAME);

                // filter the list using an extension method
                foreach (string s in wordList.Where(w => w.SumLetters() == TARGET_LETTER_SUM))
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("Exception occurred reading file [{0}]", INPUT_FILE_NAME));
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(String.Format("Letter values: run completed at {0}...", DateTime.Now.ToLongTimeString()));
          
        }
    }
}
