using System.Windows;

namespace Cows_and_Bulls
{
    /// <summary>
    /// Interaction logic for NewGameDialog.xaml
    /// </summary>
    public partial class NewGameDialog : Window
    {
        public char DifficultyLevel = new char();
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
            Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            ProperRun = 0;
            Close();
        }
    }
}
