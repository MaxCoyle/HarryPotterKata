using System.Collections.Generic;

namespace HarryPotterLogic
{
    public class HarryPotterService
    {
        public List<BookSet> BookSets { get; }

        public HarryPotterService()
        {
            BookSets = new List<BookSet>();
        }

        public void AddBookToBasket(string bookName)
        {
            if (AddBookToExistingBookset(bookName)) return;
            AddBookToNewBookSet(bookName);
        }

        private bool AddBookToExistingBookset(string bookName)
        {
            var bookAddedToExistingBookset = false;

            foreach (var bookSet in BookSets)
            {
                if (bookSet.Books.Contains(bookName)) continue;
                bookSet.Books.Add(bookName);
                bookAddedToExistingBookset = true;
                break;
            }

            return bookAddedToExistingBookset;
        }

        private void AddBookToNewBookSet(string bookName)
        {
            var newBookSet = new BookSet();
            newBookSet.Books.Add(bookName);
            BookSets.Add(newBookSet);
        }

        public decimal BasketTotal => GetBasketTotal();

        private decimal GetBasketTotal()
        {
            decimal basketTotal = 0;

            foreach (var bookSet in BookSets)
            {
                basketTotal = basketTotal + bookSet.Total;
            }

            return basketTotal;
        }
    }
}
