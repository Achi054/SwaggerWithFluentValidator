namespace SwaggerWithFluentValidation.Models
{
    public class HomeViewModel
    {
        public string Title => $"Hi, {Name}";
        public string Name { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
