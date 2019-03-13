using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseUtils
{
	public partial class DatabaseUtils : Form
	{
		public DatabaseUtils()
		{
			InitializeComponent();
		}

		private void btnConvertToMySql_Click(object sender, EventArgs e)
		{
			var frmConvert = new ConvertSchemaTo();
			frmConvert.Show(this);
		}

		private void pbOpenConCat_Click(object sender, EventArgs e)
		{
			var frmConCat  = new frmConcat();
			frmConCat.Show();
		}
	}
}
