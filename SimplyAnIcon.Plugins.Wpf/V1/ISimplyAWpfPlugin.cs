using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SimplyAnIcon.Plugins.V1;
using SimplyAnIcon.Plugins.Wpf.V1.MenuItemViewModels;

namespace SimplyAnIcon.Plugins.Wpf.V1
{
    /// <summary>
    /// ISimplyAWpfPlugin
    /// </summary>
    public interface ISimplyAWpfPlugin : ISimplyAPlugin
    {
        /// <summary>
        /// If null, will not be showed
        /// </summary>
        UserControl CustomConfigControl { get; }

        /// <summary>
        /// If null or empty, will not be showed
        /// </summary>
        IEnumerable<MenuItemViewModel> MenuItems { get; }

        /// <summary>
        /// ResourceDictionaries
        /// </summary>
        IEnumerable<ResourceDictionary> ResourceDictionaries { get; }
    }
}
