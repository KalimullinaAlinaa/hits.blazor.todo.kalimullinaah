﻿using Todo.ServerApp.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Todo.ServerApp.Data.Services
{
	public class MSSQLDataService(ApplicationDbContext context) : IDataServices
	{
		public async Task DeleteAsync(int id)
		{
			var taskItem = await context.TaskItems.FirstAsync(x => x.Id == id);
			context.TaskItems.Remove(taskItem);
			await context.SaveChangesAsync();
		}

		public async Task<TaskItem> GetTaskAsync(int id)
		{
			return await context.TaskItems.FirstAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<TaskItem>> GetAllAsync()
		{
			return await context.TaskItems.ToArrayAsync();
		}

		public async Task SaveAsync(TaskItem taskItem)
		{
			if (taskItem.Id == 0)
			{
				taskItem.CreatedDate = DateTime.Now;
				await context.TaskItems.AddAsync(taskItem);
			}
			else
			{
				context.TaskItems.Update(taskItem);
			}
			await context.SaveChangesAsync();
		}
	}
}
