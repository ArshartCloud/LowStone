using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone {
    public List<Card> Cards
    {
        get
        {
            return m_cards;
        }
        private set
        {
            m_cards = value;
        }
    }

    public int Count
    {
        get
        {
            return Cards.Count;
        }
    }

    public int MaxSize
    {
        get
        {
            return m_maxSize;
        }
    }

    protected List<Card> m_cards = new List<Card>();
    protected int m_maxSize = 0;

    public Zone() { }

    public virtual void Add(Card card)
    {
        Cards.Add(card);
    }

    public virtual void Insert(int index, Card card)
    {
        Cards.Insert(index, card);
    }

    public virtual bool Contains(Card card)
    {
        return Cards.Contains(card);
    }

    public virtual void Remove(Card card)
    {
        Cards.Remove(card);
    }

    public virtual bool IsFull()
    {
        return Count >= MaxSize;
    }

}
