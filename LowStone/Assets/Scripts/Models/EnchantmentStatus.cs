using UnityEngine;
using System.Collections;

namespace Lowstone.Model
{
    enum TriggerPhases
    {
        INVALID = 0,
        BEGIN_FIRST = 1,
        BEGIN_SHUFFLE = 2,
        BEGIN_DRAW = 3,
        BEGIN_MULLIGAN = 4,
        MAIN_BEGIN = 5,
        MAIN_READY = 6,
        MAIN_RESOURCE = 7,
        MAIN_DRAW = 8,
        MAIN_START = 9,
        MAIN_ACTION = 10,
        MAIN_COMBAT = 11,
        MAIN_END = 12,
        MAIN_NEXT = 13,
        FINAL_WRAPUP = 14,
        FINAL_GAMEOVER = 15,
        MAIN_CLEANUP = 16,
        MAIN_START_TRIGGERS = 17,
    }


    public class EnchantmentStatus
    {
        public string name { get; set; }
        public PlayerClass playerClass;
        public CardSet set;
        public string text;
    }
}
