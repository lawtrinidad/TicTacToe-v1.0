namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var result = MessageBox.Show("Welcome to Tic Tac Toe!\r \nWould you like to play PVP?\r \nClicking 'Yes' will open our two-player game. 'No' will open a game against a bot.", "Tic Tac Toe The Game v1.0", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                InitializeComponent();
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
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = " X";
            richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, 30, FontStyle.Bold);
            button2.Enabled = false;
            button17.Enabled = false;
            Wincondition();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " O";
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 30, FontStyle.Bold);
            button1.Enabled = false;
            button18.Enabled = false;
            Wincondition();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            richTextBox2.Text = " O";
            richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, 30, FontStyle.Bold);
            button2.Enabled = false;
            button17.Enabled = false;
            Wincondition();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = " X";
            richTextBox3.Font = new Font(richTextBox3.Font.FontFamily, 30, FontStyle.Bold);
            button3.Enabled = false;
            button16.Enabled = false;
            Wincondition();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = " O";
            richTextBox3.Font = new Font(richTextBox3.Font.FontFamily, 30, FontStyle.Bold);
            button3.Enabled = false;
            button16.Enabled = false;
            Wincondition();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = " X";
            richTextBox4.Font = new Font(richTextBox4.Font.FontFamily, 30, FontStyle.Bold);
            button4.Enabled = false;
            button15.Enabled = false;
            Wincondition();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = " O";
            richTextBox4.Font = new Font(richTextBox4.Font.FontFamily, 30, FontStyle.Bold);
            button4.Enabled = false;
            button15.Enabled = false;
            Wincondition();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox5.Text = " X";
            richTextBox5.Font = new Font(richTextBox5.Font.FontFamily, 30, FontStyle.Bold);
            button5.Enabled = false;
            button14.Enabled = false;
            Wincondition();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox5.Text = " O";
            richTextBox5.Font = new Font(richTextBox5.Font.FontFamily, 30, FontStyle.Bold);
            button5.Enabled = false;
            button14.Enabled = false;
            Wincondition();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = " X";
            richTextBox6.Font = new Font(richTextBox6.Font.FontFamily, 30, FontStyle.Bold);
            button6.Enabled = false;
            button13.Enabled = false;
            Wincondition();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = " O";
            richTextBox6.Font = new Font(richTextBox6.Font.FontFamily, 30, FontStyle.Bold);
            button6.Enabled = false;
            button13.Enabled = false;
            Wincondition();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox7.Text = " X";
            richTextBox7.Font = new Font(richTextBox7.Font.FontFamily, 30, FontStyle.Bold);
            button7.Enabled = false;
            button12.Enabled = false;
            Wincondition();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox7.Text = " O";
            richTextBox7.Font = new Font(richTextBox7.Font.FontFamily, 30, FontStyle.Bold);
            button7.Enabled = false;
            button12.Enabled = false;
            Wincondition();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox8.Text = " X";
            richTextBox8.Font = new Font(richTextBox8.Font.FontFamily, 30, FontStyle.Bold);
            button8.Enabled = false;
            button11.Enabled = false;
            Wincondition();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox8.Text = " O";
            richTextBox8.Font = new Font(richTextBox8.Font.FontFamily, 30, FontStyle.Bold);
            button8.Enabled = false;
            button11.Enabled = false;
            Wincondition();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox9.Text = " X";
            richTextBox9.Font = new Font(richTextBox9.Font.FontFamily, 30, FontStyle.Bold);
            button9.Enabled = false;
            button10.Enabled = false;
            Wincondition();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox9.Text = " O";
            richTextBox9.Font = new Font(richTextBox9.Font.FontFamily, 30, FontStyle.Bold);
            button9.Enabled = false;
            button10.Enabled = false;
            Wincondition();
        }

        private void Wincondition()
        {
            //Horizontal Condition
            if (((richTextBox1.Text == richTextBox2.Text) && (richTextBox2.Text == richTextBox3.Text) && (richTextBox2.Text != "")) || ((richTextBox4.Text == richTextBox5.Text) && (richTextBox5.Text == richTextBox6.Text) && (richTextBox5.Text != "")) || ((richTextBox7.Text == richTextBox8.Text) && (richTextBox8.Text == richTextBox9.Text) && (richTextBox8.Text != "")))
            {
                if (((richTextBox1.Text == richTextBox2.Text) && (richTextBox2.Text == richTextBox3.Text) && (richTextBox2.Text != "") && (richTextBox1.Text == " X")) || ((richTextBox4.Text == richTextBox5.Text) && (richTextBox5.Text == richTextBox6.Text) && (richTextBox5.Text != "") && (richTextBox4.Text == " X")) || ((richTextBox7.Text == richTextBox8.Text) && (richTextBox8.Text == richTextBox9.Text) && (richTextBox8.Text != "") && (richTextBox7.Text == " X")))
                {
                    var winner = "X";

                    var result = MessageBox.Show("Congratulations! " + "Player " + winner + " wins.\n" + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
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
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}