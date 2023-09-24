using DiscordPluginAPI.Enums;

namespace DiscordPluginAPI.Interfaces
{
    public interface ILogger
    {
        public ILogBuilder LogBuilder { get; }
        public void Log(string Source, string Message, LogLevel Level, bool timeStamp = true);
    }
}
