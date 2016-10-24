using System;

public class Player {
	public delegate void MessageHandler(string message);

	// Properties
	public MessageHandler MessageHandlers {
		private get;
		set;
	}

	public void SendMessage(string message) {
		MessageHandlers(message);
	}

}
