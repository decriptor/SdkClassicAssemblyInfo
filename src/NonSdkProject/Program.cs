using System;
using System.Reflection;
using System.Linq;

public class Program1
{
    public static void Main()
    {
        // Get the executing assembly
        Assembly assembly = Assembly.GetExecutingAssembly();

        // Get all custom attributes
        var attributes = assembly.GetCustomAttributes(false);

        foreach (var attribute in attributes)
        {
            Type attrType = attribute.GetType();

            // Display the attribute type
            Console.WriteLine($"Attribute: {attrType.Name}");

            // Get all properties of the attribute
            var properties = attrType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                // Get the property name and value
                string name = property.Name;
                object value = property.GetValue(attribute) ?? "null";

                // Display the property name and value
                Console.WriteLine($"{name}: {value}");
            }

            // Add a blank line for readability between attributes
            Console.WriteLine();
        }
    }
}
