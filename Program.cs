using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Tasks
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Путь к базе данных
                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.db");
                string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "app.log");

                // Настройка DI
                var services = new ServiceCollection();
                services.AddLogging(builder =>
                {
                    builder.AddProvider(new FileLoggerProvider(logFilePath));
                });

                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlite($"Data Source={dbPath}"));

                services.AddScoped<ITaskRepository, EfTaskRepository>();
                services.AddScoped<ITaskService, TaskService>();
                services.AddTransient<MainForm>();

                var serviceProvider = services.BuildServiceProvider();

                // Инициализация БД
                using (var scope = serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    context.Database.EnsureCreated();
                }

                Application.Run(serviceProvider.GetRequiredService<MainForm>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}