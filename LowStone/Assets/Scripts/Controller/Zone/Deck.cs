using System.Collections;
using System.Collections.Generic;

public class Deck:Zone {

    public Deck()
    {
        m_maxSize = 60;
        for (int i = 0; i < 30; ++i)
        {
            Cards.Add(Card.GetNewCard());
        }
    }

    //TEST TODO
    public Card Pop()
    {
        Card top = Cards[0];
        Cards.RemoveAt(0);
        return top;
    }
}
