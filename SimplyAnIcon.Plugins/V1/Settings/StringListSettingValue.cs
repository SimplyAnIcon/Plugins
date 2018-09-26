using System;
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
        public StringListSettingValue(string key, string label, IEnumerable<KeyValuePair<string,string>> availableValues)
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

        /// <summary>
        /// MinimumLength (Default 0)
        /// </summary>
        public int MinimumLength { get; set; } = 0;

        /// <summary>
        /// MaximumLength (Default int.MaxValue)
        /// </summary>
        public int MaximumLength { get; set; } = int.MaxValue;

        /// <summary>
        /// StringType (Default Normal)
        /// </summary>
        public StringTypeEnum StringType { get; set; } = StringTypeEnum.Normal;


        /// <summary>
        /// StringTypeEnum
        /// </summary>
        public enum StringTypeEnum
        {
            /// <summary>
            /// Normal
            /// </summary>
            Normal,

            /// <summary>
            /// AllUpper
            /// </summary>
            AllUpper,

            /// <summary>
            /// AllLower
            /// </summary>
            AllLower,

            /// <summary>
            /// Password
            /// </summary>
            Password
        }
    }
}
