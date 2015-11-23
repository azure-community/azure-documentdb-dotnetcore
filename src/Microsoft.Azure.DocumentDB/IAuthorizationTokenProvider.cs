using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Documents {

    interface IAuthorizationTokenProvider {

        Task<string> GetSystemAuthorizationTokenAsync(string federationName, string resourceAddress, string resourceType, string requestVerb, NameValueCollection headers, AuthorizationTokenType tokenType);

        string GetUserAuthorizationToken(string resourceAddress, string resourceType, string requestVerb, NameValueCollection headers, AuthorizationTokenType tokenType);
    }
}