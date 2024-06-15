// "public()" isn't necessary but you can
// Use that to change the access level of the constructor
public class FileProcessor(string filePath) : public()
{
    // Unnamed Initializer. But the unnamed initializer must
    // come first before any method, field, or property.
    // Or the compiler wouldn't detect it as an unnamed initializer.
    // Code blocking isn't necessary here.
    // It can also have multiple lines without code block.
    ValidateFilePath(filePath);
    
    public string FilePath { get; set; } = filePath;
    
    private void ValidateFilePath(string path)
    {
        if (string.IsNullOrEmpty(path) || !File.Exists(path))
            throw new ArgumentException("Invalid file path provided.");
    }
}
