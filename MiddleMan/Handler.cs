using Jed_mind_tricks.DAL;
using System.Collections.Generic;

namespace Jed_mind_tricks.MiddleMan
{
    class Handler
    {
        private DictionaryStorage dictionaryStorage = new DictionaryStorage();

        public Dictionary<string, int> getDictionary()
        {
            return dictionaryStorage.people;
        }

        public void DictionaryEntryRemover()
        {
            dictionaryStorage.people.Remove("Jake");
        }
    }
}