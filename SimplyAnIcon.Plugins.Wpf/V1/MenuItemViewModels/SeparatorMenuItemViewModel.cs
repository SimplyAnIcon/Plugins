namespace SimplyAnIcon.Plugins.Wpf.V1.MenuItemViewModels
{
    public class SeparatorMenuItemViewModel : MenuItemViewModel
    {
        public SeparatorMenuItemViewModel(MenuItemViewModel parent) : base(parent)
        {
            IsEnabled = false;
            Height = 8;
        }
    }
}
