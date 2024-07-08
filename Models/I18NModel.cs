namespace CodeGenerator.Models
{
    public class I18NModel
    {
        public required List<Resource> Dictionary { get; set; }
    }

    public class Resource
    {
        public required string Spanish { get; set; }
        public required string English { get; set; }
    }
}
