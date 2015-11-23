using System;
using Newtonsoft.Json;

namespace Microsoft.Azure.Documents {

    public abstract class Resource : JsonSerializable {

        //
        // Summary:
        //     Initializes a new instance of the Microsoft.Azure.Documents.Resource class.
        //protected Resource();


        //
        // Summary:
        //     Gets the alt-link associated with the resource.
        [JsonIgnore]
        public string AltLink { get; set; }


        //
        // Summary:
        //     Gets the entity tag associated with the resource.
        //
        // Remarks:
        //     ETags are used for concurrency checking when updating resources.
        [JsonProperty(PropertyName = "_etag")]
        public string ETag { get; }


        //
        // Summary:
        //     Gets or sets the Id of the resource.
        //
        // Remarks:
        //     Every resource within a DocumentDB database account needs to have a unique identifier.
        //     Unlike Microsoft.Azure.Documents.Resource.ResourceId, which is set internally,
        //     this Id is settable by the user and is not immutable.
        //     When working with Document resources, they too have this settable Id property.
        //     If an Id is not supplied by the user the SDK will automatically generate a new
        //     GUID and assign its value to this property before persisting the Document in
        //     the database. You can override this auto Id generation by setting the disableAutomaticIdGeneration
        //     parameter on the Microsoft.Azure.Documents.Client.DocumentClient instance to
        //     true. This will prevent the SDK from generating new Ids.
        [JsonProperty(PropertyName = "id")]
        public virtual string Id { get; set; }


        //
        // Summary:
        //     Gets or sets the Resource Id associated with the resource.
        //
        // Remarks:
        //     A Resource Id is the unique, immutable, identifier assigned to each DocumentDB
        //     resource whether that is a database, a collection or a document. These resource
        //     ids are used when building up SelfLinks, a static addressable Uri for each resource
        //     within a database account.
        [JsonProperty(PropertyName = "_rid")]
        public virtual string ResourceId { get; set; }


        //
        // Summary:
        //     Gets the self-link associated with the resource.
        //
        // Remarks:
        //     A self-link is a static addressable Uri for each resource within a database account
        //     and follows the DocumentDB resource model. E.g. a self-link for a document could
        //     be dbs/db_resourceid/colls/coll_resourceid/documents/doc_resourceid
        [JsonProperty(PropertyName = "_self")]
        public string SelfLink { get; }


        //
        // Summary:
        //     Gets the last modified timestamp associated with the resource.
        //[JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty(PropertyName = "_ts")]
        public virtual DateTime Timestamp { get; internal set; }


        /*
        //
        // Summary:
        //     Gets property value associated with the specified property name.
        //
        // Parameters:
        //   propertyName:
        //     The name of the property.
        //
        // Type parameters:
        //   T:
        //     The type of the property.
        //
        // Returns:
        //     The property value.
        public T GetPropertyValue<T>(string propertyName);
        //
        // Summary:
        //     Sets property value associated with the specified property name.
        //
        // Parameters:
        //   propertyName:
        //     The name of the property.
        //
        //   propertyValue:
        //     The property value.
        public void SetPropertyValue(string propertyName, object propertyValue);
        */
    }
}