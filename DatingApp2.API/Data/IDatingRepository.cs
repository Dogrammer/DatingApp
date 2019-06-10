using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp2.API.Helpers;
using DatingApp2.API.Models;

namespace DatingApp2.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class; // takes photo or user.
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
    }
}