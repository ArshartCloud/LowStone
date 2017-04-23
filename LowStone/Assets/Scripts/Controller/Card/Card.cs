using System;
using System.Collections.Generic;

public class Card {
    // properties
    public ProtoCard Prototype
    {
        get { return m_prototype; }
        protected set { m_prototype = value; }
    }

    public int OriginalCost
    {
        get { return Prototype.Cost; }
    }

    public string Name
    {
        get { return m_name; }
    }

    public CardType Type
    {
        get { return Prototype.Type; }
    }

    public PlayerClass CardClass
    {
        get { return m_cardClass; }
    }

    public Rarity CardRarity
    {
        get { return m_cardRarity; }
    }

    public Enchantment Skill
    {
        get { return m_skill; }
    }

    public string Text
    {
        get { return m_text; }
    }

    public int ManaCost
    {
        // test
        get { return OriginalCost; }
    }

    public CardSet Set
    {
        get { return m_set; }
    }

    public List<Enchantment> Enchantment
    {
        get { return m_enchantments; }
    }

    public Player Controller
    {
        get { return m_controller; }
    }

    public Card Creator
    {
        get { return m_creator; }
    }

    // variables
    private ProtoCard m_prototype;
    private string m_name;
    private CardType m_type;
    private PlayerClass m_cardClass;
    private Rarity m_cardRarity;
    private Enchantment m_skill;
    private string m_text;
    private CardSet m_set;
    private List<Enchantment> m_enchantments;
    private Player m_controller;
    private Card m_creator;

    // constructors
    //not use
    public Card(int password) {
    }

    public static Card GetNewCard()
    {
        // example
        return new Minion(new ProtoMinion());
    }

    public Card(ProtoCard prototype)
    {
        m_prototype = prototype;
        Reset();
    }

    // methods
    public virtual void Copy(Card other)
    {
        Prototype = other.Prototype;
        Reset();
    }

    public virtual void Reset()
    {
    }

}
