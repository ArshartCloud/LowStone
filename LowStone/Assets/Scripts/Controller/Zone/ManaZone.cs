using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaZone {
    public int Mana
    {
        get { return m_mana - m_overloaded; }
    }

    public int ManaCrystal
    {
        get { return m_manaCrystal; }
        set { m_manaCrystal = value;}
    }

    public int Overloaded
    {
        get { return m_overloaded; }
        set { m_overloaded = value; }
    }

    public int OverloadedNextTurn
    {
        get { return m_overloadedNextTurn; }
        set { m_overloadedNextTurn = value; }
    }

    private int m_manaCrystal;
    private int m_mana;
    private int m_overloaded;
    private int m_overloadedNextTurn;

    public void Consumue(int m)
    {
        m_mana -= m;
    }
}
