using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace FinalTaskEPAM.Utils
{
	public static class TestLogger
	{
		public static ILogger Logger { get; } = new LoggerConfiguration()
		.WriteTo.Console()
		.CreateLogger();
	}
}
