using System;
using System.Xml.Serialization;
using System.IO;
using DiscordPluginAPI.Interfaces;
using DiscordPluginAPI.Enums;

namespace DiscordPluginAPI
{
    public class Config
    {
        public string version;
        public const string fileExtension = ".xml";
        public string configNameSuffix;
        public bool GlobalCommandCreated;
        public bool ModalsCreated;
        public string dirPath;
        public string assemblyName;
        public string pluginName;
        private ILogger Logger;
        
        
        public Config() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="GlobalCommandCreated"></param>
        /// <param name="configNameSuffix"></param>
        public Config(string dirPath, bool GlobalCommandCreated,bool ModalsCreated, string pluginName,string assemblyName, ILogger logger, string configNameSuffix = null) 
        {
            Logger = logger;
            this.assemblyName = assemblyName;
            this.pluginName = pluginName;
            this.dirPath = dirPath;
            this.GlobalCommandCreated = GlobalCommandCreated;
            this.ModalsCreated = ModalsCreated;
            if (configNameSuffix != null)
                this.configNameSuffix = configNameSuffix;
            else
                this.configNameSuffix = string.Empty;
        }
        /// <summary>
        /// Saves the file to .xml format, the argument is only <paramref name="fileName"/>, and the rest consists of the information provided in the <see cref="Config"/> class constructor. 
        /// The file is created according to the scheme: <paramref name="dirPath"/> + <paramref name="fileName"/> + <paramref name="configNameSuffix"/> + <paramref name="fileExtension"/>, where <paramref name="fileExtension"/> has a const value ".xml"
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveToXml(string fileName, ILogger logger)
        {
            try
            {
                using (var writer = new StreamWriter(dirPath + fileName + configNameSuffix + fileExtension))
                {
                    var serializer = new XmlSerializer(GetType());
                    serializer.Serialize(writer, this);
                    logger.Log(pluginName, "Config saved: " + dirPath + fileName + configNameSuffix + fileExtension, LogLevel.Info);
                    writer.Flush();
                }
            }catch (Exception ex)
            {
                logger.Log(pluginName, $"Error while saving plugin config to xml file: {ex.Message}", LogLevel.Info);
            }
        }
        /// <summary>
        /// The argument is only <paramref name="fileName"/>, and the rest consists of the information provided in the class constructor. 
        /// The file is loaded based on the path scheme: <paramref name="dirPath"/> + <paramref name="fileName"/> + <paramref name="configNameSuffix"/> + <paramref name="fileExtension"/>, where <paramref name="fileExtension"/> has a const value ".xml"
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>returns <see cref="Config"/> class object or <see langword="null"/> if file does not exists.</returns>
        public Config LoadXml(string fileName)
        {
            if (!File.Exists(dirPath + fileName + configNameSuffix + fileExtension)) return null;
            try
            {
                using (var stream = File.OpenRead(dirPath + fileName + configNameSuffix + fileExtension))
                {
                    var serializer = new XmlSerializer(typeof(Config));
                    Logger.Log(pluginName, "Config loaded: " + dirPath + fileName + configNameSuffix + fileExtension, LogLevel.Info);
                    return serializer.Deserialize(stream) as Config;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(pluginName, $"Error while loading plugin config from xml file: {ex.Message}", LogLevel.Info);
                return null;
            }
        }
    }
}
