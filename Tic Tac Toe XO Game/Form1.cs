using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_XO_Game.Properties;

namespace XO_Before
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  enum enPlayer
        {Player1,Player2,Draw,InProgress }
        enPlayer PlayerTurn = enPlayer.Player1;
        //Player1::X
        //Player2::Y
        struct stGameResults
        {
           public bool GameOver;
           public short Counter;//0
           public enPlayer Winner;
        };
        stGameResults GameStatus;


        private void _EndGame()
        {
            lblPlayer.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enPlayer.Player1:
                    {
                        lblWinner.Text = "Player 1";
                        break;
                    }
                case enPlayer.Player2:
                    {

                        lblWinner.Text = "Player 2";
                        break;
                    }
                case enPlayer.Draw:
                    {

                        lblWinner.Text = "No Winner";
                        break;
                    }
                default:
                    lblWinner.Text = "No Winner";
                    break;
            } 
                    GameStatus.GameOver = true;
                    MessageBox.Show("Game Over", "Game End", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private bool _CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if((btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag ) && (btn1.Tag.ToString() != "?"))
            {
                btn1.BackColor = Color.LimeGreen;
                btn2.BackColor = Color.LimeGreen;
                btn3.BackColor = Color.LimeGreen;
                if(btn1.Tag.ToString()=="X")
                    GameStatus.Winner = enPlayer.Player1;
                else
                    GameStatus.Winner = enPlayer.Player2;

                GameStatus.GameOver = true;
                _EndGame();
               
                return true;
            }
            return false;
           
        }
        private void _CheckWinner()
        {
            if (_CheckValues(button1, button2, button3))
                return;
            if (_CheckValues(button4, button5, button6))
                return;
            if (_CheckValues(button7, button8, button9))
                return;
            if (_CheckValues(button1, button4, button7))
                return;
            if (_CheckValues(button2, button5, button8))
                return;
            if (_CheckValues(button3, button6, button9))
                return;
            if (_CheckValues(button1, button5, button9))
                return;
            if (_CheckValues(button3, button5, button7))
                return;
        }
        private void _ClickButton(Button btn)
        {
            if(btn.Tag.ToString() != "?")
            {
                MessageBox.Show("Wrong Choice", "Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;               
            }

            if (PlayerTurn == enPlayer.Player1)
            {
                PlayerTurn = enPlayer.Player2;
                lblPlayer.Text = "Player 2";
                btn.Image = Resources.X;
                btn.Tag = "X";
                GameStatus.Counter++;
                _CheckWinner();

            }
            else 
            {
                PlayerTurn = enPlayer.Player1;
                lblPlayer.Text = "Player 1";
                btn.Image = Resources.O;
                btn.Tag = "O";
                GameStatus.Counter++;
                _CheckWinner();
            }

            if (GameStatus.Counter==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enPlayer.Draw;
                _EndGame();
                return;
            }
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255,Color.White);
            Pen pen = new Pen(White);

            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 690, 135, 690, 635);//Same X (On the horizontal Line)
            e.Graphics.DrawLine(pen, 890, 135, 890, 635);

            e.Graphics.DrawLine(pen, 490, 490, 1090, 490);//Same Y (On the virtical Line)
            e.Graphics.DrawLine(pen, 490, 300, 1090, 300);



        }

      
       

        

        

        

        private void button_Click(object sender, EventArgs e)
        {
            _ClickButton((Button)sender);
        }
       
        private void _ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            _ResetButton(button1);
            _ResetButton(button2);
            _ResetButton(button3);
            _ResetButton(button4);
            _ResetButton(button5);
            _ResetButton(button6);
            _ResetButton(button7);
            _ResetButton(button8);
            _ResetButton(button9);

            lblPlayer.Text = "Player 1";
            lblWinner.Text = "In Progress";
            GameStatus.Winner = enPlayer.InProgress;
            GameStatus.Counter = 0;
            GameStatus.GameOver = false;
        }

        

        
         
    }
}
