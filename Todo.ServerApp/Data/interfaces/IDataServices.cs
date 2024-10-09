namespace Todo.ServerApp.Data.Interfaces
{
	public interface IDataServices
	{
		Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
	}
}
