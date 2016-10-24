using System;
using System.Collections.Generic;

public class Board {
	public delegate void MessageHandler(string message);

	// Properties
	public MessageHandler MessageHandlers {
		private get;
		set;
	}

	public Player Player1 {
		get { return m_player1; }
	}

	public Player Player2 {
		get { return m_player2; }
	}

	// variables
	private Player m_player1 = new Player();
	private Player m_player2 = new Player();

	// methods
	public void SendMessage(string message) {
		MessageHandlers(message);
    }

	public void SendGlobalMessage(string message) {
		SendMessage(message);
		Player1.SendMessage(message);
		Player2.SendMessage(message);
	}

}
