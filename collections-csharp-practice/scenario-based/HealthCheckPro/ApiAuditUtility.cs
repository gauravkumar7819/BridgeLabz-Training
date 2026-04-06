using System;
using System.Reflection;

namespace HealthCheckPro
{
    class ApiAuditUtility : IApiAuditService
    {
        public void GenerateApiDocumentation()
        {
            Type controller = typeof(LabController);
            MethodInfo[] methods = controller.GetMethods(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly
            );

            Console.WriteLine("\n=== API DOCUMENTATION ===");

            foreach (MethodInfo method in methods)
            {
                bool isPublic = method.GetCustomAttribute<PublicAPIAttribute>() != null;
                bool requiresAuth = method.GetCustomAttribute<RequiresAuthAttribute>() != null;

                Console.WriteLine($"\nAPI Name: {method.Name}");

                if (!isPublic)
                {
                    Console.WriteLine("Warning: Missing @PublicAPI annotation");
                }
                else
                {
                    Console.WriteLine("Access: Public");
                }

                if (requiresAuth)
                {
                    Console.WriteLine("Authentication: Required");
                }
                else
                {
                    Console.WriteLine("Authentication: Not Required");
                }
            }
        }
    }
}
