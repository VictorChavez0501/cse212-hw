using System.Collections.Generic;

public class Translator
{
    private Dictionary<string, string> dictionary;

    public Translator()
    {
        dictionary = new Dictionary<string, string>();
    }

    // Add a word and its translation
    public void AddWord(string fromWord, string toWord)
    {
        // If it already exists, it replaces it (this is valid according to instructions)
        dictionary[fromWord] = toWord;
    }

    // Translate a word
    public string Translate(string word)
    {
        // Check if the word exists
        if (dictionary.ContainsKey(word))
        {
            return dictionary[word];
        }

        // If it does not exist, it returns ???
        return "???";
    }
}