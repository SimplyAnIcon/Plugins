using System;

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
        public BoolSettingValue(string name)
        {
            Name = name;
        }

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override Type ValyeType => typeof(bool);
    }
}
