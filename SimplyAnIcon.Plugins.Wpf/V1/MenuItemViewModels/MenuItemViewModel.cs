using System;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using SimplyAnIcon.Plugins.Wpf.Util;

namespace SimplyAnIcon.Plugins.Wpf.V1.MenuItemViewModels
{
    public class MenuItemViewModel : ViewModelBase
    {
        private bool _isEnabled = true;
        private object _iconPath;
        private object _itemStyle = FindDefaultStyle();
        private double _height = 21;
        private bool _staysOpenOnClick;
        private bool _isSubMenuOpen;
        private string _name;

        public event EventHandler<bool> OnForceMenuOpen = delegate { };

        public bool IsEnabled
        {
            get => _isEnabled;
            set => Set(ref _isEnabled , value);
        }

        public object IconPath
        {
            get => _iconPath;
            set => Set(ref _iconPath, value);
        }

        public object ItemStyle
        {
            get => _itemStyle;
            set => Set(ref _itemStyle, value);
        }

        public double Height
        {
            get => _height;
            set => Set(ref _height, value);
        }

        public bool StaysOpenOnClick
        {
            get => _staysOpenOnClick;
            set => Set(ref _staysOpenOnClick, value);
        }

        public bool IsSubMenuOpen
        {
            get => _isSubMenuOpen;
            set => Set(ref _isSubMenuOpen, value);
        }

        public ICommand Action { get; set; }

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public FastObservableCollection<MenuItemViewModel> Children { get; } = new FastObservableCollection<MenuItemViewModel>();

        public void ForceMenuOpen(bool isForced)
        {
            OnForceMenuOpen(this, isForced);
        }

        private static object FindDefaultStyle()
        {
            try
            {
                return Application.Current.Resources["SimplyIconMenuItemStyle"];
            }
            catch
            {
                return null;
            }
        }
    }
}
