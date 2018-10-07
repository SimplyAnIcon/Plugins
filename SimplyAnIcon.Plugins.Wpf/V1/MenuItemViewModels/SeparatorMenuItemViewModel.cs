namespace SimplyAnIcon.Plugins.Wpf.V1.MenuItemViewModels
{
    /// <summary>
    /// SeparatorMenuItemViewModel
    /// </summary>
    public class SeparatorMenuItemViewModel : MenuItemViewModel
    {
        /// <summary>
        /// SeparatorMenuItemViewModel
        /// </summary>
        public SeparatorMenuItemViewModel(MenuItemViewModel parent) : base(parent)
        {
            IsEnabled = false;
            Height = 8;
        }
    }
}
