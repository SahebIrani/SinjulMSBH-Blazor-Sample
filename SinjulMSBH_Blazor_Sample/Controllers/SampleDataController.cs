using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SinjulMSBH_Blazor_Sample.Controllers
{
	[Route( "api/[controller]" )]
	public class SampleDataController: Controller
	{
		private static string[] Summaries = new[]
	  {
		"Sinjul", "MSBH", "Jack", "Slater", "Mehrdad", "Saheb", "Eli", "Fooki", "Hamed", "Behrouz"
	  };

		[HttpGet( "[action]" )]
		public IEnumerable<WeatherForecast> WeatherForecasts ( )
		{
			var rng = new Random();
			return Enumerable.Range( 1 , 5 ).Select( index => new WeatherForecast
			{
				DateFormatted = DateTime.Now.AddDays( index ).ToString( "d" ) ,
				TemperatureC = rng.Next( -20 , 55 ) ,
				Summary = Summaries[ rng.Next( Summaries.Length ) ]
			} );
		}
	}
}