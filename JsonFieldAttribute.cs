using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

// Step 1: Define the JsonField attribute
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

// Step 2: Apply the attribute to a User class
class User
{
    [JsonField(Name = "user_name")]
    public string Username { get; set; }

    [JsonField(Name = "user_age")]
    public int Age { get; set; }

    [JsonField(Name = "user_email")]
    public string Email { get; set; }
}

// Step 3: Implement a method to serialize the object manually
class JsonSerializerCustom
{
    public static string Serialize(object obj)
    {
        Dictionary<string, object> jsonDict = new Dictionary<string, object>();
        
        Type type = obj.GetType();
        foreach (PropertyInfo property in type.GetProperties())
        {
            object value = property.GetValue(obj);
            JsonFieldAttribute attr = (JsonFieldAttribute)Attribute.GetCustomAttribute(property, typeof(JsonFieldAttribute));

            string key = attr != null ? attr.Name : property.Name;
            jsonDict[key] = value;
        }

        return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });
    }
}

class Program
{
    static void Main()
    {
        User user = new User
        {
            Username = "JohnDoe",
            Age = 25,
            Email = "john.doe@example.com"
        };

        string jsonString = JsonSerializerCustom.Serialize
