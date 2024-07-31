using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DL;

namespace TimeManagement.EventManager
{
	public class EventHandler
	{
		//public ProcessEventDL ProcessEventDL => _ProcessEventDL ?? (_ProcessEventDL = new ProcessEventDL());
		//private ProcessEventDL _ProcessEventDL;

		private static System.Timers.Timer Timer;

		public static void CreateTimerInstance()
		{
			Timer = new System.Timers.Timer(5000);
			Timer.Elapsed += Timer_Elapsed;
			Start();
		}

		private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
		{
			
		}

		private static void Start()
		{
			Timer.Enabled = true;
			Timer.Start();
		}

	}
}
