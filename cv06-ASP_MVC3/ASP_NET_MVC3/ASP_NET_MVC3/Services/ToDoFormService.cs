using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASP_NET_MVC3.Services
{
    public class ToDoFormService
    {
        private readonly IWebHostEnvironment enc;
        public ToDoFormService(IWebHostEnvironment enc)
        {
            this.enc = enc;
        }

        public async Task Add(string text)
        {
            List<string> items = await this.GetItems();
            items.Add(text);
            await SaveItems(items);
        }
        public async Task<List<string>> GetItems()
        {
            string filePath = enc.ContentRootFileProvider.GetFileInfo("data.json").PhysicalPath;
            if (!File.Exists(filePath))
            {
                return new List<string>();
            }
            string content = await File.ReadAllTextAsync(filePath);
            List<string> items = JsonSerializer.Deserialize<List<string>>(content);
            return items;
        }

        private async Task SaveItems(List<string> items){
            string content = JsonSerializer.Serialize(items);
            string filePath = enc.ContentRootFileProvider.GetFileInfo("data.json").PhysicalPath;
            await File.WriteAllTextAsync(filePath, content);
        }

        public async Task DeleteItem(string text)
        {
            List<string> items = await GetItems();
            items.Remove(text);
            await this.SaveItems(items);
        }
    }
}
