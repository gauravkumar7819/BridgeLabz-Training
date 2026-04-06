using System;
using System.Collections.Generic;
using System.Text;

namespace CallLog_System
{
    internal class CallLogManager
    {
		
			private CallLog[] logs;
			private int count;

			public CallLogManager(int size)
			{
				logs = new CallLog[size];
				count = 0;
			}

			// Add new call log
			public void AddCallLog(CallLog cl)
			{
			logs[count]=cl;
			count++;
			}

			// Search logs by keyword in message
			public void SearchByKeyword(string keyword)
			{
				Console.WriteLine("\nSearch Results for keyword: " + keyword);

				for (int i = 0; i < count; i++)
				{
					if (logs[i].Message != null &&
						logs[i].Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
					{
						PrintLog(logs[i]);
					}
				}
			}

			// Filter logs by time range
			public void FilterByTime(DateTime start, DateTime end)
			{
				Console.WriteLine("\nLogs between " + start + " and " + end);

				for (int i = 0; i < count; i++)
				{
					if (logs[i].Timestamp >= start && logs[i].Timestamp <= end)
					{
						PrintLog(logs[i]);
					}
				}
			}

		private void PrintLog(CallLog log)
		{
			Console.WriteLine(
				"Phone: " + log.PhoneNumber +
				", Message: " + log.Message +
				", Time: " + log.Timestamp
			);
		}

	}

}
