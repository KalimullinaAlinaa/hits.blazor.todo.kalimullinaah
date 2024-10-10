using Microsoft.EntityFrameworkCore;
using Todo.ServerApp.Data.Interfaces;

namespace Todo.ServerApp.Data.Migrations.Services
{
	public class MSSQLDataService(ApplicationDbContext context) : IDataServices
	{
		public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
		{
			return await context.TaskItems.ToArrayAsync();
		}
	}
}
