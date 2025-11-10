using System;

namespace Task2;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;
        string result = (username == null) ? "Username is not availabe" : username;
        Console.WriteLine(result);

        Console.WriteLine(username ?? "Username is not available ");

        username ??= "defaultUser";
        Console.WriteLine(username);
    }
}
