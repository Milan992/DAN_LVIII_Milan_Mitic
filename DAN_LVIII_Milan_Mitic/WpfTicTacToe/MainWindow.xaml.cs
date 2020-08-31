using System;
using System.Windows;

namespace WpfTicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool turnX;
        static char[,] ticTacToe = new char[3, 3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_NewGame(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            ButtonContentToDot();
            if (!turnX)
            {
                ComputerPlay();
            }
        }

        private void O_Checked(object sender, RoutedEventArgs e)
        {
            turnX = false;
        }

        private void X_Checked(object sender, RoutedEventArgs e)
        {
            turnX = true;
        }

        private void btn1_1_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn1_1.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[0, 0] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn1_1.Content = "O";
                ticTacToe[0, 0] = 'O';
                turnX = true;
            }
            btn1_1.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn1_2_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn1_2.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[0, 1] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn1_2.Content = "O";
                ticTacToe[0, 1] = 'O';
                turnX = true;
            }
            btn1_2.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn1_3_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn1_3.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[0, 2] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn1_3.Content = "O";
                ticTacToe[0, 2] = 'O';
                turnX = true;
            }
            btn1_3.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn2_1_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn2_1.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[1, 0] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn2_1.Content = "O";
                ticTacToe[1, 0] = 'O';
                turnX = true;
            }
            btn2_1.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn2_2_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn2_2.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[1, 1] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn2_2.Content = "O";
                ticTacToe[1, 1] = 'O';
                turnX = true;
            }
            btn2_2.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn2_3_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn2_3.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[1, 2] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn2_3.Content = "O";
                ticTacToe[1, 2] = 'O';
                turnX = true;
            }
            btn2_3.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn3_1_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn3_1.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[2, 0] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn3_1.Content = "O";
                ticTacToe[2, 0] = 'O';
                turnX = true;
            }
            btn3_1.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn3_2_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn3_2.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[2, 1] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn3_2.Content = "O";
                ticTacToe[2, 1] = 'O';
                turnX = true;
            }
            btn3_2.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        private void btn3_3_Click(object sender, RoutedEventArgs e)
        {
            if (turnX)
            {
                //Show X sign in the button
                btn3_3.Content = "X";
                //add to array so the winning contidions can be checked
                ticTacToe[2, 2] = 'X';
                //change player's turn
                turnX = false;
            }
            else
            {
                btn3_3.Content = "O";
                ticTacToe[2, 2] = 'O';
                turnX = true;
            }
            btn3_3.IsEnabled = false;
            ComputerPlay();
            CheckWin();
        }

        #region Methods

        /// <summary>
        /// Disables all game's buttons.
        /// </summary>
        private void DisableButtons()
        {
            btn1_1.IsEnabled = false;
            btn1_2.IsEnabled = false;
            btn1_3.IsEnabled = false;
            btn2_1.IsEnabled = false;
            btn2_2.IsEnabled = false;
            btn2_3.IsEnabled = false;
            btn3_1.IsEnabled = false;
            btn3_2.IsEnabled = false;
            btn3_3.IsEnabled = false;
        }

        /// <summary>
        /// Enables all game's buttons.
        /// </summary>
        private void EnableButtons()
        {
            btn1_1.IsEnabled = true;
            btn1_2.IsEnabled = true;
            btn1_3.IsEnabled = true;
            btn2_1.IsEnabled = true;
            btn2_2.IsEnabled = true;
            btn2_3.IsEnabled = true;
            btn3_1.IsEnabled = true;
            btn3_2.IsEnabled = true;
            btn3_3.IsEnabled = true;
        }

        /// <summary>
        /// Sets all buttons content to ".".
        /// </summary>
        private void ButtonContentToDot()
        {
            btn1_1.Content = ".";
            btn1_2.Content = ".";
            btn1_3.Content = ".";
            btn2_1.Content = ".";
            btn2_2.Content = ".";
            btn2_3.Content = ".";
            btn3_1.Content = ".";
            btn3_2.Content = ".";
            btn3_3.Content = ".";
        }

        private void ComputerPlay()
        {
            Random r = new Random();
 
            while (true)
            {
                int i = r.Next(1, 10);
                if (i == 1)
                {
                    if (turnX)
                    {
                        if (ticTacToe[0, 0] != 'X' && ticTacToe[0, 0] != 'O')
                        {
                            //Show X sign in the button
                            btn1_1.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[0, 0] = 'X';
                            //change player's turn
                            turnX = false;
                            btn1_1.IsEnabled = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (ticTacToe[0, 0] != 'X' && ticTacToe[0, 0] != 'O')
                        {
                            btn1_1.Content = "O";
                            ticTacToe[0, 0] = 'O';
                            turnX = true;
                            btn1_1.IsEnabled = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (i == 2)
                {
                    if (ticTacToe[0, 1] != 'X' && ticTacToe[0, 1] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn1_2.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[0, 1] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn1_2.Content = "O";
                            ticTacToe[0, 1] = 'O';
                            turnX = true;
                        }
                        btn1_2.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (i == 3)
                {
                    if (ticTacToe[0, 2] != 'X' && ticTacToe[0, 2] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn1_3.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[0, 2] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn1_3.Content = "O";
                            ticTacToe[0, 2] = 'O';
                            turnX = true;
                        }
                        btn1_3.IsEnabled = false;
                        break;
                    }
                    else { continue; }
                }
                else if (i == 5)
                {
                    if (ticTacToe[1, 1] != 'X' && ticTacToe[1, 1] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn2_2.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[1, 1] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn2_2.Content = "O";
                            ticTacToe[1, 1] = 'O';
                            turnX = true;
                        }
                        btn2_2.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (i == 4)
                {
                    if (ticTacToe[1, 0] != 'X' && ticTacToe[1, 0] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn2_1.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[1, 0] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn2_1.Content = "O";
                            ticTacToe[1, 0] = 'O';
                            turnX = true;
                        }
                        btn2_1.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (i == 6)
                {
                    if (ticTacToe[1, 2] != 'X' && ticTacToe[1, 2] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn2_3.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[1, 2] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn2_3.Content = "O";
                            ticTacToe[1, 2] = 'O';
                            turnX = true;
                        }
                        btn2_3.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (i == 7)
                {
                    if (ticTacToe[2, 0] != 'X' && ticTacToe[2, 0] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn3_1.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[2, 0] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn3_1.Content = "O";
                            ticTacToe[2, 0] = 'O';
                            turnX = true;
                        }
                        btn3_1.IsEnabled = false;
                        break;
                    }
                    else { continue; }
                }
                else if (i == 8)
                {
                    if (ticTacToe[2, 1] != 'X' && ticTacToe[2, 1] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn3_2.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[2, 1] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn3_2.Content = "O";
                            ticTacToe[2, 1] = 'O';
                            turnX = true;
                        }
                        btn3_2.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (i == 9)
                {
                    if (ticTacToe[2, 2] != 'X' && ticTacToe[2, 2] != 'O')
                    {
                        if (turnX)
                        {
                            //Show X sign in the button
                            btn3_3.Content = "X";
                            //add to array so the winning contidions can be checked
                            ticTacToe[2, 2] = 'X';
                            //change player's turn
                            turnX = false;
                        }
                        else
                        {
                            btn3_3.Content = "O";
                            ticTacToe[2, 2] = 'O';
                            turnX = true;
                        }
                        btn3_3.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            CheckWin();
        }

        private void CheckWin()
        {
            //check winning conditions fox "X"
            if (ticTacToe[1, 1] == 'X')
            {
                if (ticTacToe[0, 0] == 'X')
                {
                    if (ticTacToe[2, 2] == 'X')
                    {
                        MessageBox.Show("X wins");
                        EnableButtons();
                        ButtonContentToDot();
                        ticTacToe = new char[3, 3];
                    }
                }
                else if (ticTacToe[0, 1] == 'X')
                {
                    if (ticTacToe[2, 1] == 'X')
                    {
                        MessageBox.Show("X wins");
                        EnableButtons();
                        ButtonContentToDot();
                        ticTacToe = new char[3, 3];
                    }
                }
                else if (ticTacToe[1, 0] == 'X')
                {
                    if (ticTacToe[1, 2] == 'X')
                    {
                        MessageBox.Show("X wins");
                        EnableButtons();
                        ButtonContentToDot();
                        ticTacToe = new char[3, 3]; ;
                    }
                }
                else if (ticTacToe[2, 0] == 'X')
                {
                    if (ticTacToe[0, 2] == 'X')
                    {
                        MessageBox.Show("X wins");
                        EnableButtons();
                        ButtonContentToDot();
                        ticTacToe = new char[3, 3];
                    }
                }

                //check winning conditions for "O"
                if (ticTacToe[1, 1] == 'O')
                {
                    if (ticTacToe[0, 0] == 'O')
                    {
                        if (ticTacToe[2, 2] == 'O')
                        {
                            MessageBox.Show("O wins");
                            EnableButtons();
                            ButtonContentToDot();
                            ticTacToe = new char[3, 3];
                        }
                    }
                    else if (ticTacToe[0, 1] == 'O')
                    {
                        if (ticTacToe[2, 1] == 'O')
                        {
                            MessageBox.Show("O wins");
                            EnableButtons();
                            ButtonContentToDot();
                            ticTacToe = new char[3, 3];
                        }
                    }
                    else if (ticTacToe[1, 0] == 'O')
                    {
                        if (ticTacToe[1, 2] == 'O')
                        {
                            MessageBox.Show("O wins");
                            EnableButtons();
                            ButtonContentToDot();
                            ticTacToe = new char[3, 3]; ;
                        }
                    }
                    else if (ticTacToe[2, 0] == 'O')
                    {
                        if (ticTacToe[0, 2] == 'O')
                        {
                            MessageBox.Show("O wins");
                            EnableButtons();
                            ButtonContentToDot();
                            ticTacToe = new char[3, 3];
                        }
                    }
                }
            }
        }
        #endregion
    }
}
