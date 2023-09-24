using System;

namespace DiscordPluginAPI
{
    public class Uuid
    {
        /// <summary>
        /// Generates a standardized uuid. 
        /// </summary>
        /// <param name="name">Enter a variable called "Name", which is implemented with the interface, this is a unique identifier for each plugin.</param>
        /// <param name="suffix">It allows you to identify the purpose of the component, can be left blank.</param>
        /// <returns>Return uuid: pluginname_guid_suffix</returns>
        public static string Create(string name, string suffix = null)
        {
            string uuid = name + "_" + Guid.NewGuid().ToString();
            if (suffix != null)
            {
                uuid = uuid + "_" + suffix;
            }
            return uuid;
        }
    }
}
