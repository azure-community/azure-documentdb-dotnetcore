using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Documents {

    internal enum AuthorizationTokenType {
        Invalid = 0,
        PrimaryMasterKey = 1,
        PrimaryReadonlyMasterKey = 2,
        SecondaryMasterKey = 3,
        SecondaryReadonlyMasterKey = 4,
        SystemReadOnly = 5,
        SystemReadWrite = 6,
        SystemAll = 7,
        ResourceToken = 8
    }
}