## Singleton Design Pattern Exploration

This folder explores the Singleton design pattern, a common approach for ensuring a class has only one instance and provides a global access point to it.

### concept.cs (Conceptual Code)

The `concept.cs` file presents a conceptual representation of a Singleton class:

```csharp
public singleton class SingletonExampleClass // Conceptual (not a valid keyword)
{
    private SingletonExampleClass() // Private constructor to enforce single instance
    {
        // Do work here (optional)
    }

    // Access method would be placed elsewhere (e.g., static method)
}
```

**Explanation:**

- The class is declared with `public singleton`, which isn't a valid C# keyword, but effectively communicates the Singleton design intent.
- The constructor is private, preventing direct object creation using `new`.
- (Optional) The constructor can perform initialization tasks specific to the Singleton instance.

This code highlights the core principles of a Singleton:

- **Private Constructor:** Enforces a single instance by preventing direct object creation.

### transformed.cs (Implementation with Lazy Initialization)

The `transformed.cs` file demonstrates a practical implementation using the `Lazy<T>` class for thread-safe lazy initialization:

```csharp
public class SingletonExampleClass
{
    private static readonly Lazy<SingletonExampleClass> _lazyInstance =
        new Lazy<SingletonExampleClass>(() => new SingletonExampleClass(), true);

    private SingletonExampleClass()
    {
        if (_lazyInstance.IsValueCreated)
        {
            throw new InvalidOperationException("Singleton classes can only have one instance.");
        }

        // Do work here.
    }

    public static MySingleton Instance => _lazyInstance.Value;
}
```

**Explanation:**

- The class leverages `Lazy<T>` for lazy initialization.
- A static readonly field `_lazyInstance` holds a `Lazy<SingletonExampleClass>` object.
- The `Lazy<T>` constructor takes a delegate that creates the Singleton instance and sets the `isThreadSafe` parameter to `true`.
- The private constructor checks if the instance has already been created using `_lazyInstance.IsValueCreated`.
- If an instance exists, it throws an `InvalidOperationException` to prevent creating multiple instances.
- The public static property `Instance` provides access to the Singleton instance using the `Value` property of the `Lazy<T>` object.

This code showcases a common implementation approach for Singletons in C#:

- **Lazy Initialization:** The instance is created only when it's first accessed.
- **Thread Safety:** The `Lazy<T>` class ensures thread safety for multithreaded environments.
- **Exception Handling:**  `InvalidOperationException` is thrown to prevent creating multiple instances.

### Key Takeaways

- The Singleton design pattern ensures a class has a single instance and provides a global access point.
- It's useful for managing global state or resources that need to be shared across the application.
- Consider alternatives like dependency injection before resorting to Singletons, as they can introduce tight coupling and make code harder to test.
- Lazy initialization and thread safety are important aspects to consider when implementing Singletons.

This exploration provides a conceptual understanding of the Singleton design pattern and showcases a practical implementation using `Lazy<T>` in C#. It highlights the benefits and drawbacks of Singletons, encouraging developers to make informed decisions about their use in applications.
