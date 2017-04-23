using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Race { }

public class ProtoCharacter : ProtoCard {

    // properties
    public int Attack
    {
        get { return m_attack; }
    }

    public int Health
    {
        get { return m_health; }
    }

    public Race CareRace
    {
        get { return m_cardrace;}
    }

    // variables
    protected int m_attack;
    protected int m_health;
    protected Race m_cardrace;

    // constructors

    // methods

}
