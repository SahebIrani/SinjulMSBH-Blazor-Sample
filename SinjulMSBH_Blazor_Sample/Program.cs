using System.IO;
using Blazor.Routing;
using Blazor.Runtime.Interop;
using Microsoft.AspNetCore.Hosting;

namespace SinjulMSBH_Blazor_Sample
{
	public class Program
	{
		private static void Main ( string[ ] args )
		{
			Router.MountInElement( "app" );
		}
	}

	//public class Program2
	//{
	//	public static void Main ( string[ ] args )
	//	{
	//		var host = new WebHostBuilder()
	//		  .UseKestrel()
	//		  .UseContentRoot(Directory.GetCurrentDirectory())
	//		  .UseStartup<Startup>()
	//		  .Build();

	//		host.Run( );
	//	}
	//}
}