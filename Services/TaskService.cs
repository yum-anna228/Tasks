using Microsoft.Extensions.Logging;

namespace Tasks
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;
        private readonly ILogger<TaskService> _logger;

        public TaskService(ITaskRepository repository, ILogger<TaskService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// получает список задач
        /// </summary>
        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            _logger.LogInformation("Получение списка задач");
            return await _repository.GetAllAsync();
        }

        /// <summary>
        /// Ищет задачу по идентификатору
        /// </summary>
        public async Task<TaskItem> GetTaskByIdAsync(Guid id)
        {
            _logger.LogInformation("Поиск задачи по ID: {Id}", id);
            var tasks = await _repository.GetAllAsync();
            return tasks.Find(t => t.Id == id);
        }

        /// <summary>
        /// добавляет задачу
        /// </summary>
        public async Task AddTaskAsync(TaskItem task)
        {
            _logger.LogInformation("Добавление новой задачи: {Title}", task.Title);
            await _repository.AddAsync(task);
        }

        /// <summary>
        /// обновляет задачу
        /// </summary>
        public async Task UpdateTaskAsync(TaskItem task)
        {
            _logger.LogInformation("Обновление задачи: {Id}", task.Id);
            await _repository.UpdateAsync(task);
        }

        /// <summary>
        /// удаляет задачу
        /// </summary>
        public async Task DeleteTaskAsync(Guid id)
        {
            _logger.LogInformation("Удаление задачи: {Id}", id);
            await _repository.DeleteAsync(id);
        }
    }
}
