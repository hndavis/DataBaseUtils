using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseUtils.ConversionAlgo
{
	public class Replace
	{
		public String key { get; private set; }
		public String From { get; set; }
		public String To { get; set; }
	}

	public class StatementTransForms
	{
		public String From1 { get; set; }
		public String To1 { get; set; }
		public String From2 { get; set; }
		public String To2 { get; set; }
		public String From3 { get; set; }
		public String To3 { get; set; }
		public String From4 { get; set; }
		public String To4 { get; set; }
	}

	public static class VectorToMySql
	{
		public static List<Replace> items = new List<Replace>()
		{
			new Replace {From = " ANSIDATE WITH NULL", To = " DATE"},
			new Replace {From = " ANSIDATE NOT NULL", To = " DATE"},
			new Replace {From = " WITH NULL", To = ""},
			new Replace {From = "WITH NULL", To = ""},
			new Replace {From = " WITHOUT TIME ZONE WITH NULL", To = ""},
			new Replace {From = " TIME ZONE NOT NULL", To = ""},
			new Replace {From = " WITHOUT TIME ZONE", To = ""},
			new Replace {From = " WITH DEFAULT", To = " DEFAULT"},
		 	new Replace {From = " WITH ZONE", To = " "},
			new Replace {From = " WITH TIME ZONE", To = " "},
			new Replace { From = "NOT NULL WITH DEFAULT", To="NOT NULL DEFAULT"},
			new Replace { From  ="TO GROUP", To="TO"}
		};

		public static List<Replace> statementItems = new List<Replace>()
		{
			new Replace {From = " GROUP", To = " "},  // grantselect
			
		};

	}

}
