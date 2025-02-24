using System;
using System.Reflection;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

// Step 2: Create a class with role-restricted methods
class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Executing Admin Task...");
    }

    [RoleAllowed("USER")]
    public void UserTask()
    {
        Console.WriteLine("Executing User Task...");
    }

    public void PublicTask()
    {
        Console.WriteLine("Executing Public Task... (No restrictions)");
    }
}

// Step 3: Implement access control logic
class AccessController
{
    private string currentUserRole;

    public AccessController(string role)
    {
        currentUserRole = role;
    }

    public void ExecuteWithAccessCheck(object obj, string methodName)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        RoleAllowedAttribute roleAttribute = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

        if (roleAttribute != null && roleAttribute.Role != currentUserRole)
        {
            Console.WriteLine($"Access Denied! '{currentUserRole}' role cannot execute '{methodName}' (Requires {roleAttribute.Role} role).\n");
            return;
        }

        // If role is allowed or no restriction exists, execute the method
        method.Invoke(obj, null);
    }
}

class Program
{
    static void Main()
    {
        SecureOperations operations = new SecureOperations();

        // Simulate users with different roles
        AccessController adminUser = new AccessController("ADMIN");
        AccessController normalUser = new AccessController("USER");

        Console.WriteLine("Admin trying to access tasks:");
        adminUser.ExecuteWithAccessCheck(operations, "AdminTask");  // Allowed
        adminUser.ExecuteWithAccessCheck(operations, "UserTask");   // Allowed
        adminUser.ExecuteWithAccessCheck(operations, "PublicTask"); // Allowed

        Console.WriteLine("\nUser trying to access tasks:");
        normalUser.ExecuteWithAccessCheck(operations, "AdminTask"); // Denied
        normalUser.ExecuteWithAccessCheck(operations, "UserTask");  // Allowed
        normalUser.ExecuteWithAccessCheck(operations, "PublicTask");// Allowed
    }
}
