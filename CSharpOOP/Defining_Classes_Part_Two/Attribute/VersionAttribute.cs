using System;
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
        AllowMultiple = false)]
class VersionAttribute : System.Attribute
{
    //properties
    private string version;
    public string Version
    {
        get { return this.version; }
        set { this.version = value; }
    }
    //constructor
    public VersionAttribute(string version)
    {
        this.Version = version;
    }
}
