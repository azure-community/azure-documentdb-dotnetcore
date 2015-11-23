using System;
using System.IO;
using Newtonsoft.Json;

namespace Microsoft.Azure.Documents {

    public abstract class JsonSerializable {

        /*
        //
        // Summary:
        //     Loads the object from the specified stream.
        //
        // Parameters:
        //   stream:
        //     The stream to load from.
        //
        // Type parameters:
        //   T:
        //     The type of the returning object.
        //
        // Returns:
        //     The object loaded from the specified stream.
        public static T LoadFrom<T>(Stream stream) where T : JsonSerializable, new();
        //
        // Summary:
        //     Deserializes the specified stream using the given constructor.
        //
        // Parameters:
        //   stream:
        //     The stream to load from.
        //
        //   constructorFunction:
        //     The constructor used for the returning object.
        //
        // Type parameters:
        //   T:
        //     The type of the object.
        //
        // Returns:
        //     The object loaded from the specified stream.
        public static T LoadFromWithConstructor<T>(Stream stream, Func<T> constructorFunction);
        //
        // Summary:
        //     Loads the object from the specified JSON reader.
        //
        // Parameters:
        //   reader:
        //     Loads the object from this JSON reader.
        public void LoadFrom(JsonReader reader);
        //
        // Summary:
        //     Saves the object to the specified stream.
        //
        // Parameters:
        //   stream:
        //     Saves the object to this output stream.
        //
        //   formattingPolicy:
        //     Uses an optional serialization formatting policy when saving the object. The
        //     default policy is set to None.
        public void SaveTo(Stream stream, SerializationFormattingPolicy formattingPolicy = SerializationFormattingPolicy.None);
        //
        // Summary:
        //     Returns the string representation of the object.
        //
        // Returns:
        //     The string representation of the object.
        public override string ToString();
        */
    }
}