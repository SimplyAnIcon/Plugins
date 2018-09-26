using System;

namespace SimplyAnIcon.Plugins.V1.Settings
{
    /// <summary>
    /// StringSettingValue
    /// </summary>
    public class StringSettingValue : AbstractSettingValue
    {
        /// <summary>
        /// StringSettingValue
        /// </summary>
        public StringSettingValue(string name)
        {
            Name = name;
        }

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override Type ValyeType => typeof(string);

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
