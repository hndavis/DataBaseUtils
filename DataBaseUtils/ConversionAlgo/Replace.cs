using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseUtils.ConversionAlgo
{
	public class Replace
	{
		public String From { get; set; }
		public String To { get; set; }
	}

	public static class VectorToMySql
	{
		public static List<Replace> items = new List<Replace>()
		{
			new Replace {From = " ANSIDATE WITH NULL", To = " DATE"},
			new Replace {From = " WITH NULL", To = ""},
			new Replace {From = " WITHOUT TIME ZONE WITH NULL", To = ""}
		};
	}

}
