public class SingletonExampleClass
{
	private static readonly Lazy<SingletonExampleClass> _lazyInstance =
        new Lazy<SingletonExampleClass>(() => new SingletonExampleClass(), true);
    
    private SingletonExampleClass()
    {
        if (_lazyInstance.IsValueCreated) // Checked if it is called for a second time if it has one instance.
            throw new InvalidOperationException("Singleton classes can only have one instance.");
        
        // Do work here.
    }
    
	public static MySingleton Instance => _lazyInstance.Value;
}
