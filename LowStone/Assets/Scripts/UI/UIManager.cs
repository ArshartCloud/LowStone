using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instence;
        public Player User;

        public GameController gameController
        {
            get { return GameController.Instence; }
        }

        public UIClientManager PlayerUI;
        public UIOpponentManager OpponentUI;

        //public bool CanAct;
        public Dictionary<Card, UICard> UICardMap
        {
            get { return m_UICardMap; }
        }

        private Dictionary<Card, UICard> m_UICardMap = new Dictionary<Card, UICard>();

        void Awake()
        {
            Instence = this;
        }

        void Start()
        {
            //PlayerUI = new UIClientManager();
            //OpponentUI = new UIOpponentManager();
            EventDispatcher.AddEventListener<DrawEventData>(EventEnum.DrawCard, DrawCard);
            EventDispatcher.AddEventListener<StartGameEventData>(EventEnum.StartGame, StartGame);
            EventDispatcher.AddEventListener(EventEnum.EnterMainPhase, EnterMainTurn);
            EventDispatcher.AddEventListener<PlayEventData>(EventEnum.PlayMinion, PlayCard);
        }

        public void PlayerUseCard(UICard card) {
            gameController.UseCard(PlayerUI.Player, card.card);
        }

        public void UseCard(UICard card, int position) { PlayerUI.UseCard(card, position); }
        //public void UseCard(UICard card, UICard target) { }
        //public void UseCard(UICard card, int position, UICard target) { }

        public void Attack(UICard attacker, UICard defender) { PlayerUI.Attack(attacker, defender); }

        public void EndTurn() { }

        //public void DrawCard()
        //{
        //    PlayerUI.DrawCard();
        //}

        public void UseMinion(UICard minion)
        {
            PlayerUI.UseMinion(minion);
        }

        public UICard GetUICard(Card card)
        {
            //
            return new UICard();
        }

        public void LinkCard(Card card, UICard uic)
        {
            m_UICardMap.Add(card, uic);
        }

        public void Delink(Card card)
        {
            m_UICardMap.Remove(card);
        }

        private void DrawCard(DrawEventData data)
        {
            if (data.player == PlayerUI.Player)
            {
                PlayerUI.DrawCard(data.card);
            }
            //TODO else
        }

        private void StartGame(StartGameEventData data)
        {
            PlayerUI.Player = data.currentPlayer;
            User = data.currentPlayer;
        }

        private void EnterMainTurn()
        {
            if (gameController.currentPlayer == User)
            {
                //CanAct = true;
            }
        }

        private void PlayCard(PlayEventData data)
        {
            if (data.user == PlayerUI.Player)
            {
                //todo
                PlayerUI.PlayCard(data.card);
            }
        }


        private void EnterPlayerMainTurn() { }

        private void EnterOpponentMainTurn() { }
    }
}
