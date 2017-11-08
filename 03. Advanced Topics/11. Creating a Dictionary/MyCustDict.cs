using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Creating_a_Dictionary
{
    public class MyCustDict
    {
        private List<string> words;
        private List<string> definitions;

        public MyCustDict()
        {
            this.words = new List<string>();
            this.definitions = new List<string>();
        }

        public string this[string word]
        {
            get
            {
                string result = LookupWord(word);
                if (result == null) { throw new KeyNotFoundException(word); }
                return result;
            }
            set
            {
                AddDefinition(word, value);
            }
        }

        public void AddDefinition(string word, string definition)
        {
            for (int index = 0; index < words.Count; index++)
            {
                if (words[index] == word)
                {
                     definitions[index] = definition;
                     return;
                }
            }
            words.Add(word);
            definitions.Add(definition);
        }

        private string LookupWord(string word)
        {
            for (int index = 0; index < words.Count; index++)
            {
                if (words[index] == word)
                {
                    return definitions[index];
                }
            }
            return null;
        }
    }
}
