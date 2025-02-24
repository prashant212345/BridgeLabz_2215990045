using System;
using System.Collections.Generic;
using System.Reflection;

// Step 1: Define the CacheResult attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class CacheResultAttribute : Attribute { }

// Step 2: Implement a caching system
class CacheManager
{
    private static readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

    public static object ExecuteWithCache(object obj, string methodName, params object[] args)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        if (method == null)
        {
            throw new ArgumentException($"Method '{methodName}' not found.");
        }

        // Check if the method has CacheResult attribute
        if (Attribute.GetCustomAttribute(method, typeof(CacheResultAttribute)) == null)
        {
            // If no cache attribute, invoke method normally
            return method.Invoke(obj, args);
        }

        // Create a unique cache key using method name and parameters
        string cacheKey = methodName + "(" + string.Join(",", args) + ")";
        
        if (_cache.TryGetValue(cacheKey, out object cachedValue))
        {
            Console.WriteLine($"[Cache Hit] Returning cached result for {cacheKey}");
            return cachedValue;
        }

        // Execute method and store result in cache
        object result = method.Invoke(obj, args);
        _cache[cacheKey] = result;
        Console.WriteLine($"[Cache Miss] Computing result for {cacheKey}");
        return result;
    }
}

// Step 3: Create a computationally expensive method
class ExpensiveOperations
{
    [CacheResult]
    public int ComputeSquare(int number)
    {
        Console.WriteLine($"Performing expensive computation for {number}...");
        System.Threading.Thread.Sleep(2000); // Simulate delay
        return number * number;
    }
}

class Program
{
    static void Main()
    {
        ExpensiveOperations operations = new ExpensiveOperations();

        // First call - Computes and caches result
        Console.WriteLine("Result: " + CacheManager.ExecuteWithCache(operations, "ComputeSquare", 5));

        // Second call with same input - Uses cached result
        Console.WriteLine("Result: " + CacheManager.ExecuteWithCache(operations, "ComputeSquare", 5));

        // New computation for different input
        Console.WriteLine("Result: " + CacheManager.ExecuteWithCache(operations, "ComputeSquare", 7));
    }
}
