using System.Collections.Generic;

namespace SimplyAnIcon.Plugins.V1.Settings
{
    /// <summary>
    /// StringSettingValue
    /// </summary>
    public class StringListSettingValue : AbstractSettingValue
    {

        /// <summary>
        /// StringSettingValue
        /// </summary>
        public StringListSettingValue(string key, string label, IEnumerable<KeyValuePair<string, string>> availableValues)
        {
            AvailableValues = availableValues;
            Key = key;
            Label = label;
        }

        /// <inheritdoc />
        public override string Key { get; }

        /// <inheritdoc />
        public override string Label { get; }

        /// <summary>
        /// List the available values, Key being the unique key, Value being the Text
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> AvailableValues { get; }
    }
}
