using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SimplyAnIcon.Plugins.V1;
using SimplyAnIcon.Plugins.Wpf.V1.MenuItemViewModels;

namespace SimplyAnIcon.Plugins.Wpf.V1
{
    public interface ISimplyAWpfPlugin : ISimplyAPlugin
    {
        /// <summary>
        /// If null, will not be showed
        /// </summary>
        UserControl CustomConfigControl { get; }

        /// <summary>
        /// Will never be called if CustomConfigControl is null
        /// </summary>
        void OnConfigSave();

        /// <summary>
        /// If null or empty, will not be showed
        /// </summary>
        IEnumerable<MenuItemViewModel> MenuItems { get; }

        IEnumerable<ResourceDictionary> ResourceDictionaries { get; }
    }
}
