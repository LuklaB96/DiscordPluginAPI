using DiscordPluginAPI.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IDatabase
    {
        private static string connectionString { get; set; }
        Task Initalize();
        Task<int> UpdateQueryAsync(string query, QueryParametersBuilder parameters = null, Config config = null);
        Task<int> UpdateTransactionQueryAsync(DatabaseTransactionBuilder transactionBuilder = null, Dictionary<string, List<KeyValuePair<string, string>>> queries = null, Config config = null);
        Task<int> DeleteQueryAsync(string query, QueryParametersBuilder parameters = null, Config config = null);
        Task<int> DeleteTransactionQueryAsync(DatabaseTransactionBuilder transactionBuilder = null, Dictionary<string, List<KeyValuePair<string, string>>> queries = null, Config config = null);
        Task<int> InsertQueryAsync(string query, QueryParametersBuilder parameters = null, Config config = null);
        Task<int> InsertTransactionQueryAsync(DatabaseTransactionBuilder transactionBuilder = null, Dictionary<string,List<KeyValuePair<string,string>>> queries = null, Config config = null);
        Task<List<string>> SelectQueryAsync(string query, QueryParametersBuilder parameters = null, Config config = null);
    }
}
