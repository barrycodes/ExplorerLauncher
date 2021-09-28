using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oid.Applications.ExplorerLauncher
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			try
			{	
				var startInfo = new ProcessStartInfo("C:\\Windows\\explorer.exe");
				var realArgs = args?.Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
				if (realArgs?.Any() ?? false)
					startInfo.Arguments = string.Join(" ", realArgs);
				startInfo.WindowStyle = ProcessWindowStyle.Normal;
				Process.Start(startInfo);
			}
			catch { }
		}
	}
}
