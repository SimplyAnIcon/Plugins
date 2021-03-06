﻿using System.Windows;
using System.Windows.Input;
using Com.Ericmas001.Mvvm;
using Com.Ericmas001.Mvvm.Collections;

namespace SimplyAnIcon.Plugins.Wpf.V1.MenuItemViewModels
{
    /// <summary>
    /// MenuItemViewModel
    /// </summary>
    public class MenuItemViewModel : ViewModelBase
    {
        private bool _isEnabled = true;
        private bool _isVisible = true;
        private object _iconPath;
        private Style _itemStyle;
        private double _height = 21;
        private bool _staysOpenOnClick;
        private string _name;

        /// <summary>
        /// Parent
        /// </summary>
        public MenuItemViewModel Parent { get; }

        /// <summary>
        /// IsEnabled
        /// </summary>
        public bool IsEnabled
        {
            get => _isEnabled;
            set => Set(ref _isEnabled, value);
        }

        /// <summary>
        /// IsVisible
        /// </summary>
        public bool IsVisible
        {
            get => _isVisible;
            set => Set(ref _isVisible, value);
        }

        /// <summary>
        /// IconPath
        /// </summary>
        public object IconPath
        {
            get => _iconPath;
            set => Set(ref _iconPath, value);
        }

        /// <summary>
        /// ItemStyle
        /// </summary>
        public Style ItemStyle
        {
            get => _itemStyle;
            set => Set(ref _itemStyle, value);
        }

        /// <summary>
        /// Height
        /// </summary>
        public double Height
        {
            get => _height;
            set => Set(ref _height, value);
        }

        /// <summary>
        /// StaysOpenOnClick
        /// </summary>
        public bool StaysOpenOnClick
        {
            get => _staysOpenOnClick;
            set => Set(ref _staysOpenOnClick, value);
        }

        /// <summary>
        /// Action
        /// </summary>
        public ICommand Action { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        /// <summary>
        /// Children
        /// </summary>
        public FastObservableCollection<MenuItemViewModel> Children { get; } = new FastObservableCollection<MenuItemViewModel>();

        /// <summary>
        /// FullName
        /// </summary>
        public string FullName => Parent == null ? Name : $"{Parent.FullName}/{Name}";

        /// <summary>
        /// Root
        /// </summary>
        public MenuItemViewModel Root => Parent == null ? this : Parent.Root;

        /// <summary>
        /// MenuItemViewModel
        /// </summary>
        public MenuItemViewModel(MenuItemViewModel parent)
        {
            Parent = parent;
        }
    }
}
