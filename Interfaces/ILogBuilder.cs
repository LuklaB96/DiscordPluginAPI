using DiscordPluginAPI.Enums;
using System;

namespace DiscordPluginAPI.Interfaces
{
    public interface ILogBuilder
    {
        public LogLevel Level { get; }
        public string Message { get; }
        public string Source { get; }
        public bool TimeStamp { get; }
        public string Log();
        public string Log(LogLevel level, string message, string source, bool timeStamp = true, DateTimeKind dateTimeKind = DateTimeKind.Local);
    }
}
