using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

[assembly: CLSCompliant(true)]

namespace JsonSerialization;

public static class JsonSerializationOperations
{
    public static string SerializeObjectToJson(object obj)
    {
        throw new NotImplementedException();
    }

    public static T? DeserializeJsonToObject<T>(string json)
    {
        throw new NotImplementedException();
    }

    public static string SerializeCompanyObjectToJson(object obj)
    {
        throw new NotImplementedException();
    }

    public static T? DeserializeCompanyJsonToObject<T>(string json)
    {
        throw new NotImplementedException();
    }

    public static string SerializeDictionary(Company obj)
    {
        throw new NotImplementedException();
    }

    public static string SerializeEnum(Company obj)
    {
        throw new NotImplementedException();
    }
}
