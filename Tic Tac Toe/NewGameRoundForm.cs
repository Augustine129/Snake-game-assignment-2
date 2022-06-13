using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class NewGameForm : Form
    {
        // A reference to a delegate that will be called when a new game is created.
        private readonly GameHandler _handler;

        public NewGameForm(GameHandler handler)
        {
            InitializeComponent();

            this._handler = handler;
        }

        private static void ApplyBlueStyle(Control button)
        {
            // Apply the styles of a blue marker to a specific button.

            button.ForeColor = Color.Blue;
            button.Text = @"X";
        }

        private void ApplyRedStyle(Button button)
        {
            // Apply the styles of a red marker to a specific button.

            button.ForeColor = Color.Red;
            button.Text = @"O";
        }

        private void buttonMarkPlayer1_Click(object sender, EventArgs e)
        {
            // When the player 1 marker is clicked, switch markers.

            SwitchMarkers(_buttonMarkPlayerOne);
            SwitchMarkers(_buttonMarkPlayerTwo);
        }

        private void buttonMarkPlayer2_Click(object sender, EventArgs e)
        {
            // When the player 2 marker is clicked, switch markers.

            SwitchMarkers(_buttonMarkPlayerTwo);
            SwitchMarkers(_buttonMarkPlayerOne);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // Collect the characteristics of the first player.
            var name1 = _namePlayerOne.Text == "" ? "Player 1" : _namePlayerOne.Text;
            var mark1 = _buttonMarkPlayerOne.Text;
            var color1 = _buttonMarkPlayerOne.ForeColor;

            // Collect the characteristics of the second player.
            var name2 = _namePlayerTwo.Text == "" ? "Player 2" : _namePlayerTwo.Text;
            var mark2 = _buttonMarkPlayerTwo.Text;
            var color2 = _buttonMarkPlayerTwo.ForeColor;
            var isComputer = _computerCheckbox.Checked;

            // Create new player objects and assign references.
            var player1 = new Player(name1, color1, mark1);
            var player2 = new Player(name2, color2, mark2, isComputer);

            // Call the delegate and pass the two player references.
            _handler(player1, player2);

            // Close the form.
            Close();
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            // When the form loads apply the blue and red style to the markers.

            ApplyBlueStyle(_buttonMarkPlayerOne);
            ApplyRedStyle(_buttonMarkPlayerTwo);
        }

        private void SwitchMarkers(Button button)
        {
            if (button.ForeColor == Color.Blue)
            {
                // If the button is blue, then switch to a red marker.

                ApplyRedStyle(button);
            }
            else
            {
                // If the button is red, then switch to a blue marker.

                ApplyBlueStyle(button);
            }
        }
    }
}
