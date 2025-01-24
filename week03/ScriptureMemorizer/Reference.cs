public class Reference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int StartVerse { get; private set; }
        public int EndVerse { get; private set; }

        public Reference(string book, int chapter, int startVerse, int endVerse = 0)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse == 0 ? startVerse : endVerse;
        }

        public override string ToString()
        {
            return EndVerse == StartVerse
                ? $"{Book} {Chapter}:{StartVerse}"
                : $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }