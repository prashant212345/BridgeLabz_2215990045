using System;
using System.Collections.Generic;
using System.Linq;

class InsurancePolicy : IComparable<InsurancePolicy>
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override bool Equals(object obj)
    {
        return obj is InsurancePolicy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public int CompareTo(InsurancePolicy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate); // Sort by expiry date
    }

    public override string ToString()
    {
        return $"PolicyNumber: {PolicyNumber}, Coverage: {CoverageType}, Expiry: {ExpiryDate:yyyy-MM-dd}";
    }
}

class InsurancePolicyManage
{
    static HashSet<InsurancePolicy> policySet = new HashSet<InsurancePolicy>();
    static LinkedList<InsurancePolicy> linkedPolicySet = new LinkedList<InsurancePolicy>();
    static SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nInsurance Policy Management System");
            Console.WriteLine("1. Add Policy");
            Console.WriteLine("2. View All Unique Policies");
            Console.WriteLine("3. View Policies Expiring Soon (Next 30 Days)");
            Console.WriteLine("4. View Policies by Coverage Type");
            Console.WriteLine("5. Find Duplicate Policies");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddPolicy();
                    break;
                case 2:
                    DisplayAllPolicies();
                    break;
                case 3:
                    DisplayExpiringSoon();
                    break;
                case 4:
                    ViewByCoverageType();
                    break;
                case 5:
                    FindDuplicatePolicies();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void AddPolicy()
    {
        Console.Write("Enter Policy Number: ");
        string policyNumber = Console.ReadLine();

        Console.Write("Enter Coverage Type: ");
        string coverageType = Console.ReadLine();

        Console.Write("Enter Expiry Date (yyyy-MM-dd): ");
        DateTime expiryDate;
        while (!DateTime.TryParse(Console.ReadLine(), out expiryDate))
        {
            Console.Write("Invalid date format! Enter again (yyyy-MM-dd): ");
        }

        InsurancePolicy newPolicy = new InsurancePolicy(policyNumber, coverageType, expiryDate);

        if (policySet.Add(newPolicy))
        {
            linkedPolicySet.AddLast(newPolicy);
            sortedPolicies.Add(newPolicy);
            Console.WriteLine("Policy added successfully.");
        }
        else
        {
            Console.WriteLine("Duplicate Policy Number! Policy already exists.");
        }
    }

    static void DisplayAllPolicies()
    {
        Console.WriteLine("\nAll Unique Policies:");
        foreach (var policy in linkedPolicySet) // Maintaining insertion order
        {
            Console.WriteLine(policy);
        }
    }

    static void DisplayExpiringSoon()
    {
        Console.WriteLine("\nPolicies Expiring Soon (Next 30 Days):");
        DateTime today = DateTime.Now;
        DateTime limit = today.AddDays(30);

        var expiringPolicies = sortedPolicies.Where(p => p.ExpiryDate >= today && p.ExpiryDate <= limit);

        foreach (var policy in expiringPolicies)
        {
            Console.WriteLine(policy);
        }
    }

    static void ViewByCoverageType()
    {
        Console.Write("Enter Coverage Type to Search: ");
        string type = Console.ReadLine();

        var filteredPolicies = policySet.Where(p => p.CoverageType.Equals(type, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"\nPolicies with Coverage Type '{type}':");
        foreach (var policy in filteredPolicies)
        {
            Console.WriteLine(policy);
        }
    }

    static void FindDuplicatePolicies()
    {
        Console.WriteLine("\nDuplicate Policies (Same Policy Number):");
        var duplicates = policySet.GroupBy(p => p.PolicyNumber)
                                  .Where(g => g.Count() > 1)
                                  .SelectMany(g => g);

        if (!duplicates.Any())
            Console.WriteLine("No duplicate policies found.");
        else
        {
            foreach (var policy in duplicates)
            {
                Console.WriteLine(policy);
            }
        }
    }
}
