namespace Tasks
{
    /// <summary>
    /// класс, который представляет задачу
    /// </summary>
    public class TaskItem
    {
        /// <summary>
        /// уникальный идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// описание задачи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// выполнена ли задача
        /// </summary>
        public bool IsCompleted { get; set; }

    }
}
