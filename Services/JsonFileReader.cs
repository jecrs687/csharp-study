using System.Text.Json;
using dot_net_study.Models;
using Microsoft.Extensions.Configuration;

namespace dot_net_study.Services
{
    public class JsonFileReader
    {
        private IConfiguration _configuration;

        public JsonFileReader(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ReadJson()
        {
            for (int i = 1; i <= 3; i++)
            {
                var jsonReader = new JsonFileReader(_configuration);
                var item = jsonReader.processFile(i);
                Console.WriteLine(item[0].id);
            }
        }
        public Item[] processFile(int filename)
        {
            Item[] item = Read<Item[]>(_configuration.GetSection("BasePath").Value + $"{filename}.json");
            return item;

        }
        private T Read<T>(string filePath)
        {
            string text = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(text);
        }
    }
}

