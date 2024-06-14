public class FileProcessor
{
    public FileProcessor(string filePath)
    {
        FilePath = filePath;
        ValidateFilePath(filePath);
    }

    public string FilePath { get; set; }

    private void ValidateFilePath(string path)
    {
        if (string.IsNullOrEmpty(path) || !File.Exists(path))
            throw new ArgumentException("Invalid file path provided.");
    }
}
