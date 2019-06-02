namespace SimplyAnIcon.Plugins.V1.Settings
{
    /// <summary>
    /// AbstractSettingValue
    /// </summary>
    public abstract class AbstractSettingValue
    {
        /// <summary>
        /// Key
        /// </summary>
        public abstract string Key { get; }

        /// <summary>
        /// Label
        /// </summary>
        public abstract string Label { get; }
    }
}
