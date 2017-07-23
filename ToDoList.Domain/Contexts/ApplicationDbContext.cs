using Microsoft.AspNet.Identity.EntityFramework;
using ToDoList.Domain.Entities;

namespace ToDoList.Domain.Contexts
{
    public class ToDoListDbContext : IdentityDbContext<ApplicationUser>
    {
        public ToDoListDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ToDoListDbContext Create()
        {
            return new ToDoListDbContext();
        }
    }
}