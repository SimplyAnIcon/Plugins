using System;
using System.Collections.Generic;

namespace SimplyAnIcon.Plugins.V1
{
    public interface ISimplyAPlugin
    {
        string Name { get; }
        string Description { get; }
        Version Version { get; }
        void OnInit();
        void OnRefresh();
        void OnDispose();

        /// <summary>
        /// If null or empty, will be ignored
        /// </summary>
        Dictionary<string,Type> ConfigurationItems { get; }

        /// <summary>
        /// Will never be called if ConfigurationItems is null or empty
        /// </summary>
        object GetConfigurationValue(string key);

        /// <summary>
        /// Will never be called if ConfigurationItems is null or empty
        /// </summary>
        void SetConfigurationValue(string key, object value);
    }
}
