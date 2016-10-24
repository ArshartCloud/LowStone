using System;

public class MinionPrototype : CardPrototype {
	// properties
	public int Attack {
		get { return m_attack; }
	}

	public int Health {
		get { return m_health; }
	}

	// variables
	private int m_attack;
	private int m_health;

	// constructors
	public MinionPrototype(int cost, int attack, int health) : base(cost) {
		m_attack = attack;
		m_health = health;
	}

	// methods
	public override Card CreateCard() {
		return CreateMinion();
	}

	public Minion CreateMinion() {
		return new Minion(this);
	}

}
