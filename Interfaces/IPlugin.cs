using Discord;
using Discord.Rest;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public enum CommandType
    {
        Slash,
        Prefix,
        Both
    }
    public interface IPlugin
    {
        ILogger Logger { get; set; }
        string Name { get; set; }
        CommandType commandType { get; }
        bool ConfigRequired { get; }
        bool DatabaseRequired { get; }
        DiscordSocketClient Client { get; set; }
        Config Config { get; set; }
        List<SocketGuild> guilds { get; set; }
        Dictionary<string, string> DatabaseTableProperties { get; }
        List<string> PrefixCommands { get; }
        SlashCommandBuilder[] slashCommandBuilder { get; }
        Task<Task> Initalize(IDatabase database = null, ILogger logger = null);
        Task<Func<Task>> Update(SocketGuild guild);
        Task<Task> ClientReady();
    }
}
