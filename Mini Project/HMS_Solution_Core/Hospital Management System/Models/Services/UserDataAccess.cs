using Hospital_Management_System.models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.Models.Services
{
    public class UserDataAccess : IDbAccess<UserTable, int>
    {
        HMS_ProjectContext context;
        public UserDataAccess(HMS_ProjectContext context)
        {
            this.context = context;
        }


        async Task<UserTable> IDbAccess<UserTable, int>.CreateAsync(UserTable entity)
        {
            var res = await context.Users.AddAsync(entity);
            await context.SaveChangesAsync();
            return res.Entity;
        }

        async Task<UserTable> IDbAccess<UserTable, int>.DeleteAsync(int id)
        {
            var user = await context.Users.FindAsync(id);
            
            if (user==null)
            {
                throw new Exception();
            }
            else
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
                return user;
            }
        }

        async Task<IEnumerable<UserTable>> IDbAccess<UserTable, int>.GetAsync()
        {
            var users = await context.Users.ToListAsync();
            return users;

        }

       async Task<UserTable> IDbAccess<UserTable, int>.GetAsync(int id)
        {
            var user = await context.Users.FindAsync(id);
            return user;
        }

        async Task<UserTable> IDbAccess<UserTable, int>.UpdateAsync(int id, UserTable entity)
        {
            var user = await context.Users.FindAsync(id);

            if (user != null)
            {
                user.UserId = entity.UserId;
                user.FirstName = entity.FirstName;
                user.LastName = entity.LastName;
                user.Email = entity.Email;
                user.Password = entity.Password;
                user.Age = entity.Age;
                user.ContactNumber = entity.ContactNumber;
                user.Gender = entity.Gender;
                user.StaffCategory = entity.StaffCategory;
                user.Specialization = entity.Specialization;
                user.RoleId = entity.RoleId;    

            }

            return user;
        }
    }
}
