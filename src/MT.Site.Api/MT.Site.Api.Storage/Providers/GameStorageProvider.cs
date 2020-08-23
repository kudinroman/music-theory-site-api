using Dapper;
using MT.Site.Api.Storage.Helpers;
using MT.Site.Api.Storage.Interfaces.Models;
using MT.Site.Api.Storage.Interfaces.Providers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MT.Site.Api.Storage.Providers
{
    public sealed class GameStorageProvider : IGameStorageProvider
    {
        public async Task InsertGameAsync(GameStorageModel model)
        {
            var requestStatement = SqlScriptsReader.GetInsertGameScript(GetType());
            var parameters = GetQueryParameters(model);

            using (IDbConnection db = new SqlConnection("Server=.\\SQLEXPRESS;Database=MusicTheory;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                try
                {
                    await db.ExecuteAsync(requestStatement, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        private static object GetQueryParameters(GameStorageModel model)
        {
            return new
            {
                player_name = model.PlayerName,
                level = model.Level,
                score = model.Score
            };
        }
    }
}
