using Jed_mind_tricks.MiddleMan;
using System;

namespace Jed_mind_tricks
{
    class GUI
    {
        private Handler handler = new Handler();

        public void Execute()
        {
            handler.DictionaryEntryRemover();

            foreach (var item in handler.getDictionary())
            {
                Console.WriteLine(item.Key + " is " + item.Value);
            }
        }
    }
}