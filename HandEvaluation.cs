using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame
{
    public partial class HandEvaluation : Form
    {
        public HandEvaluation(string player,string cpu)
        {
            InitializeComponent();
            CPUwinnings.Text = cpu;
            playerWinnings.Text = player;
        }

        private void HandEvaluation_Load(object sender, EventArgs e)
        {

        }
    }
}
