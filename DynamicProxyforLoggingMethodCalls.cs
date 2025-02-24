using System;
using System.Reflection;
using System.Reflection.Emit;

public interface IGreeting
{
    void SayHello(string name);
}

public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}

public class LoggingProxy<T> where T : class
{
    public static T Create(T instance)
    {
        return DispatchProxy.Create<T, LoggingInterceptor<T>>();
    }

    private class LoggingInterceptor<T> : DispatchProxy
    {
        private T _instance;

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Console.WriteLine("Logging: Calling method - " + targetMethod.Name);
            return targetMethod.Invoke(_instance, args);
        }

        public void SetTarget(T instance)
        {
            _instance = instance;
        }
    }
}

class Program
{
    static void Main()
    {
        // Create original instance
        IGreeting original = new Greeting();

        // Create proxy instance
        IGreeting proxy = LoggingProxy<IGreeting>.Create(original);

        // Call method through proxy
        proxy.SayHello("Alice");
    }
}
