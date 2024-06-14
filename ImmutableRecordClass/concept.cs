// Every parameter starts with Uppercases are immutable property { get; init; }. Others are parameter.
// This is better than only Immutable record. Immutable record can only be derived or based from record.
// While this can be derived or based from class/record and interfaces.
public record class FileProcessor(string FilePath) : public(), IFileProcessor, IValidatable
{
    public void Validate() // Implementation from IValidatable
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            throw new ArgumentException("Invalid file path provided.");
    }

    public void ProcessFile() // Implementation from IFileProcessor
    {
        // ... file processing logic
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
