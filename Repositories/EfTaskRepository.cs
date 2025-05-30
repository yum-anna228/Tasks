using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Tasks
{
    /// <summary>
    /// реализация репозитория задач
    /// </summary>
    public class EfTaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<EfTaskRepository> _logger;

        public EfTaskRepository(AppDbContext context, ILogger<EfTaskRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Асинхронно получает список всех задач из базы данных.
        /// </summary>
        public async Task<List<TaskItem>> GetAllAsync()
        {
            _logger.LogInformation("Запрос всех задач");
            return await _context.Tasks.ToListAsync();
        }

        /// <summary>
        /// Асинхронно добавляет новую задачу в базу данных.
        /// </summary>
        public async Task AddAsync(TaskItem task)
        {
            _logger.LogInformation("Добавление задачи: {Title}", task.Title);
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Асинхронно обновляет существующую задачу в базе данных.
        /// </summary>
        public async Task UpdateAsync(TaskItem task)
        {
            _logger.LogInformation("Обновление задачи: {Id}", task.Id);
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Асинхронно удаляет задачу по указанному идентификатору.
        /// </summary>
        public async Task DeleteAsync(Guid id)
        {
            _logger.LogInformation("Удаление задачи: {Id}", id);
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Асинхронно получает задачу по идентификатору
        /// </summary>
        public async Task<TaskItem> GetByIdAsync(Guid id)
        {
            return await _context.Tasks.FindAsync(id);
        }
    }
}
