// Every parameter starts with Uppercases are mutable property { get; set; }. Others are parameter.
public data class FileProcessor(string FilePath) : public()
{
    ValidateFilePath(FilePath);
    
    private void ValidateFilePath(string path)
    {
        if (string.IsNullOrEmpty(path) || !File.Exists(path))
            throw new ArgumentException("Invalid file path provided.");
    }
}
