using Todo.ServerApp.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Todo.ServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataServices
    {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}
