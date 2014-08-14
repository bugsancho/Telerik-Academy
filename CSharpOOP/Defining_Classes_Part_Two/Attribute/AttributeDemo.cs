using System;
[Version("2.11")]
class AttributeDemo
{
    static void Main()
    {
        Type type = typeof(AttributeDemo);
        object[] attributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute attribute in attributes)
        {
            Console.WriteLine(attribute.Version);
        }
    }
}
