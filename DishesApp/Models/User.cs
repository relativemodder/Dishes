namespace DishesApp.Models
{
    public class User
    {
        public class Role
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public int Id { get; set; }
        public required string Surname { get; set; }
        public required string Name { get; set; }
        public required string Patronymic { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
        public required Role UserRole { get; set; }
    }
}
