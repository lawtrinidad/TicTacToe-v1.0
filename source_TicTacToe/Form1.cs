namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int playerturn = 0; //determines visible buttons, turn-selection for AI in Single-Player Mode, and win condition message.
        bool isSinglePlayer = false;    //is for disabling or enabling AI to respond to every button click.
        public Form1()
        {
            InitializeComponent();
            var result = MessageBox.Show("Welcome to Tic Tac Toe!\r \nWould you like to play PVP?\r \nClicking 'Yes' will open the two-player game mode. 'No' will open a single-player gamemode against a bot.", "Tic Tac Toe The Game v1.0", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Player X goes first. Player O is next.");
            }
            if (result == DialogResult.No)
            {
                isSinglePlayer = true;  //turns on AI

                Random rnd = new Random();
                int firstturn = rnd.Next(9);
                playerturn = +firstturn;
                if (playerturn%2 == 0)
                {
                    MessageBox.Show("Bot is Player X. It goes first.");
                    AI();
                }
                else
                {
                    MessageBox.Show("Bot is Player O. You go first.");
                    playerturn += 1;
                }
                
            }
        }

        //WARNING: This code is "WET". Will update once I get better at coding. Sorry.

        private void TurnDeterminer()
        {
            playerturn += 1;
            if ((playerturn % 2) != 0)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                button17.Visible = true;
                button18.Visible = true;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " X";
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 30, FontStyle.Bold);
            button1.Enabled = false;
            button18.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = " X";
            richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, 30, FontStyle.Bold);
            button2.Enabled = false;
            button17.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " O";
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 30, FontStyle.Bold);
            button1.Enabled = false;
            button18.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            richTextBox2.Text = " O";
            richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, 30, FontStyle.Bold);
            button2.Enabled = false;
            button17.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = " X";
            richTextBox3.Font = new Font(richTextBox3.Font.FontFamily, 30, FontStyle.Bold);
            button3.Enabled = false;
            button16.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = " O";
            richTextBox3.Font = new Font(richTextBox3.Font.FontFamily, 30, FontStyle.Bold);
            button3.Enabled = false;
            button16.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = " X";
            richTextBox4.Font = new Font(richTextBox4.Font.FontFamily, 30, FontStyle.Bold);
            button4.Enabled = false;
            button15.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = " O";
            richTextBox4.Font = new Font(richTextBox4.Font.FontFamily, 30, FontStyle.Bold);
            button4.Enabled = false;
            button15.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox5.Text = " X";
            richTextBox5.Font = new Font(richTextBox5.Font.FontFamily, 30, FontStyle.Bold);
            button5.Enabled = false;
            button14.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox5.Text = " O";
            richTextBox5.Font = new Font(richTextBox5.Font.FontFamily, 30, FontStyle.Bold);
            button5.Enabled = false;
            button14.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = " X";
            richTextBox6.Font = new Font(richTextBox6.Font.FontFamily, 30, FontStyle.Bold);
            button6.Enabled = false;
            button13.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = " O";
            richTextBox6.Font = new Font(richTextBox6.Font.FontFamily, 30, FontStyle.Bold);
            button6.Enabled = false;
            button13.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox7.Text = " X";
            richTextBox7.Font = new Font(richTextBox7.Font.FontFamily, 30, FontStyle.Bold);
            button7.Enabled = false;
            button12.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox7.Text = " O";
            richTextBox7.Font = new Font(richTextBox7.Font.FontFamily, 30, FontStyle.Bold);
            button7.Enabled = false;
            button12.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox8.Text = " X";
            richTextBox8.Font = new Font(richTextBox8.Font.FontFamily, 30, FontStyle.Bold);
            button8.Enabled = false;
            button11.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox8.Text = " O";
            richTextBox8.Font = new Font(richTextBox8.Font.FontFamily, 30, FontStyle.Bold);
            button8.Enabled = false;
            button11.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox9.Text = " X";
            richTextBox9.Font = new Font(richTextBox9.Font.FontFamily, 30, FontStyle.Bold);
            button9.Enabled = false;
            button10.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox9.Text = " O";
            richTextBox9.Font = new Font(richTextBox9.Font.FontFamily, 30, FontStyle.Bold);
            button9.Enabled = false;
            button10.Enabled = false;
            Wincondition();
            TurnDeterminer();
            AI();
        }

        private void Wincondition()
        {
            //Horizontal Condition
            if (((richTextBox1.Text == richTextBox2.Text) && (richTextBox2.Text == richTextBox3.Text) && (richTextBox2.Text != "")) || ((richTextBox4.Text == richTextBox5.Text) && (richTextBox5.Text == richTextBox6.Text) && (richTextBox5.Text != "")) || ((richTextBox7.Text == richTextBox8.Text) && (richTextBox8.Text == richTextBox9.Text) && (richTextBox8.Text != "")))
            {
                //old condition:    if (((richTextBox1.Text == richTextBox2.Text) && (richTextBox2.Text == richTextBox3.Text) && (richTextBox2.Text != "") && (richTextBox1.Text == " X")) || ((richTextBox4.Text == richTextBox5.Text) && (richTextBox5.Text == richTextBox6.Text) && (richTextBox5.Text != "") && (richTextBox4.Text == " X")) || ((richTextBox7.Text == richTextBox8.Text) && (richTextBox8.Text == richTextBox9.Text) && (richTextBox8.Text != "") && (richTextBox7.Text == " X")))
                if ((playerturn % 2) == 0)
                {
                    var winner = "X";

                    var result = MessageBox.Show("Congratulations! " + "Player " + winner + " wins.\n" + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    var winner = "O";

                    var result = MessageBox.Show("Congratulations! " + "Player " + winner + " wins.\n" + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

            //Vertical Condition
            if (((richTextBox1.Text == richTextBox4.Text) && (richTextBox4.Text == richTextBox7.Text) && (richTextBox4.Text != "")) || ((richTextBox2.Text == richTextBox5.Text) && (richTextBox5.Text == richTextBox8.Text) && (richTextBox5.Text != "")) || ((richTextBox3.Text == richTextBox6.Text) && (richTextBox6.Text == richTextBox9.Text) && (richTextBox6.Text != "")))
            {
                if ((playerturn % 2) == 0)
                {
                    var winner = "X";

                    var result = MessageBox.Show("Congratulations! " + "Player " + winner + " wins.\n" + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    var winner = "O";

                    var result = MessageBox.Show("Congratulations! " + "Player " + winner + " wins.\n" + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

            //Diagonal Condition
            if (((richTextBox1.Text == richTextBox5.Text) && (richTextBox5.Text == richTextBox9.Text) && (richTextBox5.Text != "")) || ((richTextBox3.Text == richTextBox5.Text) && (richTextBox5.Text == richTextBox7.Text) && (richTextBox5.Text != "")))
            {
                if ((playerturn % 2) == 0)
                {
                    var winner = "X";

                    var result = MessageBox.Show("Congratulations! " + "Player " + winner + " wins.\n" + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                        Environment.Exit(0); //this finally fixes the bug where application.restart opens the program twice in SOME conditions. 
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    var winner = "O";

                    var result = MessageBox.Show("Congratulations! " + "Player " + winner + " wins.\n" + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            //Draw Condition
            if ((richTextBox1.Text != "") && (richTextBox2.Text != "") && (richTextBox3.Text != "") && (richTextBox4.Text != "") && (richTextBox5.Text != "") && (richTextBox6.Text != "") && (richTextBox7.Text != "") && (richTextBox8.Text != "") && (richTextBox9.Text != ""))   //really janky code. I know there's a better way to check all textboxes using the foreach command, but I couldm't make it work yet.
            {
                var result = MessageBox.Show("It's a draw!\n" + "\nBetter luck next time.\n" + "\nWould you like to play again?", "Good Game", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    this.Close();
                }
            }

        }

        private void AI()
        {
            if (isSinglePlayer == true)
            {
                string AIplayer = " O";
                if ((playerturn % 2) == 0)
                {
                    AIplayer = " X";
                    if (richTextBox5.Text == "")
                    {
                        richTextBox5.Text = AIplayer;
                        richTextBox5.Font = new Font(richTextBox5.Font.FontFamily, 30, FontStyle.Bold);
                        button14.Enabled = false;
                    }
                    else
                    {
                        if (richTextBox2.Text == "")
                        {
                            richTextBox2.Text = AIplayer;
                            richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, 30, FontStyle.Bold);
                            button17.Enabled = false;
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                richTextBox1.Text = AIplayer;
                                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 30, FontStyle.Bold);
                                button18.Enabled = false;
                            }
                            else
                            {
                                if (richTextBox7.Text == "")
                                {
                                    richTextBox7.Text = AIplayer;
                                    richTextBox7.Font = new Font(richTextBox7.Font.FontFamily, 30, FontStyle.Bold);
                                    button12.Enabled = false;
                                }
                                else
                                {
                                    if (richTextBox3.Text == "")
                                    {
                                        richTextBox3.Text = AIplayer;
                                        richTextBox3.Font = new Font(richTextBox3.Font.FontFamily, 30, FontStyle.Bold);
                                        button16.Enabled = false;
                                    }
                                    else
                                    {
                                        if (richTextBox4.Text == "")
                                        {
                                            richTextBox4.Text = AIplayer;
                                            richTextBox4.Font = new Font(richTextBox4.Font.FontFamily, 30, FontStyle.Bold);
                                            button15.Enabled = false;
                                        }
                                        else
                                        {
                                            if (richTextBox6.Text == "")
                                            {
                                                richTextBox6.Text = AIplayer;
                                                richTextBox6.Font = new Font(richTextBox6.Font.FontFamily, 30, FontStyle.Bold);
                                                button13.Enabled = false;
                                            }
                                            else
                                            {
                                                if (richTextBox9.Text == "")
                                                {
                                                    richTextBox9.Text = AIplayer;
                                                    richTextBox9.Font = new Font(richTextBox9.Font.FontFamily, 30, FontStyle.Bold);
                                                    button10.Enabled = false;
                                                }
                                                else
                                                {
                                                    if (richTextBox8.Text == "")
                                                    {
                                                        richTextBox8.Text = AIplayer;
                                                        richTextBox8.Font = new Font(richTextBox8.Font.FontFamily, 30, FontStyle.Bold);
                                                        button11.Enabled = false;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (richTextBox5.Text == "")
                    {
                        richTextBox5.Text = AIplayer;
                        richTextBox5.Font = new Font(richTextBox5.Font.FontFamily, 30, FontStyle.Bold);
                        button5.Enabled = false;
                    }
                    else
                    {
                        if (richTextBox1.Text == "")
                        {
                            richTextBox1.Text = AIplayer;
                            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 30, FontStyle.Bold);
                            button1.Enabled = false;
                        }
                        else
                        {
                            if (richTextBox8.Text == "")
                            {
                                richTextBox8.Text = AIplayer;
                                richTextBox8.Font = new Font(richTextBox8.Font.FontFamily, 30, FontStyle.Bold);
                                button8.Enabled = false;
                            }
                            else
                            {
                                if (richTextBox6.Text == "")
                                {
                                    richTextBox6.Text = AIplayer;
                                    richTextBox6.Font = new Font(richTextBox6.Font.FontFamily, 30, FontStyle.Bold);
                                    button6.Enabled = false;
                                }
                                else
                                {
                                    if (richTextBox3.Text == "")
                                    {
                                        richTextBox3.Text = AIplayer;
                                        richTextBox3.Font = new Font(richTextBox3.Font.FontFamily, 30, FontStyle.Bold);
                                        button3.Enabled = false;
                                    }
                                    else
                                    {
                                        if (richTextBox4.Text == "")
                                        {
                                            richTextBox4.Text = AIplayer;
                                            richTextBox4.Font = new Font(richTextBox4.Font.FontFamily, 30, FontStyle.Bold);
                                            button4.Enabled = false;
                                        }
                                        else
                                        {
                                            if (richTextBox9.Text == "")
                                            {
                                                richTextBox9.Text = AIplayer;
                                                richTextBox9.Font = new Font(richTextBox9.Font.FontFamily, 30, FontStyle.Bold);
                                                button9.Enabled = false;
                                            }
                                            else
                                            {
                                                if (richTextBox7.Text == "")
                                                {
                                                    richTextBox7.Text = AIplayer;
                                                    richTextBox7.Font = new Font(richTextBox7.Font.FontFamily, 30, FontStyle.Bold);
                                                    button7.Enabled = false;
                                                }
                                                else
                                                {
                                                    if (richTextBox2.Text == "")
                                                    {
                                                        richTextBox2.Text = AIplayer;
                                                        richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, 30, FontStyle.Bold);
                                                        button2.Enabled = false;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Wincondition();
                TurnDeterminer();
            }
            
        }

    }
}