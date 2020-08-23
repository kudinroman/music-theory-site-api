using System;

namespace MT.Site.Api.Storage.Interfaces.Exceptions
{
    public class LoadScriptFromAssemblyResourceException : InvalidOperationException
    {
        public LoadScriptFromAssemblyResourceException(string message) :
            base(message)
        {
            
        }
    }
}
