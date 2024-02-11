using System;
using System.Collections;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CS_BS
{
    public class CBScore
    {
        public int UserID;
        public int LogID;
        public int Score;
        public string Comments;
        public DateTime TimeSubmitted;
    }

    public partial class MainWindow : Window
    {
        #region Variables
        int GuessNo = 0;

        int Score = 500;
        int BullScore = 5;
        int CowScore = 2;
        int DuplicateCharScore = -10;
        int DuplicateWordScore = -20;
        int TryScore = -50;

        Char Mode = 'E';
        String TheWord = "TEMP";
        String TheGuessedWord = "";

        String ComboBoxName = "CBG";
        String TextBoxName = "GuessTxt";
        String LblName = "GuessCBLbl";

        String CBMsg = "";
        String DisplayMsgTxt = "This will Display the Text Generated During CB\nScore : 500";
        String DuplicateChar = "You have Entered One/More Duplicate Characters. Please Guess Again.";
        String DuplicateWord = "You have Entered this Word Before. Please Select a Different Word.";
        String GameEndMsg = "Shai!! Shai!! Tch!! Tch!! You could not Solve Even such a Easy Word!!!!\n Anyways The Word is : ";
        String GameOverMsg = "Game Over!!";
        String QuitMsg = "Loser!!!! Haven't you heard the Phrase 'Quitters never Win and Winners never Quit'. \n Anyways the Word is : ";
        String VictoryMsg = "Congratulations!!! That's the Correct Word!!!";
        String ZeroScoreMsg = "You have hit Rock Bottom!!!!\tIts Zero Score!!!\nYour Game will be terminated at this Point.\n\n\"Nice Try\"\nYes,That was Sarcastic.\n\n Anyways the Word is : ";

        Hashtable GuessChars = new Hashtable();
        Hashtable GuessedWordsList = new Hashtable();

        BrushConverter bc = new BrushConverter();
        Brush brush;
        #endregion

        #region Initialisation Function        
        public MainWindow()
        {
            InitializeComponent();

            var cbs = new CBScore();
            //CBSServiceClient client = new CBSServiceClient("WSHttpBinding_ICBSService");
            //cbs = client.UserOnline("Bob", "202.46.215.53");
            ////// Use the 'client' variable to call operations on the service.
            ////// Always close the client.
            //client.Close();

            // VERY IMPORTANT PIECE OF CODE
            //var darkwindow = new Window()
            //{
            //    Background = Brushes.Black,
            //    Opacity = 0.4,
            //    AllowsTransparency = true,
            //    WindowStyle = WindowStyle.None,
            //    WindowState = WindowState.Maximized,
            //    Topmost = true
            //};
            //darkwindow.Show();
            //MessageBox.Show("Hello");
            //darkwindow.Close();

            SelectAWord();
            brush = (Brush)bc.ConvertFrom("#FF0000AD");
        }

        private void FillCombos()
        {
            var Alphabets = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            var TCB = new ComboBox();
            for (int i = 1; i < 5; i++)
            {
                TCB = (ComboBox)FindName(ComboBoxName + i.ToString());
                TCB.Items.Clear();
                TCB.IsEnabled = true;
                for (int j = 0; j < 26; j++)
                    TCB.Items.Insert(j, Alphabets[j]);
                TCB.SelectedIndex = 0;
            }
        }

        private void SelectAWord()
        {
            Reset();
            TheWord = WordSelect.GenerateWord(Mode);
        }
        #endregion

        #region Button Click Functions
        private void Submit(object sender, RoutedEventArgs e)
        {
            if (Score < 1)
            {
                LockAll();

                DisplayMsg.Text = GameOverMsg + "\nScore : " + Score;
                DisplayMsg.Foreground = brush;

                MessageBox.Show(ZeroScoreMsg + TheWord, "Sorry Bub!!!");

                SelectAWord();
                return;
            }
            int InvalidEntryFlag = CheckforDuplicates();

            if (InvalidEntryFlag == 1)
            {
                Score = Score + DuplicateCharScore;
                DisplayMsg.Text = DuplicateChar + "\nScore : " + Score;
                DisplayMsg.Foreground = Brushes.Red;
            }
            else
            {
                if (GuessedWordsList.ContainsValue(TheGuessedWord))
                {
                    Score = Score + DuplicateWordScore;
                    DisplayMsg.Text = DuplicateWord + "\nScore : " + Score;
                    DisplayMsg.Foreground = Brushes.Red;
                }
                else
                {
                    GuessNo++;
                    GuessedWordsList.Add(GuessNo, TheGuessedWord);
                    if (TheWord == TheGuessedWord)
                    {
                        var TTB = new TextBox();
                        TTB = (TextBox)FindName(TextBoxName + GuessNo.ToString());
                        TTB.Text = TheGuessedWord;

                        var TLbl = new Label();
                        TLbl = (Label)FindName(LblName + GuessNo.ToString());
                        TLbl.Content = "0 C 4 B";

                        DisplayMsg.Text = VictoryMsg + "\nScore : " + Score;
                        DisplayMsg.Foreground = brush;
                        LockAll();

                        MessageBox.Show(VictoryMsg, "You Win!!!");

                        SelectAWord();
                    }
                    else
                        CalculateCB();
                }
            }
            TheGuessedWord = "";
            GuessChars.Clear();
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            LockAll();
            MessageBox.Show(QuitMsg + TheWord, "I Give Up");
            SelectAWord();
        }

        private void ResetBtnClick(object sender, RoutedEventArgs e)
        {
            FillCombos();
        }
        #endregion

        #region Utility Functions        
        private void LockAll()
        {
            var TCB = new ComboBox();
            for (int i = 1; i < 5; i++)
            {
                TCB = (ComboBox)FindName(ComboBoxName + i.ToString());
                TCB.IsEnabled = false;
            }
        }

        private void Reset()
        {
            FillCombos();

            var TTB = new TextBox();
            for (int j = 1; j < 11; j++)
            {
                TTB = (TextBox)FindName(TextBoxName + j.ToString());
                TTB.Text = "Pending";
            }

            var TLbl = new Label();
            for (int k = 1; k < 11; k++)
            {
                TLbl = (Label)FindName(LblName + k.ToString());
                TLbl.Content = "C B";
            }
            DisplayMsg.Text = DisplayMsgTxt;
            Score = 500;
            GuessNo = 0;
            TheGuessedWord = "";
            GuessChars.Clear();
            GuessedWordsList.Clear();
        }
        # endregion

        # region Game Logic
        private int CheckforDuplicates()
        {
            int InvalidEntryFlag = 0;

            var TCB = new ComboBox();
            for (int i = 1; i < 5; i++)
            {
                TCB = (ComboBox)FindName(ComboBoxName + i.ToString());
                if (GuessChars.ContainsValue(TCB.SelectedValue))
                    InvalidEntryFlag = 1;
                else
                {
                    GuessChars.Add(i - 1, TCB.SelectedValue);
                    TheGuessedWord += TCB.SelectedValue.ToString();
                }
            }
            return InvalidEntryFlag;
        }

        private void CalculateCB()
        {
            int Cows = 0;
            int Bulls = 0;

            for (int i = 0; i < 4; i++)
                if (TheWord[i] == TheGuessedWord[i])
                    Bulls++;

            for (int j = 0; j < 4; j++)
                if (GuessChars.ContainsValue(TheWord[j].ToString()) && GuessChars[j].ToString() != TheWord[j].ToString())
                    Cows++;

            CBMsg = Cows.ToString() + " Cows\n" + Bulls.ToString() + " Bulls";

            var TTB = new TextBox();
            TTB = (TextBox)FindName(TextBoxName + GuessNo.ToString());
            TTB.Text = TheGuessedWord;

            var TLbl = new Label();
            TLbl = (Label)FindName(LblName + GuessNo.ToString());
            TLbl.Content = Cows.ToString() + " C " + Bulls.ToString() + " B";

            Score = Score + TryScore + (Cows * CowScore) + (Bulls * BullScore);
            DisplayMsg.Text = CBMsg + "\nScore : " + Score;
            DisplayMsg.Foreground = brush;

            if (GuessNo > 9)
            {
                LockAll();

                DisplayMsg.Text = GameOverMsg + "\nScore : " + Score;
                DisplayMsg.Foreground = brush;

                MessageBox.Show(GameEndMsg + TheWord, GameOverMsg);

                SelectAWord();
            }
        }
        # endregion

        # region Taskbar Functions
        private void ShowNewGameDialog(object sender, RoutedEventArgs e)
        {
            NewGameDialog NGDWindow = new NewGameDialog();

            NGDWindow.ShowDialog();

            if (NGDWindow.ProperRun == 1)
            {
                Mode = NGDWindow.DifficultyLevel;
                SelectAWord();
            }
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            string temp = GetMachineIPAddress();
            MessageBox.Show(temp);

            AboutBox About = new AboutBox();
            About.ShowDialog();
        }

        private void ScoreRule(object sender, RoutedEventArgs e)
        {

        }

        # endregion

        private string GetMachineIPAddress()
        {
            try
            {
                string sReturnValue = "";
                string strHostName = Dns.GetHostName();

                IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);     // Then using host name, get the IP address list.
                IPAddress[] addr = ipEntry.AddressList;

                for (int i = 0; i < addr.Length; i++)
                    sReturnValue += addr[i].ToString();

                return sReturnValue;
            }
            catch (Exception ex)
            { throw (ex); }

        }
    }
}