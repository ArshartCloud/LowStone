using System;
using System.Collections.Generic;
using UnityEngine;

public class Player {
	public delegate void MessageHandler(string message);

    // Properties
    public Hand PlayerHand { get { return m_playerHand; } }
    public Deck PlayerDeck { get { return m_playerDeck; } }
    public Battlefield PlayerBattlefield { get { return m_playerBattlefield; } }
    public ManaZone PlayerMana { get { return m_playerMana; } }
    
    private Hand m_playerHand = new Hand();
    private Deck m_playerDeck = new Deck();
    private Battlefield m_playerBattlefield = new Battlefield();
    private ManaZone m_playerMana = new ManaZone();

    public void DrawCard()
    {
        Debug.Log(PlayerHand.Count);
        Debug.Log(PlayerHand.MaxSize);
        if (PlayerHand.Count < PlayerHand.MaxSize)
        {
            //TODO

            Debug.Log("Player draw a card.");
            Card card = PlayerDeck.Pop();
            PlayerHand.Add(card);
            DrawEventData data = new DrawEventData();
            data.player = this;
            data.card = card;

            //event
            EventDispatcher.TriggerEvent(EventEnum.DrawCard, data);
        } else
        {
            BurnCard();
        }
    }

    //TODO
    public void BurnCard() { }

    public void EnterMainTurn() { }

	public MessageHandler MessageHandlers {
		private get;
		set;
	}


	public void SendMessage(string message) {
		MessageHandlers(message);
	}


}
