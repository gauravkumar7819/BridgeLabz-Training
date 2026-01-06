using System;
using System.Collections.Generic;
using System.Text;

namespace CallLog_System
{
	using System;

	internal class CallLog
	{
		public string PhoneNumber { get; set; }
		public string Message { get; set; }
		public DateTime Timestamp { get; set; }
		public CallLog(string phoneNumber, string message, DateTime time) { 
			this.PhoneNumber = phoneNumber;
			this.Message = message;
			this.Timestamp = time;

		}
	}

}
