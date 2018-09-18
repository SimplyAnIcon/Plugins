﻿using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using SimplyAnIcon.Plugins.Wpf.Util;

namespace SimplyAnIcon.Plugins.Wpf.V1
{
    public class MenuItemViewModel : ViewModelBase
    {
        private bool _isEnabled = true;
        private object _iconPath;
        private int _height = 21;
        private bool _staysOpenOnClick = false;
        private string _name;

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

        public int Height
        {
            get => _height;
            set => Set(ref _height, value);
        }

        public bool StaysOpenOnClick
        {
            get => _staysOpenOnClick;
            set => Set(ref _staysOpenOnClick, value);
        }

        public ICommand Action { get; set; }

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public FastObservableCollection<MenuItemViewModel> Children { get; } = new FastObservableCollection<MenuItemViewModel>();
    }
}
