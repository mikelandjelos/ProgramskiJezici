using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PripremaZad3_Dictionary
{
    internal class TranslationPair
    {

        public string engWord;
        public List<string> translationsList;

        public TranslationPair(string _engWord)
        { 
            engWord = _engWord;
            translationsList = new List<string>();
        }

        public TranslationPair(string _engWord, string[] _translationList)
            : this(_engWord)
        { 
            if (_translationList != null)
                translationsList.AddRange(_translationList);
        }

        public TranslationPair(string _engWord, List<string> _translationList)
            : this(_engWord, _translationList?.ToArray())
        { }

        // key je read-only svojstvo naseg hash objekta
        public string Key
        { 
            get { return engWord; }
        }

        public string NewTranslation
        { 
            set { translationsList.Add(value); }
        }

        public bool TranslationExists(string _translation)
        {
            return translationsList.Contains(_translation);
        }

        public bool RemoveTranslation(string _translation)
        {
            return translationsList.Remove(_translation);
        }

    }
}
