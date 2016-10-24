using System;

public abstract class CardPrototype {
	// properties
	public int Cost {
		get { return m_cost; }
	}

	// variables
	private int m_cost;

	// constructors
	public CardPrototype(int cost) {
		m_cost = cost < 0 ? 0 : cost;
	}

	// methods
	public abstract Card CreateCard();

}
