using GameOfThrones.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace GameOfThrones.WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Character> _characters;

        public MainWindow()
        {
            InitializeComponent();

            string result = string.Empty;
            using (var client = new WebClient())
            {
                result = client.DownloadString("https://api.got.show/api/book/characters");
            }
            _characters = JsonConvert.DeserializeObject<List<Character>>(result);
            charactersListBox.ItemsSource = _characters;
        }

        private void CharacterNameTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            charactersListBox.ItemsSource = _characters.Where(character => character.Name.ToLower().StartsWith(characterNameTextBox.Text.ToLower()));
        }

        private void CharactersListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CharacterDescription characterDescriptionWindow = new CharacterDescription();
            characterDescriptionWindow.SetCharacter(charactersListBox.SelectedItem as Character);
            characterDescriptionWindow.ShowDialog();
        }
    }
}
