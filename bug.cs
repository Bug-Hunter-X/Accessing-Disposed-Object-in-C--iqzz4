public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
        }

        // Attempting to access the context after disposal, leading to an exception
        var data = context.MyTable.FirstOrDefault();
    }
}