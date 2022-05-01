using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC21_KS_VegasBlackJack
{
    public partial class BlackJackForm : Form
    {
        public BlackJackForm()
        {
            InitializeComponent();
        }

        private void lossesLabel_Click(object sender, EventArgs e)
        {

        }

        private void BlackJackForm_Load(object sender, EventArgs e)
        {
            deckCountLabel.Text = "52";
            hitButton.Hide();
            dealButton.Show();
            deackPictureBox.Image = Properties.Resources.blank_red;

        }
    }
}
