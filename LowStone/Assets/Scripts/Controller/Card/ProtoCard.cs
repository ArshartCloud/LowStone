using System;
using System.Collections.Generic;

public enum PlayerClass { }
public enum Rarity { }
public enum CardSet { }
public enum Enchantment { }
public class Operation { };

    
public enum CardType
{
    Minion,
    Spell,
    Weapon
}

public abstract class ProtoCard
{
	// properties
	public int Cost {
		get { return m_cost; }
	}

    public CardType Type
    {
        get { return m_type; }
    }

    public string Name
    {
        get { return m_name; }
    }

    public PlayerClass cardClass
    {
        get { return m_cardClass; }
    }

    public Rarity CardRarity
    {
        get { return m_cardRarity; }
    }

    public string Text
    {
        get { return m_text; }
    }

    public CardSet Set
    {
        get { return m_set; }
    }

    public Enchantment Skill
    {
        get { return m_skill; }
    }

    public List<Operation> BeforePlay
    {
        get { return m_beforePlay; }
    }

    // variables
    protected int m_cost;
    protected CardType m_type;
    protected string m_name;
    protected PlayerClass m_cardClass;
    protected Rarity m_cardRarity;
    protected string m_text;
    protected CardSet m_set;
    protected Enchantment m_skill;
    protected List<Operation> m_beforePlay;

	// constructors
	//public ProtoCard(int cost) {
	//	m_cost = cost < 0 ? 0 : cost;
	//}

	// methods
	//public abstract Card CreateCard();

}
