namespace Todo.ServerApp.Data.Interfaces
{
	public interface IDataServices
	{
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task SaveAsync(TaskItem item);
        Task<TaskItem> GetTaskAsync(int id);
        Task DeleteAsync(int id);
    }
}
