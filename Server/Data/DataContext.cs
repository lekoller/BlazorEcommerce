namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Liber Null",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tempor quam in gravida posuere. Integer interdum libero purus, eget porta elit convallis eget. Aliquam orci risus, luctus at vestibulum quis, vehicula et sem. Sed egestas diam vel sapien scelerisque efficitur at in urna. Curabitur accumsan, velit eget pretium commodo, tortor metus tincidunt ipsum, vitae auctor massa turpis quis turpis.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91N3BBmVNKL.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Liber Two",
                    Description = "Donec magna dui, rutrum nec ornare et, faucibus in quam. Morbi condimentum, tellus nec scelerisque sagittis, tortor diam molestie felis, et bibendum est ipsum eget ante. Vivamus a nibh nibh. Vivamus malesuada finibus quam dictum malesuada. Ut nec lectus pulvinar lacus molestie accumsan at at velit. Sed laoreet tristique cursus.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Georg_B%C3%BCchmann%2C_Gefl%C3%BCgelte_Worte%2C_19._Auflage%2C_1898.jpg/220px-Georg_B%C3%BCchmann%2C_Gefl%C3%BCgelte_Worte%2C_19._Auflage%2C_1898.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Outro Livro",
                    Description = "Cras nec orci pharetra magna tempus fermentum. Fusce finibus purus libero. Mauris sed neque vitae turpis volutpat imperdiet vel vel augue. Sed fringilla vestibulum eleifend. ",
                    ImageUrl = "https://www.carochinhaeditora.com.br/wp-content/uploads/2021/01/Ah-nao_E01_CAPA-V1.png",
                    Price = 8.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
