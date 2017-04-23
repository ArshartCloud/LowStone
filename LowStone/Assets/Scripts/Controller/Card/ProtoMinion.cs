using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoMinion : ProtoCharacter
{

    private CardType m_type = CardType.Minion;

    public ProtoMinion()
    {
        m_attack = 1;
        m_health = 1;
        m_cost = 1;
    }
    
}
