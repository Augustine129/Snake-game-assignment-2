using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class NewGameForm : Form
    {
        // A reference to a delegate that will be called when a new game is created.
        private readonly GameHandler handler;

        public NewGameForm(GameHandler handler)
        {
            InitializeComponent();

            this.handler = handler;
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

            SwitchMarkers(buttonMarkPlayer1);
            SwitchMarkers(buttonMarkPlayer2);
        }

        private void buttonMarkPlayer2_Click(object sender, EventArgs e)
        {
            // When the player 2 marker is clicked, switch markers.

            SwitchMarkers(buttonMarkPlayer2);
            SwitchMarkers(buttonMarkPlayer1);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // Collect the characteristics of the first player.
            var name1 = namePlayer1.Text == "" ? "Player 1" : namePlayer1.Text;
            var mark1 = buttonMarkPlayer1.Text;
            var color1 = buttonMarkPlayer1.ForeColor;

            // Collect the characteristics of the second player.
            var name2 = namePlayer2.Text == "" ? "Player 2" : namePlayer2.Text;
            var mark2 = buttonMarkPlayer2.Text;
            var color2 = buttonMarkPlayer2.ForeColor;
            var isComputer = computerCheckbox.Checked;

            // Create new player objects and assign references.
            var player1 = new Player(name1, color1, mark1);
            var player2 = new Player(name2, color2, mark2, isComputer);

            // Call the delegate and pass the two player references.
            handler(player1, player2);

            // Close the form.
            Close();
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            // When the form loads apply the blue and red style to the markers.

            ApplyBlueStyle(buttonMarkPlayer1);
            ApplyRedStyle(buttonMarkPlayer2);
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
