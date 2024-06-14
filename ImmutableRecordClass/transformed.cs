public class FileProcessor : IFileProcessor, IValidatable
{
    public string FilePath { get; init; }

    public FileProcessor(string filePath)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            throw new ArgumentException("Invalid file path provided.");
        FilePath = filePath;
    }

    public void Validate() // Implementation from IValidatable
    {
        // ... validation logic
    }

    public void ProcessFile() // Implementation from IFileProcessor
    {
        // ... file processing logic using _filePath
    }
}

public interface IFileProcessor
{
    void ProcessFile();
}

public interface IValidatable
{
    void Validate();
}
