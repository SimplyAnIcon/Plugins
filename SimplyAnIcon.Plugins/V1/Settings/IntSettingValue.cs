using System;

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
        public IntSettingValue(string name)
        {
            Name = name;
        }

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override Type ValyeType => typeof(int);

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
