public class NullCheckAttributeExample
{
    public int Id { get; set; }
    
    public string Argument { get; set; }
    
    public NullCheckAttributeExample(int id, [ThrowArgumentNullException] string argument)
    {
        ArgumentNullException.ThrowIfNull(id, nameof(argument));
        
        Id = id;
        Argument = argument;
    }
    
    public static NullCheckAttributeExample CreateNewInstance(int id, [ThrowArgumentNullException] string argument)
    {
        ArgumentNullException.ThrowIfNull(id, nameof(argument));
        
        return new NullCheckAttributeExample(id, argument);
    }
}
