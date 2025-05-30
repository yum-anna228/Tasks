namespace Tasks
{
    /// <summary>
    /// Определяет контракт для репозитория задач
    /// Реализует асинхронные операции чтения и записи данных о задачах
    /// </summary>
    public interface ITaskRepository
    {
        /// <summary>
        /// Асинхронно получает список всех задач
        /// </summary>
        Task<List<TaskItem>> GetAllAsync();

        /// <summary>
        /// Асинхронно добавляет новую задачу в хранилище
        /// </summary>
        Task AddAsync(TaskItem task);

        /// <summary>
        /// Асинхронно обновляет существующую задачу
        /// </summary>
        Task UpdateAsync(TaskItem task);

        /// <summary>
        /// Асинхронно удаляет задачу по указанному идентификатору
        /// </summary>
        Task DeleteAsync(Guid id);

        /// <summary>
        /// асинхронно получает задачу по идентификатору
        /// </summary>
        Task<TaskItem> GetByIdAsync(Guid id);
    }
}
