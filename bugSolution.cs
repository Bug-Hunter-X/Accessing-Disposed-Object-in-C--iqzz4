public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
            var data = context.MyTable.FirstOrDefault();
        }

        // The context is properly disposed of in the using statement; accessing it here is avoided.
    }
}