using System;

class LegacyAPI
{
    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old feature, which should not be used.");
    }

    public void NewFeature()
    {
        Console.WriteLine("This is the new and improved feature.");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        
        api.OldFeature(); // This will show a warning in the compiler
        api.NewFeature(); // Preferred method
    }
}
