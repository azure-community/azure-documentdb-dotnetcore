using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Documents {

    public class Database : Resource {

        //
        // Summary:
        //     Gets the self-link for collections in the database.
        //
        // Remarks:
        //     Every DocumentDB resource has a static, immutable, addressable URI. For collections,
        //     this takes the form of; /dbs/db_rid/colls/ where db_rid represents the value
        //     of the database's resource id. A resource id is not the id given to a database
        //     on creation, but an internally generated immutable id.
        [JsonProperty(PropertyName = "_colls")]
        public string CollectionsLink { get; }


        //
        // Summary:
        //     Gets the self-link for users in the database.
        //
        // Remarks:
        //     Every DocumentDB resource has a static, immutable, addressable URI. For users,
        //     this takes the form of; /dbs/db_rid/users/ where db_rid represents the value
        //     of the database's resource id. A resource id is not the id given to a database
        //     on creation, but an internally generated immutable id.
        [JsonProperty(PropertyName = "_users")]
        public string UsersLink { get; }
    }
}