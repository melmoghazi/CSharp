using Microsoft.Extensions.Caching.Memory;

namespace DemoInMemoryCaching.Models
{
    public class SampleDataAccess
    {
        private readonly IMemoryCache _memoryCache;

        //Microsoft.Extensions.Caching.Memory
        public SampleDataAccess(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            List<CategoryModel> categories = new();
            categories.Add(new CategoryModel { Id = 1, Name = "Computers" });
            categories.Add(new CategoryModel { Id = 1, Name = "TV" });
            categories.Add(new CategoryModel { Id = 1, Name = "Laptops" });
            categories.Add(new CategoryModel { Id = 1, Name = "Keyboards" });
            categories.Add(new CategoryModel { Id = 1, Name = "Mouses" });

            await Task.Delay(3000);

            return categories;
        }

        public async Task<List<CategoryModel>> GetCategoriesCache()
        {
            List<CategoryModel> categories;
            categories = _memoryCache.Get<List<CategoryModel>>(key: "categories");
            if (categories is null)
            {
                categories = new();

                categories.Add(new CategoryModel { Id = 1, Name = "Computers" });
                categories.Add(new CategoryModel { Id = 1, Name = "TV" });
                categories.Add(new CategoryModel { Id = 1, Name = "Laptops" });
                categories.Add(new CategoryModel { Id = 1, Name = "Keyboards" });
                categories.Add(new CategoryModel { Id = 1, Name = "Mouses" });

                await Task.Delay(3000);

                _memoryCache.Set(key: "categories", categories, TimeSpan.FromMinutes(1));
            }
            return categories;
        }

    }
}
