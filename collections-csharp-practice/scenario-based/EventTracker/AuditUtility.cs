using System;
using System.Reflection;
using System.Text.Json;
using System.Collections.Generic;

namespace EventTracker
{
    class AuditUtility : IAuditService
    {
        public void GenerateAuditLogs()
        {
            Type type = typeof(UserActions);
            MethodInfo[] methods = type.GetMethods();

            List<object> logs = new List<object>();

            foreach (MethodInfo method in methods)
            {
                var attribute = method.GetCustomAttribute<AuditTrailAttribute>();

                if (attribute != null)
                {
                    var log = new
                    {
                        Action = attribute.ActionName,
                        MethodName = method.Name,
                        TimeStamp = DateTime.Now.ToString(),
                        ClassName = type.Name
                    };

                    logs.Add(log);
                }
            }

            string jsonOutput = JsonSerializer.Serialize(logs, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Console.WriteLine("\n=== AUDIT LOG JSON ===");
            Console.WriteLine(jsonOutput);
        }
    }
}
