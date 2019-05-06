using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeckGuts : MonoBehaviour
{
    public enum SuitEnum {
        Monster=1,
        Items=2,
        Curse=3,
        Race=4,
        Class=5
    }
 
    public class Card {
        private SuitEnum _suit;
        private int _rank;
 
        public SuitEnum Suit { get { return _suit; } }
        public int Rank { get { return _rank; } }
 
        private GameObject _card;
 
        public Card(SuitEnum suit, int rank, Vector3 position, Quaternion rotation) {
            // to do: validate rank, position, and rotation
            string assetName = string.Format("Card_{0}_{1}", suit, rank);  // Example:  "Card_1_10" would be the Jack of Hearts.
            GameObject asset = GameObject.Find(assetName);
            if (asset == null) {
                Debug.LogError("Asset '" + assetName + "' could not be found.");
            } else {
                _card = Instantiate(asset, position, rotation);
                _suit = suit;
                _rank = rank;
            }
        }
    }
 
    public class Deck {
        private List<Card> _deck = new List<Card>();
        private List<Card> _discardPile = new List<Card>();
 
        public void Shuffle() {
            /* To Do */
        }
 
        public Card TakeCard() {
            if (_deck.Count == 0)
                return null; // the deck is depleted
       
            // take the first card off the deck and add it to the discard pile
            Card card = _deck[0];
            _deck.RemoveAt(0);
            _discardPile.Add(card);
 
            return card;
        }
 
        /* ...etc... */
    }
}
            
