using MemoryGameA.Common;
using MemoryGameA.Views;
using Reactive.Bindings;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using WpfSimpleNavi.Navigation;

namespace MemoryGameA.ViewModels
{
    public class SettingPageViewModel : INotifyPropertyChanged
    {    

        public SettingPageViewModel(int SelectedVertical, int SelectedSide)
        {
            this.SelectedVertical = SelectedVertical;
            this.SelectedSide = SelectedSide;
        }
        
        public void SendPage()
        {
            if (SelectedVertical == 6 && SelectedSide == 6)
            {
                NavigationManager.NavigateSameArea(this, new GamePage66ViewModel());
            }
            else if(SelectedVertical == 6 && SelectedSide == 5)
            {
                NavigationManager.NavigateSameArea(this, new GamePage65ViewModel());
            }
            else if (SelectedVertical == 6 && SelectedSide == 4)
            {
                NavigationManager.NavigateSameArea(this, new GamePage64ViewModel());
            }
            else if (SelectedVertical == 6 && SelectedSide == 3)
            {
                NavigationManager.NavigateSameArea(this, new GamePage63ViewModel());
            }
            else if (SelectedVertical == 5 && SelectedSide == 6)
            {
                NavigationManager.NavigateSameArea(this, new GamePage56ViewModel());
            }
            else if (SelectedVertical == 5 && SelectedSide == 5)
            {
                NavigationManager.NavigateSameArea(this, new GamePage55ViewModel());
            }
            else if(SelectedVertical == 5 && SelectedSide == 4)
            {
                NavigationManager.NavigateSameArea(this, new GamePage54ViewModel());
            }
            else if (SelectedVertical == 5 && SelectedSide == 3)
            {
                NavigationManager.NavigateSameArea(this, new GamePage53ViewModel());
            }
            else if (SelectedVertical == 4 && SelectedSide == 6)
            {
                NavigationManager.NavigateSameArea(this, new GamePage46ViewModel());
            }
            else if (SelectedVertical == 4 && SelectedSide == 5)
            {
                NavigationManager.NavigateSameArea(this, new GamePage45ViewModel());
            }
            else if (SelectedVertical == 4 && SelectedSide == 4)
            {
                NavigationManager.NavigateSameArea(this, new GamePage44ViewModel());
            }
            else if (SelectedVertical == 4 && SelectedSide == 3)
            {
                NavigationManager.NavigateSameArea(this, new GamePage43ViewModel());
            }
            else if (SelectedVertical == 3 && SelectedSide == 6)
            {
                NavigationManager.NavigateSameArea(this, new GamePage36ViewModel());
            }
            else if (SelectedVertical == 3 && SelectedSide == 5)
            {
                NavigationManager.NavigateSameArea(this, new GamePage35ViewModel());
            }
            else if (SelectedVertical == 3 && SelectedSide == 4)
            {
                NavigationManager.NavigateSameArea(this, new GamePage34ViewModel());
            }
            else if (SelectedVertical == 3 && SelectedSide == 3)
            {
                NavigationManager.NavigateSameArea(this, new GamePage33ViewModel());
            }
        }



        public SettingPageViewModel()
        {
            // ゲーム画面
            NavigateToGameCommand = new DelegateCommand(() => SendPage());

            // 縦マス
            Vertical = new int[] { 3, 4, 5, 6 };

            SelectedVertical = Vertical[3];

            // 横マス
            Side = new int[] { 3, 4, 5, 6 };

            SelectedSide = Side[3];          

        }

        // 縦マス
        private int _SelectedVertical;
        public int SelectedVertical
        {
            get { return _SelectedVertical; }
            set
            {
                _SelectedVertical = value;
                NotifyPropertyChanged("SelectedVertical");
            }
        }
        
        private int[] _Vertical;
        public int[] Vertical
        {
            get { return _Vertical; }
            set
            {
                _Vertical = value;
                NotifyPropertyChanged("Vertical");
            }
        }

        // 横マス
        private int _SelectedSide;
        public int SelectedSide
        {
            get { return _SelectedSide; }
            set
            {
                _SelectedSide = value;
                NotifyPropertyChanged("SelectedSide");
            }
        }

        private int[] _Side;
        public int[] Side
        {
            get { return _Side; }
            set
            {
                _Side = value;
                NotifyPropertyChanged("Side");
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        //public string SelectedPlayersValue { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand NavigateToGameCommand { get; set; }
        
    }


}
