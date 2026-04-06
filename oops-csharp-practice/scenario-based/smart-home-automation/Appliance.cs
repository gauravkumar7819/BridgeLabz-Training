using System;
using System.Collections.Generic;
using System.Text;

namespace smart_home_automation
{
    internal class Appliance
    {
        private string applianceName;

        public string ApplianceName
        {
            get { return applianceName; }
            set { applianceName = value; }
        }

        public override string ToString()
        {
            return "Appliance:" + applianceName;

        }
    }
}