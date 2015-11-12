namespace WebApiApplication.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Distance { get; set; }
        public bool IsCommute { get; set; }
    }
}