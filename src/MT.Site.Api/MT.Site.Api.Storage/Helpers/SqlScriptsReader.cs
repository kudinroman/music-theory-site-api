using MT.Site.Api.Storage.Interfaces.Exceptions;
using System;
using System.IO;

namespace MT.Site.Api.Storage.Helpers
{
    public class SqlScriptsReader
    {
        internal static string GetInsertGameScript(Type type)
        {
            const string scriptFullName = "MT.Site.Api.Storage.SqlScripts.InsertGame.sql";
            var script = GetScript(scriptFullName, type);

            return script;
        }

        private static string GetScript(string scriptFullName, Type type)
        {
            var scriptResource = type.Assembly.GetManifestResourceStream(scriptFullName);
            if (scriptResource == null)
            {
                throw new LoadScriptFromAssemblyResourceException($"Failed to load {scriptFullName} script from assembly resource.");
            }

            string script;
            using (var reader = new StreamReader(scriptResource))
            {
                script = reader.ReadToEnd();
            }

            return script;
        }
    }
}
