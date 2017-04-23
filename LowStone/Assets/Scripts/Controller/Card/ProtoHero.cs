using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeroPower { }

public class ProtoHero : ProtoCard
{

    // properties
    public int Armor
    {
        get { return m_armor; }
    }

    public HeroPower Power
    {
        get { return m_power; }
    }

    // variables
    private int m_armor;
    private HeroPower m_power;

    // constructors

    // methods

}
