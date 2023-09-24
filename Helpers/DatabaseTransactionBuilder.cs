using System.Collections.Generic;

namespace DiscordPluginAPI.Helpers
{
    public class DatabaseTransactionBuilder
    {
        Dictionary<string, IReadOnlyCollection<KeyValuePair<string, string>>> Queries = new();

        public void Add(string query, IReadOnlyCollection<KeyValuePair<string, string>> parameters)
        {
            Queries.Add(query, parameters);
        }
        public Dictionary<string,IReadOnlyCollection<KeyValuePair<string,string>>> Get()
        {
            return Queries;
        }
        public IReadOnlyCollection<string> GetQueries()
        {
            List<string> keys = new List<string>();
            foreach (var query in Queries) 
            {
                keys.Add(query.Key);
            }
            return keys;
        }
        public IReadOnlyCollection<KeyValuePair<string,string>> GetAllParameters()
        {
            List<KeyValuePair<string, string>> values = new();
            foreach(var query in Queries)
            {
                foreach(var parameter in query.Value)
                {
                    values.Add(parameter);
                }
            }
            return values;
        }
        public IReadOnlyCollection<KeyValuePair<string,string>> GetValue(string key)
        {
            if (Queries.ContainsKey(key)) return Queries[key];
            else return null;
        }
    }
}
