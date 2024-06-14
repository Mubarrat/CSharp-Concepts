// "public()" isn't neccesary but you can
// use that to change access level of constructor
public class FileProcessor(string filePath) : public()
{
    // Unnamed Initializer. But unnamed initializer must
    // come first before any method, field or property.
    // Or compiler wouldn't detect it as unnamed initializer.
    // Code blocking isn't neccesary here.
    ValidateFilePath(filePath);
    
    public string FilePath { get; set; } = filePath;
    
    private void ValidateFilePath(string path)
    {
        if (string.IsNullOrEmpty(path) || !File.Exists(path))
            throw new ArgumentException("Invalid file path provided.");
    }
}
