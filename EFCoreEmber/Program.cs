using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using EFCoreEmber;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        string text = "";
        using (StreamReader reader = new StreamReader("C:\\Users\\jazer\\source\\repos\\EFCoreEmber\\EFCoreEmber\\ConnectionString.json")) 
        {
            text = reader.ReadToEnd();
        }
        JsonReader jsonReader = new JsonReader(text);
        Dictionary<string, string> keyValuePairs = jsonReader.GetDeserializeJson();
        
        //Console.WriteLine(text);
    }
}