using SocialMediaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "John Smith", Description="Cypress High School", IsContact = true },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Emma Johnson", Description="Bear River School of Fine Arts", IsContact = true },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Michael Williams", Description="Edgewater High", IsContact = false },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Daniel Jones", Description="Maple Leaf Technical School", IsContact = false },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Mia Garcia", Description="Coral Springs Institute", IsContact = false },
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}