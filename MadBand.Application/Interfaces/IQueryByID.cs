using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.Interfaces
{
	public interface IQueryByID<T>
	{
		T Id { get; set; }
	}
}
