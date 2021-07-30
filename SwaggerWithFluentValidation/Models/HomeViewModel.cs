namespace SwaggerWithFluentValidation.Models
{
    public class HomeViewModel
    {
        public string Title => $"Hi, {Name}";

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string Contact { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}