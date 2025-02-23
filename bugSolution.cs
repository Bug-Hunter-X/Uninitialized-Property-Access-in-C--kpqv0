public class ExampleClass
{
    // Initialize MyProperty during declaration
    public int MyProperty { get; set; } = 0;

    public ExampleClass()
    {
        // Or initialize in the constructor
        MyProperty = 10;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now the output is predictable.
    }
}