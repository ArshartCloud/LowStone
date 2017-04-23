using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    Preparing,
    Running,
    Ending
}


public class GameController : MonoBehaviour {

    public GameState currentState;
    public Player currentPlayer;
    public List<Player> players = new List<Player>();
    static public GameController Instence;


    void Start()
    {
        Instence = this;
    }

    public void StartGame()
    {
        // add two test player
        players.Add(new Player());
        players.Add(new Player());

        SetPlayer(players[0]);
        
        BeginTurn();
    }

	public void BeginTurn()
    {
        //trigger beginTurn skill
        Debug.Log("A new turn begin");
        currentPlayer.DrawCard();

        currentPlayer.EnterMainTurn();
        EventDispatcher.TriggerEvent(EventEnum.EnterMainPhase);
    }



    public void EndTurn()
    {
        //trigger end turn skill

        //turn to next player
        
        BeginTurn();
    }

    //public void DrawCard(Player player)
    //{
    //    player.DrawCard();
    //}

    //public void DrawCard(Player player, int num)
    //{
    //    for (int i = 0; i < num; ++i)
    //    {
    //        DrawCard(player);
    //    }
    //}

    public void BurnCard(Player player) { }

    public void SetPlayer(Player player)
    {
        currentPlayer = player;
        StartGameEventData data = new StartGameEventData();
        data.currentPlayer = currentPlayer;
        EventDispatcher.TriggerEvent(EventEnum.StartGame, data);
    }

    public bool CanUse(Player user, Card card)
    {
        if (!user.PlayerHand.Contains(card))
        {
            Debug.Log("Not in hand");
            return false;
        }
        if (user.PlayerMana.Mana < card.ManaCost)
        {
            Debug.Log("Not enough Mana");
            return false;
        }
        if (card.Type == CardType.Minion)
        {
            return CanUseMinion(user, card);
        }
        return true;
    }

    public void UseCard(Player user, Card card) {
        if (card.Type == CardType.Minion)
        {
            PlayMinion(user, card);
        }
    }

    public void PlayMinion(Player user, Card card)
    {
        user.PlayerHand.Remove(card);
        user.PlayerBattlefield.Add(card);
        PlayEventData data = new PlayEventData();
        data.user = user;
        data.card = card;
        data.position = 0;
        EventDispatcher.TriggerEvent(EventEnum.PlayMinion, data);
        // trigger onplay
        // trigger battlecry
        // trigger after play(skip death)
        // trigger after summon
        // check win
    }

    public bool CanUseMinion(Player user, Card card)
    {
        if (user.PlayerBattlefield.IsFull())
        {
            Debug.Log("No place for more minion");
            return false;
        }
        return true;
    }
}
