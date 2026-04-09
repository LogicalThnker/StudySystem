using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudySystem.Core.JCard;
using System.IO;
using Newtonsoft.Json;

namespace StudySystem.Core.JCard
{
    public class DeckIO
    {
        public Deck ReadDeck(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Deck>(json);
        }

        public void WriteDeck(Deck deck, string filePath)
        {
            string json = JsonConvert.SerializeObject(deck, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public string GetDecksFolder()
        {
            string baseFolder = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "StudySystem");
            string folder = System.IO.Path.Combine(baseFolder, "Decks");
            Directory.CreateDirectory(folder);
            return folder;
        }

        public void SaveAllDecks(List<Deck> decks)
        {
            string folder = GetDecksFolder();
            Directory.CreateDirectory(folder);

            foreach (var deck in decks)
            {
                string fileName = deck.Name.Replace(" ", "") + ".jcard";
                fileName = fileName.Replace("_", "");
                string path = System.IO.Path.Combine(folder, fileName);
                WriteDeck(deck, path);
            }
        }

        public List<Deck> LoadAllDecks()
        {
            List<Deck> _decks = new List<Deck>();
            string folder = GetDecksFolder();
            if (!Directory.Exists(folder))
            {
                return _decks;
            }
            var files = Directory.GetFiles(folder, "*.jcard");
            foreach (var file in files)
            {
                Deck deck = ReadDeck(file);
                if (deck != null)
                {
                    _decks.Add(deck);
                }
            }
            return _decks;
        }
    }
}
