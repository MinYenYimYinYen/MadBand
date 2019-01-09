using MadBand.Application.Interfaces;
using MadBand.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace MadBand.Clacker
{
	class Program
	{
		static void Main(string[] args)
		{
			//Setup DI
			var serviceProvider = new ServiceCollection()
				.AddLogging()
				.AddTransient(typeof(IMadBandDbContext), typeof(MadBandDbContext))
				.BuildServiceProvider();



			Console.WriteLine("Hello World!");
			
		}
	}
}
