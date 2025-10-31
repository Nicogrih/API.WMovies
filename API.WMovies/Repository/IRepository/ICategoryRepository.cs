using API.WMovies.DAL.Models;
using System.Collections.ObjectModel;

namespace API.WMovies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>>GetCategoriesAsync();//retorna una lista de categorias
        Task<Category>GetCategoryAsync(int id);//Retorna una categoria por id
        Task<bool> CategoryExistsbyidAsync(int id);
        Task<bool>CategoryExistsbyNameAsync(string name);
        Task<bool> CreateCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(Category category);
        Task<bool> DeleteCategoryAsync(int id);


    }
}
