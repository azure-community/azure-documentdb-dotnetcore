using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Documents.Client {

    public class DocumentClient : IDisposable, IAuthorizationTokenProvider {

        public DocumentClient(string connectionString) {

        }

        public DocumentClient(Uri serviceEndpoint, string authKeyOrResourceToken) {

        }

        public Task<Database> CreateDatabaseAsync() {

        }

        public void Dispose() {
            throw new NotImplementedException();
        }

        public Task<string> GetSystemAuthorizationTokenAsync(string federationName, string resourceAddress, string resourceType, string requestVerb, NameValueCollection headers, AuthorizationTokenType tokenType) {
            throw new NotImplementedException();
        }

        public string GetUserAuthorizationToken(string resourceAddress, string resourceType, string requestVerb, NameValueCollection headers, AuthorizationTokenType tokenType) {
            throw new NotImplementedException();
        }

        /*
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.Azure.Documents.Client.DocumentClient
        //     class using the specified DocumentDB service endpoint, a dictionary of resource
        //     tokens and a connection policy.
        //
        // Parameters:
        //   serviceEndpoint:
        //     The service endpoint to use to create the client.
        //
        //   resourceTokens:
        //     A dictionary of resource ids and resource tokens.
        //
        //   connectionPolicy:
        //     (Optional) The connection policy for the client.
        //
        //   desiredConsistencyLevel:
        //     (Optional) The default consistency policy for client operations.
        //
        // Remarks:
        //     Using Direct connectivity, wherever possible, is recommended
        public DocumentClient(Uri serviceEndpoint, IDictionary<string, string> resourceTokens, ConnectionPolicy connectionPolicy = null, ConsistencyLevel? desiredConsistencyLevel = default(ConsistencyLevel?));
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.Azure.Documents.Client.DocumentClient
        //     class using the specified DocumentDB service endpoint, a list of permission objects
        //     and a connection policy.
        //
        // Parameters:
        //   serviceEndpoint:
        //     The service endpoint to use to create the client.
        //
        //   permissionFeed:
        //     A list of Permission objects to use to create the client.
        //
        //   connectionPolicy:
        //     (Optional) The Microsoft.Azure.Documents.Client.ConnectionPolicy to use for this
        //     connection.
        //
        //   desiredConsistencyLevel:
        //     (Optional) The default consistency policy for client operations.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If permissionFeed is not supplied.
        //
        //   T:System.ArgumentException:
        //     If permissionFeed is not a valid permission link.
        //
        // Remarks:
        //     If no connectionPolicy is provided, then the default Microsoft.Azure.Documents.Client.ConnectionPolicy
        //     will be used. Using Direct connectivity, wherever possible, is recommended.
        public DocumentClient(Uri serviceEndpoint, IList<Permission> permissionFeed, ConnectionPolicy connectionPolicy = null, ConsistencyLevel? desiredConsistencyLevel = default(ConsistencyLevel?));
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.Azure.Documents.Client.DocumentClient
        //     class using the specified service endpoint, an autorization key (or resource
        //     token) and a connection policy.
        //
        // Parameters:
        //   serviceEndpoint:
        //     The service endpoint to use to create the client.
        //
        //   authKeyOrResourceToken:
        //     The authorization key or resource token to use to create the client.
        //
        //   connectionPolicy:
        //     (Optional) The connection policy for the client.
        //
        //   desiredConsistencyLevel:
        //     (Optional) The default consistency policy for client operations.
        //
        // Remarks:
        //     The service endpoint can be obtained from the Azure Management Portal. If you
        //     are connecting using one of the Master Keys, these can be obtained along with
        //     the endpoint from the Azure Management Portal If however you are connecting as
        //     a specific DocumentDB User, the value passed to authKeyOrResourceToken is the
        //     ResourceToken obtained from the permission feed for the user.
        //     Using Direct connectivity, wherever possible, is recommended.
        public DocumentClient(Uri serviceEndpoint, string authKeyOrResourceToken, ConnectionPolicy connectionPolicy = null, ConsistencyLevel? desiredConsistencyLevel = default(ConsistencyLevel?));
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.Azure.Documents.Client.DocumentClient
        //     class using the specified DocumentDB service endpoint, key, and connection policy.
        //
        // Parameters:
        //   serviceEndpoint:
        //     The service endpoint to use to create the client.
        //
        //   authKey:
        //     The list of Permission objects to use to create the client.
        //
        //   connectionPolicy:
        //     (Optional) The connection policy for the client. If none is passed, the default
        //     is used Microsoft.Azure.Documents.Client.DocumentClient.ConnectionPolicy
        //
        //   desiredConsistencyLevel:
        //     (Optional) This can be used to weaken the database account consistency level
        //     for read operations. If this is not set the database account consistency level
        //     will be used for all requests.
        //
        // Remarks:
        //     The service endpoint and the authorization key can be obtained from the Azure
        //     Management Portal. The authKey used here is encrypted for privacy when being
        //     used, and deleted from computer memory when no longer needed
        //     Using Direct connectivity, wherever possible, is recommended
        public DocumentClient(Uri serviceEndpoint, SecureString authKey, ConnectionPolicy connectionPolicy = null, ConsistencyLevel? desiredConsistencyLevel = default(ConsistencyLevel?));

        //
        // Summary:
        //     Class destructor.
        ~DocumentClient();

        //
        // Summary:
        //     Gets the AuthKey used by the client.
        public SecureString AuthKey { get; }
        //
        // Summary:
        //     Gets the Connection policy used by the client.
        public ConnectionPolicy ConnectionPolicy { get; }
        //
        // Summary:
        //     Gets the configured consistency level of the client.
        public ConsistencyLevel ConsistencyLevel { get; }
        //
        // Summary:
        //     Partition Resolvers as a Dictionary of database link to IPartitionResolver to
        //     be used in partitioning.
        public IDictionary<string, IPartitionResolver> PartitionResolvers { get; }
        //
        // Summary:
        //     Gets a dictionary of resource tokens used by the client.
        public IDictionary<string, string> ResourceTokens { get; }
        //
        // Summary:
        //     Gets the endpoint Uri for the service endpoint.
        public Uri ServiceEndpoint { get; }
        //
        // Summary:
        //     Gets or sets the session object used for session consistency version tracking
        //
        // Remarks:
        //     The session object used for version tracking when the consistency level is set
        //     to Session. The session object can be saved and shared between two DocumentClient
        //     instances within the same AppDomain.
        public object Session { get; set; }

        //
        // Summary:
        //     Creates an Microsoft.Azure.Documents.Attachment with the contents of the provided
        //     mediaStream as an asynchronous operation.
        //
        // Parameters:
        //   attachmentsLink:
        //     The attachments link for the document. E.g. dbs/db_rid/colls/col_rid/docs/doc_rid/attachments/
        //
        //   mediaStream:
        //     the System.IO.Stream of the attachment media.
        //
        //   options:
        //     the Microsoft.Azure.Documents.Client.MediaOptions for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either attachmentsLink or mediaStream is not set.
        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(string attachmentsLink, Stream mediaStream, MediaOptions options = null);
        //
        // Summary:
        //     Creates an attachment as an asychronous operation.
        //
        // Parameters:
        //   documentLink:
        //     The self-link of the parent document for this new attachment. E.g. dbs/db_rid/colls/col_rid/docs/doc_rid/
        //
        //   attachment:
        //     The attachment object.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     The System.Threading.Tasks.Task object representing the service response for
        //     the asynchronous operation.
        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(string documentLink, object attachment, RequestOptions options = null);
        //
        // Summary:
        //     Creates an attachment as an asychronous operation.
        //
        // Parameters:
        //   documentUri:
        //     the self-link of the document to create an attachment for.
        //
        //   attachment:
        //     the attachment object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(Uri documentUri, object attachment, RequestOptions options = null);
        //
        // Summary:
        //     Creates an attachment as an asynchronous operation.
        //
        // Parameters:
        //   documentUri:
        //     the attachments link for the document.
        //
        //   mediaStream:
        //     the stream of the attachment media.
        //
        //   options:
        //     the media options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(Uri documentUri, Stream mediaStream, MediaOptions options = null);
        //
        // Summary:
        //     Extension method to create a query for attachments.
        //
        // Parameters:
        //   attachmentsUri:
        //     the link to the attachments.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<Attachment> CreateAttachmentQuery(Uri attachmentsUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for attachments.
        //
        // Parameters:
        //   attachmentsUri:
        //     the link to the attachments.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateAttachmentQuery(Uri attachmentsUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for attachments.
        //
        // Parameters:
        //   attachmentsUri:
        //     the link to the attachments.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateAttachmentQuery(Uri attachmentsUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for attachments.
        //
        // Parameters:
        //   attachmentsUri:
        //     the link to the attachments.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Type parameters:
        //   T:
        //     the type of object to query.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<T> CreateAttachmentQuery<T>(Uri attachmentsUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for attachments.
        //
        // Parameters:
        //   attachmentsUri:
        //     the link to the attachments.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IQueryable<T> CreateAttachmentQuery<T>(Uri attachmentsUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for attachments.
        //
        // Parameters:
        //   attachmentsUri:
        //     the link to the attachments.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IQueryable<T> CreateAttachmentQuery<T>(Uri attachmentsUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for conflicts.
        //
        // Parameters:
        //   conflictsUri:
        //     the link to the conflicts.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<Conflict> CreateConflictQuery(Uri conflictsUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for conflicts.
        //
        // Parameters:
        //   conflictsUri:
        //     the link to the conflicts.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateConflictQuery(Uri conflictsUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for conflicts.
        //
        // Parameters:
        //   conflictsUri:
        //     the link to the conflicts.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateConflictQuery(Uri conflictsUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Creates a database resource as an asychronous operation.
        //
        // Parameters:
        //   database:
        //     The specification for the Microsoft.Azure.Documents.Database to create.
        //
        //   options:
        //     (Optional) The Microsoft.Azure.Documents.Client.RequestOptions for the request.
        //
        // Returns:
        //     The Microsoft.Azure.Documents.Database that was created within a task object
        //     representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If database is not set
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Database are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the database object supplied. It is likely
        //     that an id was not supplied for the new Database. 409Conflict - This means a
        //     Microsoft.Azure.Documents.Database with an id matching the id field of database
        //     already existed
        public Task<ResourceResponse<Database>> CreateDatabaseAsync(Database database, RequestOptions options = null);
        //
        // Summary:
        //     Creates a document as an asychronous operation.
        //
        // Parameters:
        //   documentCollectionUri:
        //     the self-link of the collection to create the document in.
        //
        //   document:
        //     the document object.
        //
        //   options:
        //     The request options for the request.
        //
        //   disableAutomaticIdGeneration:
        //     Disables the automatic id generation, will throw an exception if id is missing.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Document>> CreateDocumentAsync(Uri documentCollectionUri, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false);
        //
        // Summary:
        //     Creates a Document as an asychronous operation.
        //
        // Parameters:
        //   documentsFeedOrDatabaseLink:
        //     The self-link of the Microsoft.Azure.Documents.DocumentCollection to create the
        //     document in. E.g. dbs/db_rid/colls/coll_rid/docs/
        //
        //   document:
        //     The document object to create.
        //
        //   options:
        //     (Optional) Any request options you wish to set. E.g. Specifying a Trigger to
        //     execute when creating the document. Microsoft.Azure.Documents.Client.RequestOptions
        //
        //   disableAutomaticIdGeneration:
        //     (Optional) Disables the automatic id generation, If this is True the system will
        //     throw an exception if the id property is missing from the Document.
        //
        // Returns:
        //     The Microsoft.Azure.Documents.Document that was created contained within a System.Threading.Tasks.Task
        //     object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either documentsFeedOrDatabaseLink or document is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the document supplied. It is likely that
        //     disableAutomaticIdGeneration was true and an id was not supplied 403Forbidden
        //     - This likely means the collection in to which you were trying to create the
        //     document is full. 409Conflict - This means a Microsoft.Azure.Documents.Document
        //     with an id matching the id field of document already existed 413RequestEntityTooLarge
        //     - This means the Microsoft.Azure.Documents.Document exceeds the current max entity
        //     size. Consult documentation for limits and quotas. 429TooManyRequests - This
        //     means you have exceeded the number of request units per second. Consult the DocumentClientException.RetryAfter
        //     value to see how long you should wait before retrying this operation.
        public Task<ResourceResponse<Document>> CreateDocumentAsync(string documentsFeedOrDatabaseLink, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false);
        //
        // Summary:
        //     Creates a collection as an asychronous operation.
        //
        // Parameters:
        //   databaseUri:
        //     the self-link of the database to create the collection in.
        //
        //   documentCollection:
        //     the Microsoft.Azure.Documents.DocumentCollection object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<DocumentCollection>> CreateDocumentCollectionAsync(Uri databaseUri, DocumentCollection documentCollection, RequestOptions options = null);
        //
        // Summary:
        //     Creates a collection as an asychronous operation.
        //
        // Parameters:
        //   databaseLink:
        //     The self-link of the database to create the collection in. E.g. dbs/db_rid/
        //
        //   documentCollection:
        //     The Microsoft.Azure.Documents.DocumentCollection object.
        //
        //   options:
        //     (Optional) Any Microsoft.Azure.Documents.Client.RequestOptions you wish to provide
        //     when creating a Collection. E.g. RequestOptions.OfferType="S1".
        //
        // Returns:
        //     The Microsoft.Azure.Documents.DocumentCollection that was created contained within
        //     a System.Threading.Tasks.Task object representing the service response for the
        //     asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either databaseLink or documentCollection is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. It is likely that
        //     an id was not supplied for the new collection. 403Forbidden - This means you
        //     attempted to exceed your quota for collections. Contact support to have this
        //     quota increased. 409Conflict - This means a Microsoft.Azure.Documents.DocumentCollection
        //     with an id matching the id you supplied already existed.
        public Task<ResourceResponse<DocumentCollection>> CreateDocumentCollectionAsync(string databaseLink, DocumentCollection documentCollection, RequestOptions options = null);
        //
        // Summary:
        //     Extension method to create a query for document collections.
        //
        // Parameters:
        //   databaseUri:
        //     the link to the collections.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<DocumentCollection> CreateDocumentCollectionQuery(Uri databaseUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for document collections.
        //
        // Parameters:
        //   databaseUri:
        //     the link to the collections.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateDocumentCollectionQuery(Uri databaseUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for document collections.
        //
        // Parameters:
        //   databaseUri:
        //     the link to the collections.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateDocumentCollectionQuery(Uri databaseUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for documents.
        //
        // Parameters:
        //   documentCollectionOrDatabaseUri:
        //     The URI of the document collection, e.g. dbs/db_rid/colls/coll_rid/. Alternatively,
        //     this can be a URI of the database when using an Microsoft.Azure.Documents.Client.IPartitionResolver,
        //     e.g. dbs/db_rid/
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        //   partitionKey:
        //     Optional partition key that can be used with an IPartitionResolver.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<Document> CreateDocumentQuery(Uri documentCollectionOrDatabaseUri, FeedOptions feedOptions = null, object partitionKey = null);
        //
        // Summary:
        //     Extension method to create a query for documents.
        //
        // Parameters:
        //   documentCollectionOrDatabaseUri:
        //     The URI of the document collection, e.g. dbs/db_rid/colls/coll_rid/. Alternatively,
        //     this can be a URI of the database when using an Microsoft.Azure.Documents.Client.IPartitionResolver,
        //     e.g. dbs/db_rid/
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        //   partitionKey:
        //     Optional partition key that can be used with an IPartitionResolver.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateDocumentQuery(Uri documentCollectionOrDatabaseUri, string sqlExpression, FeedOptions feedOptions = null, object partitionKey = null);
        //
        // Summary:
        //     Extension method to create a query for documents.
        //
        // Parameters:
        //   documentCollectionOrDatabaseUri:
        //     The URI of the document collection, e.g. dbs/db_rid/colls/coll_rid/. Alternatively,
        //     this can be a URI of the database when using an Microsoft.Azure.Documents.Client.IPartitionResolver,
        //     e.g. dbs/db_rid/
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        //   partitionKey:
        //     Optional partition key that can be used with an IPartitionResolver.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateDocumentQuery(Uri documentCollectionOrDatabaseUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null, object partitionKey = null);
        //
        // Summary:
        //     Extension method to create a query for documents.
        //
        // Parameters:
        //   documentCollectionOrDatabaseUri:
        //     The URI of the document collection, e.g. dbs/db_rid/colls/coll_rid/. Alternatively,
        //     this can be a URI of the database when using an Microsoft.Azure.Documents.Client.IPartitionResolver,
        //     e.g. dbs/db_rid/
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        //   partitionKey:
        //     Optional partition key that can be used with an IPartitionResolver.
        //
        // Type parameters:
        //   T:
        //     the type of object to query.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<T> CreateDocumentQuery<T>(Uri documentCollectionOrDatabaseUri, FeedOptions feedOptions = null, object partitionKey = null);
        //
        // Summary:
        //     Extension method to create a query for documents.
        //
        // Parameters:
        //   documentCollectionOrDatabaseUri:
        //     The URI of the document collection, e.g. dbs/db_rid/colls/coll_rid/. Alternatively,
        //     this can be a URI of the database when using an Microsoft.Azure.Documents.Client.IPartitionResolver,
        //     e.g. dbs/db_rid/
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        //   partitionKey:
        //     Optional partition key that can be used with an IPartitionResolver.
        //
        // Type parameters:
        //   T:
        //     the type of object to query.
        //
        // Returns:
        //     the query result set.
        public IQueryable<T> CreateDocumentQuery<T>(Uri documentCollectionOrDatabaseUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null, object partitionKey = null);
        //
        // Summary:
        //     Extension method to create a query for documents.
        //
        // Parameters:
        //   documentCollectionOrDatabaseUri:
        //     The URI of the document collection, e.g. dbs/db_rid/colls/coll_rid/. Alternatively,
        //     this can be a URI of the database when using an Microsoft.Azure.Documents.Client.IPartitionResolver,
        //     e.g. dbs/db_rid/
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        //   partitionKey:
        //     Optional partition key that can be used with an IPartitionResolver.
        //
        // Type parameters:
        //   T:
        //     the type of object to query.
        //
        // Returns:
        //     the query result set.
        public IQueryable<T> CreateDocumentQuery<T>(Uri documentCollectionOrDatabaseUri, string sqlExpression, FeedOptions feedOptions = null, object partitionKey = null);
        //
        // Summary:
        //     Creates a permission on a user object as an asychronous operation.
        //
        // Parameters:
        //   userLink:
        //     The self-link of the user to create the permission for. E.g. dbs/db_rid/users/user_rid/
        //
        //   permission:
        //     The Microsoft.Azure.Documents.Permission object.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation
        //     which contains the created Microsoft.Azure.Documents.Permission object.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either userLink or permission is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. 403Forbidden - You
        //     have reached your quota of permission objects. Contact support to have this quota
        //     increased. 409Conflict - This means a Microsoft.Azure.Documents.Permission with
        //     an id matching the id you supplied already existed.
        public Task<ResourceResponse<Permission>> CreatePermissionAsync(string userLink, Permission permission, RequestOptions options = null);
        //
        // Summary:
        //     Creates a permission as an asychronous operation.
        //
        // Parameters:
        //   userUri:
        //     the self-link of the user to create the permission for.
        //
        //   permission:
        //     the Microsoft.Azure.Documents.Permission object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Permission>> CreatePermissionAsync(Uri userUri, Permission permission, RequestOptions options = null);
        //
        // Summary:
        //     Extension method to create a query for permissions.
        //
        // Parameters:
        //   permissionsUri:
        //     the link to the permissions.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<Permission> CreatePermissionQuery(Uri permissionsUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for permissions.
        //
        // Parameters:
        //   permissionsUri:
        //     the link to the permissions.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreatePermissionQuery(Uri permissionsUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for permissions.
        //
        // Parameters:
        //   permissionsUri:
        //     the link to the permissions.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreatePermissionQuery(Uri permissionsUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Creates a stored procedure as an asychronous operation.
        //
        // Parameters:
        //   collectionLink:
        //     The self-link of the collection to create the stored procedure in. E.g. dbs/db_rid/colls/col_rid/
        //
        //   storedProcedure:
        //     The Microsoft.Azure.Documents.StoredProcedure object to create.
        //
        //   options:
        //     (Optional) Any Microsoft.Azure.Documents.Client.RequestOptionsfor this request.
        //
        // Returns:
        //     The Microsoft.Azure.Documents.StoredProcedure that was created contained within
        //     a System.Threading.Tasks.Task object representing the service response for the
        //     asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either collectionLink or storedProcedure is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. It is likely that
        //     an Id was not supplied for the stored procedure or the Body was malformed. 403Forbidden
        //     - You have reached your quota of stored procedures for the collection supplied.
        //     Contact support to have this quota increased. 409Conflict - This means a Microsoft.Azure.Documents.StoredProcedure
        //     with an id matching the id you supplied already existed. 413RequestEntityTooLarge
        //     - This means the body of the Microsoft.Azure.Documents.StoredProcedure you tried
        //     to create was too large.
        public Task<ResourceResponse<StoredProcedure>> CreateStoredProcedureAsync(string collectionLink, StoredProcedure storedProcedure, RequestOptions options = null);
        //
        // Summary:
        //     Creates a stored procedure as an asychronous operation.
        //
        // Parameters:
        //   collectionUri:
        //     the self-link of the collection to create the stored procedure in.
        //
        //   storedProcedure:
        //     the Microsoft.Azure.Documents.StoredProcedure object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<StoredProcedure>> CreateStoredProcedureAsync(Uri collectionUri, StoredProcedure storedProcedure, RequestOptions options = null);
        //
        // Summary:
        //     Extension method to create query for stored procedures.
        //
        // Parameters:
        //   storedProceduresUri:
        //     the link to the stored procedures.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<StoredProcedure> CreateStoredProcedureQuery(Uri storedProceduresUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create query for stored procedures.
        //
        // Parameters:
        //   storedProceduresUri:
        //     the link to the stored procedures.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateStoredProcedureQuery(Uri storedProceduresUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create query for stored procedures.
        //
        // Parameters:
        //   storedProceduresUri:
        //     the link to the stored procedures.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateStoredProcedureQuery(Uri storedProceduresUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Creates a trigger as an asychronous operation.
        //
        // Parameters:
        //   collectionLink:
        //     The self-link of the Microsoft.Azure.Documents.DocumentCollection to create the
        //     trigger in. E.g. dbs/db_rid/colls/col_rid/
        //
        //   trigger:
        //     The Microsoft.Azure.Documents.Trigger object to create.
        //
        //   options:
        //     (Optional) Any Microsoft.Azure.Documents.Client.RequestOptionsfor this request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either collectionLink or trigger is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. It is likely that
        //     an Id was not supplied for the new trigger or that the Body was malformed. 403Forbidden
        //     - You have reached your quota of triggers for the collection supplied. Contact
        //     support to have this quota increased. 409Conflict - This means a Microsoft.Azure.Documents.Trigger
        //     with an id matching the id you supplied already existed. 413RequestEntityTooLarge
        //     - This means the body of the Microsoft.Azure.Documents.Trigger you tried to create
        //     was too large.
        public Task<ResourceResponse<Trigger>> CreateTriggerAsync(string collectionLink, Trigger trigger, RequestOptions options = null);
        //
        // Summary:
        //     Creates a trigger as an asychronous operation.
        //
        // Parameters:
        //   collectionUri:
        //     the self-link of the collection to create the trigger in.
        //
        //   trigger:
        //     the Microsoft.Azure.Documents.Trigger object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Trigger>> CreateTriggerAsync(Uri collectionUri, Trigger trigger, RequestOptions options = null);
        //
        // Summary:
        //     Extension method to create query for triggers.
        //
        // Parameters:
        //   triggersUri:
        //     the link to the triggers.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<Trigger> CreateTriggerQuery(Uri triggersUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create query for triggers.
        //
        // Parameters:
        //   triggersUri:
        //     the link to the triggers.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateTriggerQuery(Uri triggersUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create query for triggers.
        //
        // Parameters:
        //   triggersUri:
        //     the link to the triggers.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateTriggerQuery(Uri triggersUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Creates a user as an asychronous operation.
        //
        // Parameters:
        //   databaseUri:
        //     the self-link of the database to create the user in.
        //
        //   user:
        //     the Microsoft.Azure.Documents.User object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<User>> CreateUserAsync(Uri databaseUri, User user, RequestOptions options = null);
        //
        // Summary:
        //     Creates a permission on a user object as an asychronous operation.
        //
        // Parameters:
        //   databaseLink:
        //     The self-link of the database to create the user in. E.g. dbs/db_rid/
        //
        //   user:
        //     The Microsoft.Azure.Documents.User object to create.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation
        //     which contains the created Microsoft.Azure.Documents.User object.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either databaseLink or user is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. 403Forbidden - You
        //     have reached your quota of user objects for this database. Contact support to
        //     have this quota increased. 409Conflict - This means a Microsoft.Azure.Documents.User
        //     with an id matching the id you supplied already existed.
        public Task<ResourceResponse<User>> CreateUserAsync(string databaseLink, User user, RequestOptions options = null);
        //
        // Summary:
        //     Creates a user defined function as an asychronous operation.
        //
        // Parameters:
        //   collectionLink:
        //     The self-link of the Microsoft.Azure.Documents.DocumentCollection to create the
        //     user defined function in. E.g. dbs/db_rid/colls/col_rid/
        //
        //   function:
        //     The Microsoft.Azure.Documents.UserDefinedFunction object to create.
        //
        //   options:
        //     (Optional) Any Microsoft.Azure.Documents.Client.RequestOptionsfor this request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either collectionLink or function is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. It is likely that
        //     an Id was not supplied for the new user defined function or that the Body was
        //     malformed. 403Forbidden - You have reached your quota of user defined functions
        //     for the collection supplied. Contact support to have this quota increased. 409Conflict
        //     - This means a Microsoft.Azure.Documents.UserDefinedFunction with an id matching
        //     the id you supplied already existed. 413RequestEntityTooLarge - This means the
        //     body of the Microsoft.Azure.Documents.UserDefinedFunction you tried to create
        //     was too large.
        public Task<ResourceResponse<UserDefinedFunction>> CreateUserDefinedFunctionAsync(string collectionLink, UserDefinedFunction function, RequestOptions options = null);
        //
        // Summary:
        //     Creates a user defined function as an asychronous operation.
        //
        // Parameters:
        //   collectionUri:
        //     the self-link of the collection to create the user defined function in.
        //
        //   function:
        //     the Microsoft.Azure.Documents.UserDefinedFunction object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<UserDefinedFunction>> CreateUserDefinedFunctionAsync(Uri collectionUri, UserDefinedFunction function, RequestOptions options = null);
        //
        // Summary:
        //     Extension method to create a query for user-defined functions.
        //
        // Parameters:
        //   userDefinedFunctionsUri:
        //     the link to the user-defined functions.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<UserDefinedFunction> CreateUserDefinedFunctionQuery(Uri userDefinedFunctionsUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for user-defined functions.
        //
        // Parameters:
        //   userDefinedFunctionsUri:
        //     the link to the user-defined functions.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateUserDefinedFunctionQuery(Uri userDefinedFunctionsUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for user-defined functions.
        //
        // Parameters:
        //   userDefinedFunctionsUri:
        //     the link to the user-defined functions.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateUserDefinedFunctionQuery(Uri userDefinedFunctionsUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for users.
        //
        // Parameters:
        //   usersUri:
        //     the link to the users.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        public IOrderedQueryable<User> CreateUserQuery(Uri usersUri, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for users.
        //
        // Parameters:
        //   usersUri:
        //     the link to the users.
        //
        //   querySpec:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateUserQuery(Uri usersUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Extension method to create a query for users.
        //
        // Parameters:
        //   usersUri:
        //     the link to the users.
        //
        //   sqlExpression:
        //     the sql query.
        //
        //   feedOptions:
        //     the options for processing the query results feed.
        //
        // Returns:
        //     the query result set.
        [return: Dynamic(new[] { false, true })]
        public IQueryable<dynamic> CreateUserQuery(Uri usersUri, string sqlExpression, FeedOptions feedOptions = null);
        //
        // Summary:
        //     Delete an attachment as an asynchronous operation.
        //
        // Parameters:
        //   attachmentUri:
        //     the self-link of the attachment to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Attachment>> DeleteAttachmentAsync(Uri attachmentUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete an Microsoft.Azure.Documents.Attachment from the database as an asynchronous
        //     operation.
        //
        // Parameters:
        //   attachmentLink:
        //     The self-link of the Microsoft.Azure.Documents.Attachment to delete. E.g. dbs/db_rid/colls/col_rid/docs/doc_rid/attachments/attachment_rid/
        //
        //   options:
        //     (Optional) Any options you wish to set for this request.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If attachmentLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Attachment>> DeleteAttachmentAsync(string attachmentLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a conflict as an asynchronous operation.
        //
        // Parameters:
        //   conflictUri:
        //     the self-link of the conflict to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Conflict>> DeleteConflictAsync(Uri conflictUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.Conflict as an asynchronous operation.
        //
        // Parameters:
        //   conflictLink:
        //     The self-link of the Microsoft.Azure.Documents.Conflict to delete. E.g. dbs/db_rid/colls/coll_rid/conflicts/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If conflictLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Conflict>> DeleteConflictAsync(string conflictLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a database as an asynchronous operation.
        //
        // Parameters:
        //   databaseUri:
        //     the self-link of the database to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Database>> DeleteDatabaseAsync(Uri databaseUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.Database as an asynchronous operation.
        //
        // Parameters:
        //   databaseLink:
        //     The self-link of the Microsoft.Azure.Documents.Database to delete. E.g. dbs/db_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If databaseLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Database>> DeleteDatabaseAsync(string databaseLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a document as an asynchronous operation.
        //
        // Parameters:
        //   documentUri:
        //     the self-link of the document to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Document>> DeleteDocumentAsync(Uri documentUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.Document as an asynchronous operation.
        //
        // Parameters:
        //   documentLink:
        //     The self-link of the Microsoft.Azure.Documents.Document to delete. E.g. dbs/db_rid/colls/col_rid/docs/doc_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If documentLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Document>> DeleteDocumentAsync(string documentLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.DocumentCollection as an asynchronous operation.
        //
        // Parameters:
        //   documentCollectionLink:
        //     The self-link of the Microsoft.Azure.Documents.Document to delete. E.g. dbs/db_rid/colls/col_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If documentCollectionLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<DocumentCollection>> DeleteDocumentCollectionAsync(string documentCollectionLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a collection as an asynchronous operation.
        //
        // Parameters:
        //   documentCollectionUri:
        //     the self-link of the collection to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<DocumentCollection>> DeleteDocumentCollectionAsync(Uri documentCollectionUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.Permission as an asynchronous operation.
        //
        // Parameters:
        //   permissionLink:
        //     The self-link of the Microsoft.Azure.Documents.Permission to delete. E.g. dbs/db_rid/users/user_rid/permissions/permission_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If permissionLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Permission>> DeletePermissionAsync(string permissionLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a permission as an asynchronous operation.
        //
        // Parameters:
        //   permissionUri:
        //     the self-link of the trigger to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Permission>> DeletePermissionAsync(Uri permissionUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.StoredProcedure as an asynchronous operation.
        //
        // Parameters:
        //   storedProcedureLink:
        //     The self-link of the Microsoft.Azure.Documents.StoredProcedure to delete. E.g.
        //     dbs/db_rid/colls/col_rid/sprocs/sproc_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If storedProcedureLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<StoredProcedure>> DeleteStoredProcedureAsync(string storedProcedureLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a stored procedure as an asynchronous operation.
        //
        // Parameters:
        //   storedProcedureUri:
        //     the self-link of the stored procedure to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<StoredProcedure>> DeleteStoredProcedureAsync(Uri storedProcedureUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.Trigger as an asynchronous operation.
        //
        // Parameters:
        //   triggerLink:
        //     The self-link of the Microsoft.Azure.Documents.Trigger to delete. E.g. dbs/db_rid/colls/col_rid/triggers/trigger_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If triggerLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Trigger>> DeleteTriggerAsync(string triggerLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a trigger as an asynchronous operation.
        //
        // Parameters:
        //   triggerUri:
        //     the self-link of the trigger to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Trigger>> DeleteTriggerAsync(Uri triggerUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.User as an asynchronous operation.
        //
        // Parameters:
        //   userLink:
        //     The self-link of the Microsoft.Azure.Documents.User to delete. E.g. dbs/db_rid/users/user_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If userLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<User>> DeleteUserAsync(string userLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a user as an asynchronous operation.
        //
        // Parameters:
        //   userUri:
        //     the self-link of the user to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<User>> DeleteUserAsync(Uri userUri, RequestOptions options = null);
        //
        // Summary:
        //     Delete a Microsoft.Azure.Documents.UserDefinedFunction as an asynchronous operation.
        //
        // Parameters:
        //   functionLink:
        //     The self-link of the Microsoft.Azure.Documents.UserDefinedFunction to delete.
        //     E.g. dbs/db_rid/colls/col_rid/udfs/udf_rid/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which will contain information about the request issued.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If functionLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<UserDefinedFunction>> DeleteUserDefinedFunctionAsync(string functionLink, RequestOptions options = null);
        //
        // Summary:
        //     Delete a user defined function as an asynchronous operation.
        //
        // Parameters:
        //   functionUri:
        //     the self-link of the trigger to delete.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<UserDefinedFunction>> DeleteUserDefinedFunctionAsync(Uri functionUri, RequestOptions options = null);
        //
        // Summary:
        //     Disposes the client.
        public void Dispose();
        //
        // Summary:
        //     Executes a stored procedure against a collection as an asynchronous operation.
        //
        // Parameters:
        //   storedProcedureUri:
        //     the self-link to the collection.
        //
        //   procedureParams:
        //     the parameters for the stored procedure execution.
        //
        // Type parameters:
        //   TValue:
        //     the type of the stored procedure's return value.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<StoredProcedureResponse<TValue>> ExecuteStoredProcedureAsync<TValue>(Uri storedProcedureUri, [Dynamic(new[] { false, true })] params dynamic[] procedureParams);
        //
        // Summary:
        //     Executes a stored procedure against a collection as an asynchronous operation.
        //
        // Parameters:
        //   storedProcedureLink:
        //     The self-link to the stored procedure to execute.
        //
        //   procedureParams:
        //     (Optional) An array of dynamic objects representing the parameters for the stored
        //     procedure.
        //
        // Type parameters:
        //   TValue:
        //     The type of the stored procedure's return value.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation
        //     which would contain any response set in the stored procedure.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If storedProcedureLink is not set.
        public Task<StoredProcedureResponse<TValue>> ExecuteStoredProcedureAsync<TValue>(string storedProcedureLink, [Dynamic(new[] { false, true })] params dynamic[] procedureParams);
        //
        // Summary:
        //     Read the Microsoft.Azure.Documents.DatabaseAccount as an asynchronous operation.
        //
        // Returns:
        //     A Microsoft.Azure.Documents.DatabaseAccount wrapped in a System.Threading.Tasks.Task
        //     object.
        public Task<DatabaseAccount> GetDatabaseAccountAsync();
        //
        // Summary:
        //     Open the connection to validate that the client initialization is successful.
        //
        // Returns:
        //     A System.Threading.Tasks.Task object.
        //
        // Remarks:
        //     This method is recommended to be called, after the constructor, but before calling
        //     any other methods on the DocumentClient instance. If there are any initialization
        //     exceptions, this method will throw them (set on the task). Alternately, calling
        //     any API will throw initialization exception at the first call.
        public Task OpenAsync();
        //
        // Summary:
        //     Reads an Microsoft.Azure.Documents.Attachment as an asynchronous operation.
        //
        // Parameters:
        //   attachmentLink:
        //     The link to the attachment to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Attachment containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If attachmentLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the Database if you prefer. A self-link is a URI for a resource that
        //     is made up of Resource Identifiers (or the _rid properties). ID-based links and
        //     SelfLink will both work. The format for attachmentLink is always "/dbs/{db identifier}/colls/{coll
        //     identifier}/docs/{doc identifier}/attachments/{attachment identifier}" only the
        //     values within the {} change depending on which method you wish to use to address
        //     the resource.
        public Task<ResourceResponse<Attachment>> ReadAttachmentAsync(string attachmentLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads an Microsoft.Azure.Documents.Attachment as an asynchronous operation.
        //
        // Parameters:
        //   attachmentUri:
        //     A URI to the Attachment resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps an Microsoft.Azure.Documents.Attachment containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If attachmentUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<Attachment>> ReadAttachmentAsync(Uri attachmentUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.Attachment for a document
        //     as an asynchronous operation.
        //
        // Parameters:
        //   attachmentsLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/colls/coll_rid/docs/doc_rid/attachments/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Attachment containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If attachmentsLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<Attachment>> ReadAttachmentFeedAsync(string attachmentsLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of attachments for a document as an asynchronous operation.
        //
        // Parameters:
        //   attachmentsUri:
        //     the link for the attachments.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<Attachment>> ReadAttachmentFeedAsync(Uri attachmentsUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Conflict as an asynchronous operation.
        //
        // Parameters:
        //   conflictLink:
        //     The link to the Conflict to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Conflict containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If conflictLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the Conflict if you prefer. A self-link is a URI for a resource that
        //     is made up of Resource Identifiers (or the _rid properties). ID-based links and
        //     SelfLink will both work. The format for conflictLink is always "/dbs/{db identifier}/colls/{collectioon
        //     identifier}/conflicts/{conflict identifier}" only the values within the {...}
        //     change depending on which method you wish to use to address the resource.
        public Task<ResourceResponse<Conflict>> ReadConflictAsync(string conflictLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Conflict as an asynchronous operation.
        //
        // Parameters:
        //   conflictUri:
        //     A URI to the Conflict resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Conflict containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If conflictUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<Conflict>> ReadConflictAsync(Uri conflictUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.Conflict for a collection
        //     as an asynchronous operation.
        //
        // Parameters:
        //   conflictsLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/colls/coll_rid/conflicts/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Conflict containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If conflictsLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<Conflict>> ReadConflictFeedAsync(string conflictsLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of conflicts for a collection as an asynchronous operation.
        //
        // Parameters:
        //   conflictsUri:
        //     the link for the conflicts.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<Conflict>> ReadConflictFeedAsync(Uri conflictsUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Database as an asynchronous operation.
        //
        // Parameters:
        //   databaseUri:
        //     A URI to the Database resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Database containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If databaseUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<Database>> ReadDatabaseAsync(Uri databaseUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Database as an asynchronous operation.
        //
        // Parameters:
        //   databaseLink:
        //     The link of the Database resource to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Database containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If databaseLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the Database if you prefer. A self-link is a URI for a resource that
        //     is made up of Resource Identifiers (or the _rid properties). ID-based links and
        //     SelfLink will both work. The format for databaseLink is always "/dbs/{db identifier}"
        //     only the values within the {} change depending on which method you wish to use
        //     to address the resource.
        public Task<ResourceResponse<Database>> ReadDatabaseAsync(string databaseLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.Database for a database
        //     account as an asynchronous operation.
        //
        // Parameters:
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Database containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        public Task<FeedResponse<Database>> ReadDatabaseFeedAsync(FeedOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Document as an asynchronous operation.
        //
        // Parameters:
        //   documentLink:
        //     The link for the document to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Document containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If documentLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the Document if you prefer. A self-link is a URI for a resource that
        //     is made up of Resource Identifiers (or the _rid properties). ID-based links and
        //     SelfLink will both work. The format for documentLink is always "/dbs/{db identifier}/colls/{coll
        //     identifier}/docs/{doc identifier}" only the values within the {} change depending
        //     on which method you wish to use to address the resource.
        public Task<ResourceResponse<Document>> ReadDocumentAsync(string documentLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Document as an asynchronous operation.
        //
        // Parameters:
        //   documentUri:
        //     A URI to the Document resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Document containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If documentUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<Document>> ReadDocumentAsync(Uri documentUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.DocumentCollection as an asynchronous operation.
        //
        // Parameters:
        //   documentCollectionLink:
        //     The link for the DocumentCollection to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.DocumentCollection containing the read
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If documentCollectionLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the DocumentCollection if you prefer. A self-link is a URI for a
        //     resource that is made up of Resource Identifiers (or the _rid properties). ID-based
        //     links and SelfLink will both work. The format for documentCollectionLink is always
        //     "/dbs/{db identifier}/colls/{coll identifier}" only the values within the {}
        //     change depending on which method you wish to use to address the resource.
        public Task<ResourceResponse<DocumentCollection>> ReadDocumentCollectionAsync(string documentCollectionLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.DocumentCollection as an asynchronous operation.
        //
        // Parameters:
        //   documentCollectionUri:
        //     A URI to the DocumentCollection resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.DocumentCollection containing the read
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If documentCollectionUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<DocumentCollection>> ReadDocumentCollectionAsync(Uri documentCollectionUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of collections for a database as an asynchronous operation.
        //
        // Parameters:
        //   collectionsUri:
        //     the link for the collections.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<DocumentCollection>> ReadDocumentCollectionFeedAsync(Uri collectionsUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.DocumentCollection for
        //     a database as an asynchronous operation.
        //
        // Parameters:
        //   collectionsLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/colls/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.DocumentCollection containing the read
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If collectionsLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<DocumentCollection>> ReadDocumentCollectionFeedAsync(string collectionsLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of documents for a collection as an asynchronous operation.
        //
        // Parameters:
        //   documentsUri:
        //     the link for the documents.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        [return: Dynamic(new[] { false, false, true })]
        public Task<FeedResponse<dynamic>> ReadDocumentFeedAsync(Uri documentsUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of documents for a specified collection. This takes
        //     returns a Microsoft.Azure.Documents.Client.ResourceResponse`1 which will contain
        //     an enumerable list of dynamic objects.
        //
        // Parameters:
        //   documentsLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/colls/coll_rid/docs/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     containing dynamic objects representing the items in the feed.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If documentsLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        //
        // Remarks:
        //     Instead of FeedResponse{Document} this method takes advantage of dynamic objects
        //     in .NET. This way a single feed result can contain any kind of Document, or POCO
        //     object. This is important becuse a DocumentCollection can contain different kinds
        //     of documents.
        [return: Dynamic(new[] { false, false, true })]
        public Task<FeedResponse<dynamic>> ReadDocumentFeedAsync(string documentsLink, FeedOptions options = null);
        //
        // Summary:
        //     Retrieves the specified attachment content (aka media).
        //
        // Parameters:
        //   mediaLink:
        //     The self-link for the media to read. E.g. /medias/media_rid
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If mediaLink is not set.
        //
        //   T:System.ArgumentException:
        //     If mediaLink is not in the form of /medias/{mediaId}.
        public Task<MediaResponse> ReadMediaAsync(string mediaLink);
        //
        // Summary:
        //     Retrieves the metadata associated with the specified attachment content (aka
        //     media) as an asynchronous operation.
        //
        // Parameters:
        //   mediaLink:
        //     the self-link for the media to read metadata for. E.g. /medias/media_rid
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If mediaLink is not set.
        //
        //   T:System.ArgumentException:
        //     If mediaLink is not in the form of /medias/{mediaId}.
        public Task<MediaResponse> ReadMediaMetadataAsync(string mediaLink);
        //
        // Summary:
        //     Reads an Microsoft.Azure.Documents.Offer as an asynchronous operation.
        //
        // Parameters:
        //   offerLink:
        //     The link to the Offer to be read.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Offer containing the read resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If offerLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     For an Offer, id is always generated internally by the system when the linked
        //     resource is created. id and _rid are always the same for Offer.
        //     The format for offerLink is always "/offers/{offer identifier}"
        public Task<ResourceResponse<Offer>> ReadOfferAsync(string offerLink);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.Offer for a database account
        //     as an asynchronous operation.
        //
        // Parameters:
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Offer containing the read resource record.
        //
        // Exceptions:
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        public Task<FeedResponse<Offer>> ReadOffersFeedAsync(FeedOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Permission resource as an asynchronous operation.
        //
        // Parameters:
        //   permissionUri:
        //     A URI to the Permission resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Permission containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If permissionUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<Permission>> ReadPermissionAsync(Uri permissionUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Permission as an asynchronous operation.
        //
        // Parameters:
        //   permissionLink:
        //     The link for the Permission resource to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Permission containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If permissionLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the Permission if you prefer. A self-link is a URI for a resource
        //     that is made up of Resource Identifiers (or the _rid properties). ID-based links
        //     and SelfLink will both work. The format for permissionLink is always "/dbs/{db
        //     identifier}/users/{user identifier}/permissions/{permission identifier}" only
        //     the values within the {...} change depending on which method you wish to use
        //     to address the resource.
        public Task<ResourceResponse<Permission>> ReadPermissionAsync(string permissionLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.Permission for a user
        //     as an asynchronous operation.
        //
        // Parameters:
        //   permissionsLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/users/user_rid/permissions/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Permission containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If permissionsLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<Permission>> ReadPermissionFeedAsync(string permissionsLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of permissions for a user as an asynchronous operation.
        //
        // Parameters:
        //   permissionsUri:
        //     the link for the permissions.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<Permission>> ReadPermissionFeedAsync(Uri permissionsUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.StoredProcedure as an asynchronous operation.
        //
        // Parameters:
        //   storedProcedureLink:
        //     The link of the stored procedure to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.StoredProcedure containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If storedProcedureLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the Stored Procedure if you prefer. A self-link is a URI for a resource
        //     that is made up of Resource Identifiers (or the _rid properties). ID-based links
        //     and SelfLink will both work. The format for storedProcedureLink is always "/dbs/{db
        //     identifier}/colls/{coll identifier}/sprocs/{sproc identifier}" only the values
        //     within the {...} change depending on which method you wish to use to address
        //     the resource.
        public Task<ResourceResponse<StoredProcedure>> ReadStoredProcedureAsync(string storedProcedureLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.StoredProcedure as an asynchronous operation.
        //
        // Parameters:
        //   storedProcedureUri:
        //     A URI to the StoredProcedure resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.StoredProcedure containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If storedProcedureUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<StoredProcedure>> ReadStoredProcedureAsync(Uri storedProcedureUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.StoredProcedure for a
        //     collection as an asynchronous operation.
        //
        // Parameters:
        //   storedProceduresLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/colls/col_rid/sprocs/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.StoredProcedure containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If storedProceduresLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<StoredProcedure>> ReadStoredProcedureFeedAsync(string storedProceduresLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of stored procedures for a collection as an asynchronous
        //     operation.
        //
        // Parameters:
        //   storedProceduresUri:
        //     the link for the stored procedures.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<StoredProcedure>> ReadStoredProcedureFeedAsync(Uri storedProceduresUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Trigger as an asynchronous operation.
        //
        // Parameters:
        //   triggerLink:
        //     The link to the Trigger to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Trigger containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If triggerLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the Trigger if you prefer. A self-link is a URI for a resource that
        //     is made up of Resource Identifiers (or the _rid properties). ID-based links and
        //     SelfLink will both work. The format for triggerLink is always "/dbs/{db identifier}/colls/{coll
        //     identifier}/triggers/{trigger identifier}" only the values within the {...} change
        //     depending on which method you wish to use to address the resource.
        public Task<ResourceResponse<Trigger>> ReadTriggerAsync(string triggerLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.Trigger as an asynchronous operation.
        //
        // Parameters:
        //   triggerUri:
        //     A URI to the Trigger resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Trigger containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If triggerUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<Trigger>> ReadTriggerAsync(Uri triggerUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of triggers for a collection as an asynchronous operation.
        //
        // Parameters:
        //   triggersUri:
        //     the link for the triggers.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<Trigger>> ReadTriggerFeedAsync(Uri triggersUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.Trigger for a collection
        //     as an asynchronous operation.
        //
        // Parameters:
        //   triggersLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/colls/col_rid/triggers/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Trigger containing the read resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If triggersLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<Trigger>> ReadTriggerFeedAsync(string triggersLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.User as an asynchronous operation.
        //
        // Parameters:
        //   userLink:
        //     The link to the User resource to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.User containing the read resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If userLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the User if you prefer. A self-link is a URI for a resource that
        //     is made up of Resource Identifiers (or the _rid properties). ID-based links and
        //     SelfLink will both work. The format for userLink is always "/dbs/{db identifier}/users/{user
        //     identifier}" only the values within the {...} change depending on which method
        //     you wish to use to address the resource.
        public Task<ResourceResponse<User>> ReadUserAsync(string userLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.User as an asynchronous operation.
        //
        // Parameters:
        //   userUri:
        //     A URI to the User resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.User containing the read resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If userUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<User>> ReadUserAsync(Uri userUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.UserDefinedFunction as an asynchronous operation.
        //
        // Parameters:
        //   functionLink:
        //     The link to the User Defined Function to be read.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.UserDefinedFunction containing the read
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If functionLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     Database. If you know the resource's ID, do a read instead of a query by ID.
        //     The example shown uses ID-based links, where the link is composed of the ID properties
        //     used when the resources were created. You can still use the Microsoft.Azure.Documents.Resource.SelfLink
        //     property of the User Defined Function if you prefer. A self-link is a URI for
        //     a resource that is made up of Resource Identifiers (or the _rid properties).
        //     ID-based links and SelfLink will both work. The format for functionLink is always
        //     "/dbs/{db identifier}/colls/{coll identifier}/udfs/{udf identifier}" only the
        //     values within the {...} change depending on which method you wish to use to address
        //     the resource.
        public Task<ResourceResponse<UserDefinedFunction>> ReadUserDefinedFunctionAsync(string functionLink, RequestOptions options = null);
        //
        // Summary:
        //     Reads a Microsoft.Azure.Documents.UserDefinedFunction as an asynchronous operation.
        //
        // Parameters:
        //   functionUri:
        //     A URI to the User Defined Function resource to be read.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.UserDefinedFunction containing the read
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If functionUri is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to read did not exist. 429TooManyRequests
        //     - This means you have exceeded the number of request units per second. Consult
        //     the DocumentClientException.RetryAfter value to see how long you should wait
        //     before retrying this operation.
        //
        // Remarks:
        //     Doing a read of a resource is the most efficient way to get a resource from the
        //     service. If you know the resource's ID, do a read instead of a query by ID.
        public Task<ResourceResponse<UserDefinedFunction>> ReadUserDefinedFunctionAsync(Uri functionUri, RequestOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of user defined functions for a collection as an asynchronous
        //     operation.
        //
        // Parameters:
        //   userDefinedFunctionsUri:
        //     the link for the user defined functions.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<UserDefinedFunction>> ReadUserDefinedFunctionFeedAsync(Uri userDefinedFunctionsUri, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.UserDefinedFunction for
        //     a collection as an asynchronous operation.
        //
        // Parameters:
        //   userDefinedFunctionsLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/colls/col_rid/udfs/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.UserDefinedFunction containing the read
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If userDefinedFunctionsLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<UserDefinedFunction>> ReadUserDefinedFunctionFeedAsync(string userDefinedFunctionsLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of Microsoft.Azure.Documents.User for a database as
        //     an asynchronous operation.
        //
        // Parameters:
        //   usersLink:
        //     The SelfLink of the resources to be read. E.g. /dbs/db_rid/users/
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.User containing the read resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If usersLink is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource feed you tried to read did not exist. Check the parent
        //     rids are correct. 429TooManyRequests - This means you have exceeded the number
        //     of request units per second. Consult the DocumentClientException.RetryAfter value
        //     to see how long you should wait before retrying this operation.
        public Task<FeedResponse<User>> ReadUserFeedAsync(string usersLink, FeedOptions options = null);
        //
        // Summary:
        //     Reads the feed (sequence) of users for a database as an asynchronous operation.
        //
        // Parameters:
        //   usersUri:
        //     the link for the users.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<FeedResponse<User>> ReadUserFeedAsync(Uri usersUri, FeedOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.Attachment as an asynchronous operation.
        //
        // Parameters:
        //   attachment:
        //     The updated Microsoft.Azure.Documents.Attachment to replace the existing resource
        //     with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Attachment containing the updated resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If attachment is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Attachment>> ReplaceAttachmentAsync(Attachment attachment, RequestOptions options = null);
        //
        // Summary:
        //     Replaces an attachment as an asynchronous operation.
        //
        // Parameters:
        //   attachmentsUri:
        //     the updated attachment.
        //
        //   attachment:
        //     the attachment resource.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Attachment>> ReplaceAttachmentAsync(Uri attachmentsUri, Attachment attachment, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.Document as an asynchronous operation.
        //
        // Parameters:
        //   document:
        //     The updated Microsoft.Azure.Documents.Document to replace the existing resource
        //     with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Document containing the updated resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If document is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Document>> ReplaceDocumentAsync(Document document, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a document as an asynchronous operation.
        //
        // Parameters:
        //   documentCollectionUri:
        //     the self-link of the document to be updated.
        //
        //   document:
        //     the updated document.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Document>> ReplaceDocumentAsync(Uri documentCollectionUri, object document, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.Document as an asynchronous operation.
        //
        // Parameters:
        //   documentSelfLink:
        //     the self-link of the document to be updated. E.g. dbs/db_rid/colls/col_rid/docs/doc_rid/
        //
        //   document:
        //     The updated Microsoft.Azure.Documents.Document to replace the existing resource
        //     with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Document containing the updated resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either documentSelfLink or document is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Document>> ReplaceDocumentAsync(string documentSelfLink, object document, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a document collection as an asynchronous operation.
        //
        // Parameters:
        //   documentCollection:
        //     the updated document collection.
        //
        //   options:
        //     the request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<DocumentCollection>> ReplaceDocumentCollectionAsync(DocumentCollection documentCollection, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a document collection as an asynchronous operation.
        //
        // Parameters:
        //   documentCollectionUri:
        //     the self-link of the document collection to be updated.
        //
        //   documentCollection:
        //     the updated document collection.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<DocumentCollection>> ReplaceDocumentCollectionAsync(Uri documentCollectionUri, DocumentCollection documentCollection, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.Offer as an asynchronous operation.
        //
        // Parameters:
        //   offer:
        //     The updated Microsoft.Azure.Documents.Offer to replace the existing resource
        //     with.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Offer containing the updated resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If offer is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Offer>> ReplaceOfferAsync(Offer offer);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.Permission as an asynchronous operation.
        //
        // Parameters:
        //   permission:
        //     The updated Microsoft.Azure.Documents.Permission to replace the existing resource
        //     with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Permission containing the updated resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If permission is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Permission>> ReplacePermissionAsync(Permission permission, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a permission as an asynchronous operation.
        //
        // Parameters:
        //   permissionUri:
        //     the self-link for the attachment.
        //
        //   permission:
        //     the updated permission.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Permission>> ReplacePermissionAsync(Uri permissionUri, Permission permission, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.StoredProcedure as an asynchronous operation.
        //
        // Parameters:
        //   storedProcedure:
        //     The updated Microsoft.Azure.Documents.StoredProcedure to replace the existing
        //     resource with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.StoredProcedure containing the updated
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If storedProcedure is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<StoredProcedure>> ReplaceStoredProcedureAsync(StoredProcedure storedProcedure, RequestOptions options = null);
        //
        // Summary:
        //     Replace the specified stored procedure.
        //
        // Parameters:
        //   storedProcedureUri:
        //     the self-link for the attachment.
        //
        //   storedProcedure:
        //     the updated stored procedure.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<StoredProcedure>> ReplaceStoredProcedureAsync(Uri storedProcedureUri, StoredProcedure storedProcedure, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.Trigger as an asynchronous operation.
        //
        // Parameters:
        //   trigger:
        //     The updated Microsoft.Azure.Documents.Trigger to replace the existing resource
        //     with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.Trigger containing the updated resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If trigger is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<Trigger>> ReplaceTriggerAsync(Trigger trigger, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a trigger as an asynchronous operation.
        //
        // Parameters:
        //   triggerUri:
        //     the self-link for the attachment.
        //
        //   trigger:
        //     the updated trigger.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Trigger>> ReplaceTriggerAsync(Uri triggerUri, Trigger trigger, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.User as an asynchronous operation.
        //
        // Parameters:
        //   user:
        //     The updated Microsoft.Azure.Documents.User to replace the existing resource with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.User containing the updated resource
        //     record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If user is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<User>> ReplaceUserAsync(User user, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a user as an asynchronous operation.
        //
        // Parameters:
        //   userUri:
        //     the self-link for the attachment.
        //
        //   user:
        //     the updated user.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<User>> ReplaceUserAsync(Uri userUri, User user, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a Microsoft.Azure.Documents.UserDefinedFunction as an asynchronous operation.
        //
        // Parameters:
        //   function:
        //     The updated Microsoft.Azure.Documents.UserDefinedFunction to replace the existing
        //     resource with.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A System.Threading.Tasks containing a Microsoft.Azure.Documents.Client.ResourceResponse`1
        //     which wraps a Microsoft.Azure.Documents.UserDefinedFunction containing the updated
        //     resource record.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If function is not set.
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 404NotFound
        //     - This means the resource you tried to delete did not exist.
        public Task<ResourceResponse<UserDefinedFunction>> ReplaceUserDefinedFunctionAsync(UserDefinedFunction function, RequestOptions options = null);
        //
        // Summary:
        //     Replaces a user defined function as an asynchronous operation.
        //
        // Parameters:
        //   userDefinedFunctionUri:
        //     the self-link for the attachment.
        //
        //   function:
        //     the updated user defined function.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<UserDefinedFunction>> ReplaceUserDefinedFunctionAsync(Uri userDefinedFunctionUri, UserDefinedFunction function, RequestOptions options = null);
        //
        // Summary:
        //     Replaces the specified media's content as an asynchronous operation.
        //
        // Parameters:
        //   mediaLink:
        //     The self-link for the media to be updated. /medias/media_rid
        //
        //   mediaStream:
        //     The System.IO.Stream of the attachment media.
        //
        //   options:
        //     The Microsoft.Azure.Documents.Client.MediaOptions for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either mediaLink or mediaStream is not set.
        //
        //   T:System.ArgumentException:
        //     If mediaLink is not in the form of /medias/{mediaId}.
        public Task<MediaResponse> UpdateMediaAsync(string mediaLink, Stream mediaStream, MediaOptions options = null);
        //
        // Summary:
        //     Upserts an attachment as an asynchronous operation.
        //
        // Parameters:
        //   documentUri:
        //     the URI of the document to upsert an attachment for.
        //
        //   mediaStream:
        //     the stream of the attachment media.
        //
        //   options:
        //     the media options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Attachment>> UpsertAttachmentAsync(Uri documentUri, Stream mediaStream, MediaOptions options = null);
        //
        // Summary:
        //     Upserts an attachment as an asychronous operation.
        //
        // Parameters:
        //   documentLink:
        //     The self-link of the parent document for this new attachment. E.g. dbs/db_rid/colls/col_rid/docs/doc_rid/
        //
        //   attachment:
        //     The attachment object.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     The System.Threading.Tasks.Task object representing the service response for
        //     the asynchronous operation.
        public Task<ResourceResponse<Attachment>> UpsertAttachmentAsync(string documentLink, object attachment, RequestOptions options = null);
        //
        // Summary:
        //     Upserts an attachment as an asychronous operation.
        //
        // Parameters:
        //   documentUri:
        //     the URI of the document to upsert an attachment for.
        //
        //   attachment:
        //     the attachment object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Attachment>> UpsertAttachmentAsync(Uri documentUri, object attachment, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a Document as an asychronous operation.
        //
        // Parameters:
        //   documentsFeedOrDatabaseLink:
        //     The self-link of the Microsoft.Azure.Documents.DocumentCollection to upsert the
        //     document in. E.g. dbs/db_rid/colls/coll_rid/docs/
        //
        //   document:
        //     The document object to upsert.
        //
        //   options:
        //     (Optional) Any request options you wish to set. E.g. Specifying a Trigger to
        //     execute when creating the document. Microsoft.Azure.Documents.Client.RequestOptions
        //
        //   disableAutomaticIdGeneration:
        //     (Optional) Disables the automatic id generation, If this is True the system will
        //     throw an exception if the id property is missing from the Document.
        //
        // Returns:
        //     The Microsoft.Azure.Documents.Document that was upserted contained within a System.Threading.Tasks.Task
        //     object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either documentsFeedOrDatabaseLink or document is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the document supplied. It is likely that
        //     disableAutomaticIdGeneration was true and an id was not supplied 403Forbidden
        //     - This likely means the collection in to which you were trying to upsert the
        //     document is full. 409Conflict - This means a Microsoft.Azure.Documents.Document
        //     with an id matching the id field of document already existed 413RequestEntityTooLarge
        //     - This means the Microsoft.Azure.Documents.Document exceeds the current max entity
        //     size. Consult documentation for limits and quotas. 429TooManyRequests - This
        //     means you have exceeded the number of request units per second. Consult the DocumentClientException.RetryAfter
        //     value to see how long you should wait before retrying this operation.
        public Task<ResourceResponse<Document>> UpsertDocumentAsync(string documentsFeedOrDatabaseLink, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false);
        //
        // Summary:
        //     Upserts a document as an asychronous operation.
        //
        // Parameters:
        //   documentCollectionUri:
        //     the URI of the collection to upsert the document in.
        //
        //   document:
        //     the document object.
        //
        //   options:
        //     The request options for the request.
        //
        //   disableAutomaticIdGeneration:
        //     Disables the automatic id generation, will throw an exception if id is missing.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Document>> UpsertDocumentAsync(Uri documentCollectionUri, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false);
        //
        // Summary:
        //     Upserts a permission on a user object as an asychronous operation.
        //
        // Parameters:
        //   userLink:
        //     The self-link of the user to Upsert the permission for. E.g. dbs/db_rid/users/user_rid/
        //
        //   permission:
        //     The Microsoft.Azure.Documents.Permission object.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation
        //     which contains the upserted Microsoft.Azure.Documents.Permission object.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either userLink or permission is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. 403Forbidden - You
        //     have reached your quota of permission objects. Contact support to have this quota
        //     increased. 409Conflict - This means a Microsoft.Azure.Documents.Permission with
        //     an id matching the id you supplied already existed.
        public Task<ResourceResponse<Permission>> UpsertPermissionAsync(string userLink, Permission permission, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a permission as an asychronous operation.
        //
        // Parameters:
        //   userUri:
        //     the URI of the user to upsert the permission for.
        //
        //   permission:
        //     the Microsoft.Azure.Documents.Permission object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Permission>> UpsertPermissionAsync(Uri userUri, Permission permission, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a stored procedure as an asychronous operation.
        //
        // Parameters:
        //   collectionLink:
        //     The self-link of the collection to upsert the stored procedure in. E.g. dbs/db_rid/colls/col_rid/
        //
        //   storedProcedure:
        //     The Microsoft.Azure.Documents.StoredProcedure object to upsert.
        //
        //   options:
        //     (Optional) Any Microsoft.Azure.Documents.Client.RequestOptionsfor this request.
        //
        // Returns:
        //     The Microsoft.Azure.Documents.StoredProcedure that was upserted contained within
        //     a System.Threading.Tasks.Task object representing the service response for the
        //     asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either collectionLink or storedProcedure is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. It is likely that
        //     an Id was not supplied for the stored procedure or the Body was malformed. 403Forbidden
        //     - You have reached your quota of stored procedures for the collection supplied.
        //     Contact support to have this quota increased. 409Conflict - This means a Microsoft.Azure.Documents.StoredProcedure
        //     with an id matching the id you supplied already existed. 413RequestEntityTooLarge
        //     - This means the body of the Microsoft.Azure.Documents.StoredProcedure you tried
        //     to upsert was too large.
        public Task<ResourceResponse<StoredProcedure>> UpsertStoredProcedureAsync(string collectionLink, StoredProcedure storedProcedure, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a stored procedure as an asychronous operation.
        //
        // Parameters:
        //   collectionUri:
        //     the URI of the collection to upsert the stored procedure in.
        //
        //   storedProcedure:
        //     the Microsoft.Azure.Documents.StoredProcedure object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<StoredProcedure>> UpsertStoredProcedureAsync(Uri collectionUri, StoredProcedure storedProcedure, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a trigger as an asychronous operation.
        //
        // Parameters:
        //   collectionLink:
        //     The self-link of the Microsoft.Azure.Documents.DocumentCollection to upsert the
        //     trigger in. E.g. dbs/db_rid/colls/col_rid/
        //
        //   trigger:
        //     The Microsoft.Azure.Documents.Trigger object to upsert.
        //
        //   options:
        //     (Optional) Any Microsoft.Azure.Documents.Client.RequestOptionsfor this request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either collectionLink or trigger is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. It is likely that
        //     an Id was not supplied for the new trigger or that the Body was malformed. 403Forbidden
        //     - You have reached your quota of triggers for the collection supplied. Contact
        //     support to have this quota increased. 409Conflict - This means a Microsoft.Azure.Documents.Trigger
        //     with an id matching the id you supplied already existed. 413RequestEntityTooLarge
        //     - This means the body of the Microsoft.Azure.Documents.Trigger you tried to upsert
        //     was too large.
        public Task<ResourceResponse<Trigger>> UpsertTriggerAsync(string collectionLink, Trigger trigger, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a trigger as an asychronous operation.
        //
        // Parameters:
        //   collectionUri:
        //     the URI of the collection to upsert the trigger in.
        //
        //   trigger:
        //     the Microsoft.Azure.Documents.Trigger object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<Trigger>> UpsertTriggerAsync(Uri collectionUri, Trigger trigger, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a permission on a user object as an asychronous operation.
        //
        // Parameters:
        //   databaseLink:
        //     The self-link of the database to upsert the user in. E.g. dbs/db_rid/
        //
        //   user:
        //     The Microsoft.Azure.Documents.User object to upsert.
        //
        //   options:
        //     (Optional) The request options for the request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation
        //     which contains the upserted Microsoft.Azure.Documents.User object.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either databaseLink or user is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. 403Forbidden - You
        //     have reached your quota of user objects for this database. Contact support to
        //     have this quota increased. 409Conflict - This means a Microsoft.Azure.Documents.User
        //     with an id matching the id you supplied already existed.
        public Task<ResourceResponse<User>> UpsertUserAsync(string databaseLink, User user, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a user as an asychronous operation.
        //
        // Parameters:
        //   databaseUri:
        //     the URI of the database to upsert the user in.
        //
        //   user:
        //     the Microsoft.Azure.Documents.User object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<User>> UpsertUserAsync(Uri databaseUri, User user, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a user defined function as an asychronous operation.
        //
        // Parameters:
        //   collectionUri:
        //     the URI of the collection to upsert the user defined function in.
        //
        //   function:
        //     the Microsoft.Azure.Documents.UserDefinedFunction object.
        //
        //   options:
        //     The request options for the request.
        //
        // Returns:
        //     The task object representing the service response for the asynchronous operation.
        public Task<ResourceResponse<UserDefinedFunction>> UpsertUserDefinedFunctionAsync(Uri collectionUri, UserDefinedFunction function, RequestOptions options = null);
        //
        // Summary:
        //     Upserts a user defined function as an asychronous operation.
        //
        // Parameters:
        //   collectionLink:
        //     The self-link of the Microsoft.Azure.Documents.DocumentCollection to upsert the
        //     user defined function in. E.g. dbs/db_rid/colls/col_rid/
        //
        //   function:
        //     The Microsoft.Azure.Documents.UserDefinedFunction object to upsert.
        //
        //   options:
        //     (Optional) Any Microsoft.Azure.Documents.Client.RequestOptionsfor this request.
        //
        // Returns:
        //     A task object representing the service response for the asynchronous operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     If either collectionLink or function is not set.
        //
        //   T:System.AggregateException:
        //     Represents a consolidation of failures that occured during async processing.
        //     Look within InnerExceptions to find the actual exception(s)
        //
        //   T:Microsoft.Azure.Documents.DocumentClientException:
        //     This exception can encapsulate many different types of errors. To determine the
        //     specific error always look at the StatusCode property. Some common codes you
        //     may get when creating a Document are: StatusCodeReason for exception 400BadRequest
        //     - This means something was wrong with the request supplied. It is likely that
        //     an Id was not supplied for the new user defined function or that the Body was
        //     malformed. 403Forbidden - You have reached your quota of user defined functions
        //     for the collection supplied. Contact support to have this quota increased. 409Conflict
        //     - This means a Microsoft.Azure.Documents.UserDefinedFunction with an id matching
        //     the id you supplied already existed. 413RequestEntityTooLarge - This means the
        //     body of the Microsoft.Azure.Documents.UserDefinedFunction you tried to upsert
        //     was too large.
        public Task<ResourceResponse<UserDefinedFunction>> UpsertUserDefinedFunctionAsync(string collectionLink, UserDefinedFunction function, RequestOptions options = null);
        */
    }
}