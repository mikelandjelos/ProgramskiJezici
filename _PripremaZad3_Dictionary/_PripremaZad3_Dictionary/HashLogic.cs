using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PripremaZad3_Dictionary
{
    internal class HashLogic
    {

        private Dictionary<string, List<string>> dictionary;

        public HashLogic()
        { 
            dictionary = new Dictionary<string, List<string>>();
        }

        public void InsertTranslation(string key, string translation)
        {
            if (!dictionary.ContainsKey(key))
                InsertKey(key);
            if (!dictionary[key].Contains(translation))
                dictionary[key].Add(translation);
        }

        public bool? WithdrawTranslation(string key, string translation)
        {
            if (dictionary.ContainsKey(key))
                return dictionary[key].Remove(translation);
            return null;
            // ako je povratna vrednost null => key se ne nalazi u dic.
            // true => Withdrawal successful
            // false => Withdrawal unsuccessful
        }

        public string[] this[string key]
        {
            get 
            {
                if (dictionary.ContainsKey(key))
                    return dictionary[key].ToArray();
                return null;
                // ukoliko je povratna vrednost null => key se ne nalazi u dic.
            }
        }

        public List<string> Translations(string key)
        {
            if (dictionary.ContainsKey(key))
                return dictionary[key];
            return null;
        }

        public Dictionary<string, List<string>>.KeyCollection Keys
        {
            get { return dictionary.Keys; }
        }

        public bool InsertKey(string key)
        {
            if (dictionary.ContainsKey(key))
                return false;
            dictionary.Add(key, new List<string>());
            return true;
        }

        public bool WithdrawKey(string key)
        {
            return dictionary.Remove(key);
        }

    }
}
