using System;
using System.Collections.Generic;

public abstract class Card {
	// properties
	public CardPrototype Prototype {
		get { return m_prototype; }
		protected set { m_prototype = value; }
	}

	public int OriginalCost {
		get { return Prototype.Cost; }
	}

	// variables
	private CardPrototype m_prototype;

	// constructors
	public Card(CardPrototype prototype) {
		m_prototype = prototype;
		Reset();
    }

	// methods
	public virtual void Copy(Card other) {
		Prototype = other.Prototype;
		Reset();
	}

	public virtual void Reset() {
	}

}
