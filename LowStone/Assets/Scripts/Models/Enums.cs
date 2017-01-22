using UnityEngine;
using System.Collections;

namespace Lowstone.Model
{
    public enum CardType
    {
        Invalid,
        Hero,
        Minion,
        Spell,
        Weapon,
        HeroPower,
    }

    public enum PlayerClass
    {
        Invalid,
        Neutral,
        Druid,
        Hunter,
        Mage,
        Paladin,
        Priest,
        Rogue,
        Shaman,
        Warlock,
        Warrior,
        Dream,
    }

    public enum Rarity
    {
        Invalid,
        Basic,
        Common,
        Rare,
        Epic,
        Legendary,
    }

    public enum CardSet
    {
        Invalid,
        Core,
        Expert,
        Reward,
        NAXX,
        GVG,
        BRM,
        TGT,
        LOE,
        WOG,
        KARA,
    }
}
