namespace SimplyAnIcon.Plugins.V1.Settings
{
    /// <summary>
    /// IntSettingValue
    /// </summary>
    public class IntSettingValue : AbstractSettingValue
    {
        /// <summary>
        /// IntSettingValue
        /// </summary>
        public IntSettingValue(string key, string label)
        {
            Key = key;
            Label = label;
        }

        /// <inheritdoc />
        public override string Key { get; }

        /// <inheritdoc />
        public override string Label { get; }

        /// <summary>
        /// Minimum (Default int.MinValue)
        /// </summary>
        public int Minimum { get; set; } = int.MinValue;

        /// <summary>
        /// Maximum (Default int.MaxValue)
        /// </summary>
        public int Maximum { get; set; } = int.MaxValue;
    }
}
