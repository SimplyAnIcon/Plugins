using System;
using System.Collections.Generic;
using SimplyAnIcon.Plugins.V1.Settings;

namespace SimplyAnIcon.Plugins.V1
{
    /// <summary>
    /// Plugin for SimplyAnIcon
    /// </summary>
    public interface ISimplyAPlugin
    {
        /// <summary>
        /// Name of the plugin. Keep it Short !
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Description of the plugin
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Version of the plugin
        /// </summary>
        Version Version { get; }

        /// <summary>
        /// Called only one time, on plugin initialisation
        /// </summary>
        void OnInit(Dictionary<string, object> config);

        /// <summary>
        /// Called when refreshing
        /// </summary>
        void OnRefresh();

        /// <summary>
        /// Called when exiting
        /// </summary>
        void OnDispose();

        /// <summary>
        /// If null or empty, will be ignored
        /// </summary>
        IEnumerable<AbstractSettingValue> ConfigurationItems { get; }

        /// <summary>
        /// Will never be called if ConfigurationItems is null or empty
        /// </summary>
        object GetConfigurationValue(string name);

        /// <summary>
        /// Will never be called if ConfigurationItems is null or empty
        /// </summary>
        void SetConfigurationValue(string name, object value);
    }
}
