namespace CodeGenerator.Models
{
    public class DirectoryModel
    {
        public required string Name { get; set; }
        public required string Path { get; set; }
        public required List<FileModel> Files { get; set; }
    }
}
