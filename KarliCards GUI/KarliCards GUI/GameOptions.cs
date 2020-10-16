using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KarliCards_GUI
{
    [Serializable]
    public class GameOptions : INotifyPropertyChanged
    {
        private ObservableCollection<string> _playerNames =
            new ObservableCollection<string>();
        public List<string> SelectedPlayers { get; set; }
        private bool _playAgainstComputer = true;
        private int _numberOfPlayers = 2;
        private int _minutesBeforeLoss = 10;
        private ComputerSkillLevel _computerSkill = ComputerSkillLevel.Dumb;


        public GameOptions()
        {
            SelectedPlayers = new List<string>();
        }
        public ObservableCollection<string> PlayerNames
        {
            get 
            {
                return _playerNames;
            }
            set
            {
                _playerNames = value;
                OnPropertyChanged("PlayerNames");
            }
        }
        public void AddPlayer(string playerName)
        {
            if (_playerNames.Contains(playerName))
                return;
            _playerNames.Add(playerName);
            OnPropertyChanged("PlayerName");
        }
        public int NumberOfPlayers
        {
            get { return _numberOfPlayers; }
            set {
                _numberOfPlayers = value;
                OnPropertyChanged("NumberOfPlayers");
            }
        }
        public bool PlayAgainstComputer
        {
            get { return _playAgainstComputer; }
            set {
                _playAgainstComputer = value;
                OnPropertyChanged("PlayAgainstComputer");
            }
        }
        public int MinuteBeforeLoss 
        {
            get { return _minutesBeforeLoss; }
            set 
            {
                _minutesBeforeLoss = value;
                OnPropertyChanged("MinuteBeforeLoss");
            }
        }
        public ComputerSkillLevel ComputerSkill
        {
            get { return _computerSkill; }
            set 
            {
                _computerSkill = value;
                OnPropertyChanged("ComputerSkill");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) 
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }


    [Serializable]
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }
}
