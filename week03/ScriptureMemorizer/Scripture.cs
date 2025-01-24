public class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> Words { get; set; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords()
        {
            Random random = new Random();
            List<Word> visibleWords = Words.Where(word => !word.IsHidden).ToList();

            int wordsToHide = Math.Min(3, visibleWords.Count);
            for (int i = 0; i < wordsToHide; i++)
            {
                int randomIndex = random.Next(visibleWords.Count);
                visibleWords[randomIndex].Hide();
                visibleWords.RemoveAt(randomIndex);
            }
        }

        public bool IsFullyHidden()
        {
            return Words.All(word => word.IsHidden);
        }

        public string GetFormattedScripture()
        {
            string formattedText = string.Join(' ', Words);
            return $"{Reference}\n{formattedText}";
        }
    }
