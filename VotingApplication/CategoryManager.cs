using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApplication
{
    public class CategoryManager
    {
        public List<Category> _categories;

        public CategoryManager()
        {
            _categories = new List<Category>()
            {
                new Category{Id = 1, Name = "Çubuklu"},
                new Category{Id = 2, Name = "Düz Siyah"},
                new Category{Id = 3, Name = "Düz Beyaz"},
                new Category{Id = 4, Name = "Beyaz Forma - Siyah Şort"},
                new Category{Id = 5, Name = "Siyah - Beyaz - Kırmızı"}
            };
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetCategory(int id)
        {
            return _categories[id];
        }
    }
}
