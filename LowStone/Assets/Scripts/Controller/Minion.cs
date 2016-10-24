using System;

public class Minion : Card {
	// properties
	public new MinionPrototype Prototype {
		get { return (MinionPrototype)base.Prototype; }
		protected set { base.Prototype = value; }
	}

	public int OriginalAttack {
		get { return Prototype.Attack; }
	}

	public int OriginalHealth {
		get { return Prototype.Health; }
	}

	public int CurrentHealth {
		get { return m_currentHealth; }
	}

	// variables
	private int m_currentHealth;

	// constructors
	public Minion(MinionPrototype prototype) : base(prototype) {
	}

	// methods
	public void TransformTo(Minion other) {
		Copy(other);
	}

	public void TransformTo(MinionPrototype new_prototype) {
		Prototype = new_prototype;
		Reset();
	}

	public override void Copy(Card other) {
	}

	public void CopyMinion(Minion other) {
		base.Copy(other);
	}
	
}
