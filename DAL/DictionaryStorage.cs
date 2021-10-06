using System.Collections.Generic;

namespace Jed_mind_tricks.DAL
{
    class DictionaryStorage
    {
        public Dictionary<string, int> people = new Dictionary<string, int>();

        public DictionaryStorage()
        {
            people.Add("Joe", 25);
            people.Add("Jake", 25);
            people.Add("James", 25);
        }
    }
}