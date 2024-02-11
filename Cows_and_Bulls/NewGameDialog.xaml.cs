using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CS_BS
{
    /// <summary>
    /// Interaction logic for NewGameDialog.xaml
    /// </summary>
    public partial class NewGameDialog : Window
    {
        public Char DifficultyLevel = new char();
        public int ProperRun = 0;

        public NewGameDialog()
        {
            InitializeComponent();

            DifficultyLevel = new char();
            ProperRun = 0;

            GameDifficulty.Items.Clear();
            GameDifficulty.Items.Insert(0, "Easy");
            GameDifficulty.Items.Insert(1, "Medium");
            GameDifficulty.Items.Insert(2, "Difficult");
        }

        private void StartNewGame(object sender, RoutedEventArgs e)
        {
            ProperRun = 1;
            if (GameDifficulty.SelectedIndex == 0)
                DifficultyLevel = 'E';
            else if (GameDifficulty.SelectedIndex == 1)
                DifficultyLevel = 'M';
            else if (GameDifficulty.SelectedIndex == 2)
                DifficultyLevel = 'D';
            this.Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            ProperRun = 0;
            this.Close();
        }
    }
}
