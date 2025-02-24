using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// Step 1: Define an [Inject] attribute
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property)]
public class InjectAttribute : Attribute { }

// Step 2: Define a simple DI container
public class SimpleContainer
{
    private Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();

    // Register types
    public void Register<TInterface, TImplementation>() where TImplementation : TInterface
    {
        _registrations[typeof(TInterface)] = typeof(TImplementation);
    }

    // Resolve dependencies and create instances
    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }

    private object Resolve(Type type)
    {
        if (!_registrations.ContainsKey(type) && !type.IsInterface)
        {
            return Activator.CreateInstance(type); // Handle direct class instantiation
        }

        Type implementationType = _registrations[type];

        // Step 3: Resolve constructor dependencies
        ConstructorInfo constructor = implementationType.GetConstructors()
            .FirstOrDefault(ctor => ctor.GetCustomAttribute<InjectAttribute>() != null)
            ?? implementationType.GetConstructors().First();

        ParameterInfo[] parameters = constructor.GetParameters();
        object[] parameterInstances = parameters.Select(param => Resolve(param.ParameterType)).ToArray();

        object instance = constructor.Invoke(parameterInstances);

        // Step 4: Inject dependencies into fields and properties
        foreach (FieldInfo field in implementationType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            if (field.GetCustomAttribute<InjectAttribute>() != null)
            {
                field.SetValue(instance, Resolve(field.FieldType));
            }
        }

        foreach (PropertyInfo property in implementationType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (property.GetCustomAttribute<InjectAttribute>() != null)
            {
                property.SetValue(instance, Resolve(property.PropertyType));
            }
        }

        return instance;
    }
}

// Step 5: Define service interfaces and implementations
public interface IService
{
    void Execute();
}

public class ServiceA : IService
{
    public void Execute()
    {
        Console.WriteLine("ServiceA Executing...");
    }
}

// Step 6: Define a class with dependencies
public class Client
{
    private readonly IService _service;

    [Inject] // Constructor injection
    public Client(IService service)
    {
        _service = service;
    }

    public void Run()
    {
        _service.Execute();
    }
}

class Program
{
    static void Main()
    {
        // Step 7: Create and configure DI container
        SimpleContainer container = new SimpleContainer();
        container.Register<IService, ServiceA>();
        container.Register<Client, Client>();

        // Step 8: Resolve and use the client
        Client client = container.Resolve<Client>();
        client.Run();
    }
}
