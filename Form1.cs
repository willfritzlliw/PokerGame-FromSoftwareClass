using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardLogic;

namespace PokerGame
{
    public partial class Cards : Form
    {
        private int _cardSwitches = 0;

        //allows for only 1 card switch per card location
        private bool _cardUsed1 = false;
        private bool _cardUsed2 = false;
        private bool _cardUsed3 = false;
        private bool _cardUsed4 = false;
        private bool _cardUsed5 = false;
        private bool _showHandEval = true;
        private GetCards CardSetup = new GetCards();
        private Betting bet = new Betting();
        int betAmt = 0;


        public Cards()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CardSetup.CardSetup();
            ShowYourCards();
            betAmt = 500;
            PlayerCash.Text = bet.PlayerCash.ToString();
            DealerCash.Text = bet.CPUCash.ToString();
        }

        //Converts card to string representation for resx file
        private string ConvertCard(Card myCard)
        {
            string cardName = myCard.Face.ToString();
            cardName += "_of_";
            cardName += myCard.Suit.ToString();
            return cardName;
        }
        private void ShowYourCards()
        {
            //your cards
            yourCard1.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.yourCards[0]));
            yourCard2.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.yourCards[1]));
            yourCard3.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.yourCards[2]));
            yourCard4.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.yourCards[3]));
            yourCard5.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.yourCards[4]));
        }
        private void ShowDealerCards()
        {
            //dealer cards
            dealersCard1.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.dealerCards[0]));
            dealersCard2.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.dealerCards[1]));
            dealersCard3.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.dealerCards[2]));
            dealersCard4.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.dealerCards[3]));
            dealersCard5.Image = (Image)CardsResource.ResourceManager.GetObject(ConvertCard(CardSetup.dealerCards[4]));
        }
        private void clearDealerCards()
        {
            //dealer cards
            dealersCard1.Image = null;
            dealersCard2.Image = null;
            dealersCard3.Image = null;
            dealersCard4.Image = null;
            dealersCard5.Image = null;
        }

        //checks who won
        private void checkHand_Click(object sender, EventArgs e)
        {
            Points getPoints = new Points(CardSetup.yourCards, CardSetup.dealerCards);
            txtWinner.Text = getPoints.returnWinner();
            HandEvaluation handEval = new HandEvaluation(getPoints.PlayersWinnings,getPoints.CPUWinnings);
            if (_showHandEval)
            {
                handEval.Show();
            }

            ShowDealerCards();
            NewGame.Visible = true;
            NewGame.Enabled = true;
            bet.WhoWins(getPoints.PlayerWins, getPoints.CPUWins, betAmt, betAmt);
            if (bet.PlayerWinsGame == true)
            {
                GameWinner.Text = "Player Wins!!";
                NewGameBtn.Visible = true;
                NewGameBtn.Enabled = true;
            }
            else if(bet.CPUWinsGame == true)
            {
                GameWinner.Text = "CPU Wins!!";
                NewGameBtn.Visible = true;
                NewGameBtn.Enabled = true;
            }
        }

        //sets up new hand
        private void NewGame_Click(object sender, EventArgs e)
        {
            CardSetup.NewDeck();
            txtWinner.Text = null;
            ShowYourCards();
            clearDealerCards();
            NewGame.Visible = false;
            NewGame.Enabled = false;
            _cardSwitches = 0;
            _cardUsed1 = false;
            _cardUsed2 = false;
            _cardUsed3 = false;
            _cardUsed4 = false;
            _cardUsed5 = false;
            betAmt = 500;
            WarningLbl.Text = "";
            PlayerCash.Text = bet.PlayerCash.ToString();
            DealerCash.Text = bet.CPUCash.ToString();
            Placebet.Enabled = true;
        }

        //tests if hand Evaluation is shown
        private void showHandEval_CheckedChanged(object sender, EventArgs e)
        {
            if (showHandEval.Checked)
            {
                _showHandEval = true;
            }
            else
            {
                _showHandEval = false;
            }
        }

        //Places bet
        private void button2_Click(object sender, EventArgs e)
        {
            int addedBet;

            if (int.TryParse(BetingAmt.Text, out addedBet) && addedBet <= bet.PlayerCash)
            {
                WarningLbl.Text = "Bet Has been Placed";
                betAmt += addedBet;
                Placebet.Enabled = false;
            }
            else
            {
                WarningLbl.Text = "You must enter a whole number that doesnt exceed the amount of cash you have";
            }
        }

        //New Game
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            CardSetup.NewDeck();
            txtWinner.Text = null;
            ShowYourCards();
            clearDealerCards();
            NewGame.Visible = false;
            NewGame.Enabled = false;
            _cardSwitches = 0;
            _cardUsed1 = false;
            _cardUsed2 = false;
            _cardUsed3 = false;
            _cardUsed4 = false;
            _cardUsed5 = false;
            betAmt = 500;
            WarningLbl.Text = "";
            bet = new Betting();
            GameWinner.Text = "";
            NewGameBtn.Visible = false;
            NewGameBtn.Enabled = false;
            PlayerCash.Text = bet.PlayerCash.ToString();
            DealerCash.Text = bet.CPUCash.ToString();
        }


        //****************************Card Swaping******************************//
        private void yourCard1_Click(object sender, EventArgs e)
        {
            if(_cardSwitches < 3 && _cardUsed1 == false)
            { 
                CardSetup.ChangeYourCard(0);
                ShowYourCards();
                _cardUsed1 = true;
                _cardSwitches++;
            }

            
        }

        private void yourCard2_Click(object sender, EventArgs e)
        {
            if (_cardSwitches < 3 && _cardUsed2 == false)
            {
                CardSetup.ChangeYourCard(1);
                ShowYourCards();
                _cardUsed2 = true;
                _cardSwitches++;
            }

            
        }

        private void yourCard3_Click(object sender, EventArgs e)
        {
            if (_cardSwitches < 3 && _cardUsed3 == false)
            {
                CardSetup.ChangeYourCard(2);
                ShowYourCards();
                _cardUsed3 = true;
                _cardSwitches++;
            }

            
        }

        private void yourCard4_Click(object sender, EventArgs e)
        {
            if (_cardSwitches < 3 && _cardUsed4 == false)
            {
                CardSetup.ChangeYourCard(3);
                ShowYourCards();
                _cardUsed4 = true;
                _cardSwitches++;
            }

            
        }

        private void yourCard5_Click(object sender, EventArgs e)
        {
            if (_cardSwitches < 3 && _cardUsed5 == false)
            {
                CardSetup.ChangeYourCard(4);
                ShowYourCards();
                _cardUsed5 = true;
                _cardSwitches++;
            }

            
        }

    }
}
