using System;

namespace EventTracker
{
    [AttributeUsage(AttributeTargets.Method)]
    class AuditTrailAttribute : Attribute
    {
        public string ActionName { get; set; }

        public AuditTrailAttribute(string actionName)
        {
            ActionName = actionName;
        }
    }
}
