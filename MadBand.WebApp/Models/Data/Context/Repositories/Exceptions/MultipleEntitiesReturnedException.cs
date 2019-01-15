using System;

namespace MadBand.WebApp.Models.Data.Context.Repositories.Exceptions
{
	public class MultipleEntitiesReturnedException : Exception
	{
		public string SearchParameter { get; private set; }

		public MultipleEntitiesReturnedException(string searchParameter)
		{
			SearchParameter = searchParameter;
		}

		public override string Message => "Your query for one entity returned multiple results.";
	}
}
