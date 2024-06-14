public class NullCheckAttributeExample
{
	public int Id { get; set; }

	public string Argument { get; set; }

	public NullCheckAttributeExample(int id, [ThrowArgumentNullException] string argument)
	{
		// When ThrowArgumentNullExceptionAttribute is used on the parameter, it'll throw an exception if the parameter is null.
		Id = id;
		Argument = argument;
	}

	public static NullCheckAttributeExample CreateNewInstance(int id, [ThrowArgumentNullException] string argument)
	{
		// Similarly for any method when ThrowArgumentNullExceptionAttribute is used on the parameter, it'll throw an exception if the parameter is null.
		return new NullCheckAttributeExample(id, argument);
    }

	// Note: ThrowArgumentNullExceptionAttribute can only be used on a parameter.
	// It can't be used on a parameter whose reference types are non-nullable because they can't be passed with null.
}
