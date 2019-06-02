namespace SimplyAnIcon.Plugins.V1.Settings
{
    /// <summary>
    /// BoolSettingValue
    /// </summary>
    public class BoolSettingValue : AbstractSettingValue
    {
        /// <summary>
        /// BoolSettingValue
        /// </summary>
        public BoolSettingValue(string key, string label)
        {
            Key = key;
            Label = label;
        }

        /// <inheritdoc />
        public override string Key { get; }

        /// <inheritdoc />
        public override string Label { get; }
    }
}
