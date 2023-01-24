using Microsoft.EntityFrameworkCore;

namespace PortfolioAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base() {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options) {
            Example example = new()
            {
                Id = 1,
                Name = "Conway's Game of Life",
                Description = "WPF Application simulating Conway's Game of Life",
                SubDescription = "Window's desktop application built as a college project to simulate Conway's Game of Life.   This application allows user to make custom settings, save and load files, and persist data.",
            };

            Examples.Add(example);
            Framework framework = new()
            {
                Id = 1,
                Example = example,
                ExampleId = example.Id,
                Type = "WPF"
            };
            Frameworks.Add(framework);
            Langauge langauge = new()
            {
                Id = 1,
                Example = example,
                ExampleId = example.Id,
                Type = "C#"
            };
            Languages.Add(langauge);
            Image image = new()
            {
                Id = 1,
                Example = example,
                ExampleId = example.Id,
                Url = ""
            };
            Images.Add(image);
            Models.OperatingSystem operatingSystem = new()
            {
                Id = 1,
                Example = example,
                ExampleId = example.Id,
                Type = "Windows"
            };
            OperatingSystems.Add(operatingSystem);
        }

        public DbSet<Example> Examples => Set<Example>();
        public DbSet<Framework> Frameworks => Set<Framework>();
        public DbSet<Image> Images => Set<Image>();
        public DbSet<Langauge> Languages => Set<Langauge>();
        public DbSet<OperatingSystem> OperatingSystems => Set<OperatingSystem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
