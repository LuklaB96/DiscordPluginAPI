using System.Collections.Generic;

namespace DiscordPluginAPI.Helpers
{
    public class QueryParametersBuilder
    {
        List<KeyValuePair<string, string>> parameters = new();

        public void Add(string key, string value)
        {
            parameters.Add(new KeyValuePair<string, string>(key, value));
        }

        public KeyValuePair<string,string> Get(string key)
        {
            return parameters.Find(x => x.Key == key);
        }
        public IReadOnlyCollection<KeyValuePair<string,string>> GetAll()
        {
            return parameters;
        }
    }
}
