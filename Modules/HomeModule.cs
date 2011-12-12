using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Mpdreamz.NL.Modules
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = parameters => "Mpdreamz.nl";
		}
	}
}