using System;

namespace HealthCheckPro
{
    [AttributeUsage(AttributeTargets.Method)]
    class PublicAPIAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    class RequiresAuthAttribute : Attribute
    {
    }
}
