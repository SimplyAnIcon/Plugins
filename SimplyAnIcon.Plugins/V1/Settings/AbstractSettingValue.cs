using System;

namespace SimplyAnIcon.Plugins.V1.Settings
{
    /// <summary>
    /// AbstractSettingValue
    /// </summary>
    public abstract class AbstractSettingValue
    {
        /// <summary>
        /// Name
        /// </summary>
        public abstract string Name { get; }
        
        /// <summary>
        /// ValyeType
        /// </summary>
        public abstract Type ValyeType { get; }
    }
}
