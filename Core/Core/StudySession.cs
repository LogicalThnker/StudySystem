using StudySystem.Core.JCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySystem.Core
{
    public class StudySession
    {
        public Deck CurrentDeck { get; private set; }
        public int CurrentCardIndex { get; private set; } = 0;

        public Card CurrentCard
        {
            get
            {
                if (CurrentDeck == null || CurrentDeck.Cards.Count == 0)
                    return null;
                return CurrentDeck.Cards[CurrentCardIndex];
            }
        }

        public void StartDeck(Deck deck)
        {
            if (deck == null || deck.Cards.Count == 0)
                return;
            CurrentDeck = deck;
            CurrentCardIndex = 0;
        }

        public void NextCard()
        {
            if (CurrentDeck == null || CurrentDeck.Cards.Count == 0)
                return;
            CurrentCardIndex++;
            if (CurrentCardIndex >= CurrentDeck.Cards.Count)
                CurrentCardIndex = 0;
        }

        public bool ToggleResult(Card.CardResult result)
        {
            if (CurrentCard == null)
            {
                return false;
            }
            if (CurrentCard.LastResult == result)
            {
                CurrentCard.LastResult = null;
                return false;
            }
            CurrentCard.LastResult = result;
            return true;
        }

    }
}
