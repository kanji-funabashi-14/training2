using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MemoryGameA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfSimpleNavi.Navigation;

namespace MemoryGameA.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            MainContent = NavigationManager.PublishArea("MainArea", new SettingPageViewModel());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private INotifyPropertyChanged _MainContent;
        public INotifyPropertyChanged MainContent
        {
            get => _MainContent;
            set
            {
                if (_MainContent == value) return;
                _MainContent = value;
                 RaisePropertyChanged();
            }
        }
        private void RaisePropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

