using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseUtils.ConversionAlgo;

namespace DataBaseUtils
{
	public partial class ConvertSchemaTo : Form
	{
		public ConvertSchemaTo()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnPickInputDir_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				fbd.SelectedPath = txtInputDir.Text;
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					txtInputDir.Text = fbd.SelectedPath;
					Properties.Settings.Default.DirForUnconverted = fbd.SelectedPath;
					Properties.Settings.Default.Save();
				}
			}

		}

		private void txtInputDir_TextChanged(object sender, EventArgs e)
		{
		}

		private void ConvertSchemaTo_Load(object sender, EventArgs e)
		{
			txtInputDir.Text = Properties.Settings.Default.DirForUnconverted;
			txtOutputDir.Text = Properties.Settings.Default.DirForConverted;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnPickOutputDir_Click(object sender, EventArgs e)
		{

			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				fbd.SelectedPath = txtInputDir.Text;
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					txtOutputDir.Text = fbd.SelectedPath;
					Properties.Settings.Default.DirForConverted = fbd.SelectedPath;
					Properties.Settings.Default.Save();
				}
			}
		}

		private void btnPickSingleFile_Click(object sender, EventArgs e)
		{
			var fileContent = string.Empty;
			var filePath = string.Empty;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = txtInputDir.Text;  //"c:\\";
				openFileDialog.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					txtSingleFile.Text = openFileDialog.FileName;

					//Read the contents of the file into a stream
					//var fileStream = openFileDialog.OpenFile();

					//using (StreamReader reader = new StreamReader(fileStream))
					//{
					//	fileContent = reader.ReadToEnd();
					//}
				}
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (cbSingleFile.Checked)
			{
				txtSingleFile.Enabled = true;
				btnPickSingleFile.Enabled = true;
			}
			else
			{
				txtSingleFile.Enabled = false;
				btnPickSingleFile.Enabled = false;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnShowFileToBeConverted_Click(object sender, EventArgs e)
		{
			try
			{

				var files = GetFilesInDir(txtInputDir.Text, "*.sql");
				foreach (var filename in files)
				{
					lbFilesToBeConverted.Items.Add(Path.GetFileName(filename));
				}
			}
			catch (Exception ex1)
			{
				string message = ex1.Message + ":-> "  + txtInputDir.Text;
				string caption = "Error";
				MessageBoxButtons buttons = MessageBoxButtons.OK;

				// Displays the MessageBox.

				 MessageBox.Show(message, caption, buttons);
			}

		}

		private List<string> GetFilesInDir(string dir,string filter = null)
		{
			if (Directory.Exists(dir))
			{
				if ( filter == null)
					return Directory.GetFiles(dir).ToList();
				else
					return Directory.GetFiles(dir, filter).ToList();
			}
			else
			 {
				 throw new Exception("Directory does not exist");
			 }
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			if (cbSingleFile.Checked)
			{
				bool overwrite = false;
				bool ask = true;
				
				ConvertAndWrite(txtOutputDir.Text, txtSingleFile.Text, ref overwrite, ref ask);
			}
			else
			{
				bool overwrite = false;
				bool ask = true;
				var files = GetFilesInDir(txtInputDir.Text, "*.sql");
				foreach (var inputfile in files)
				{
					ConvertAndWrite(txtOutputDir.Text, inputfile, ref overwrite, ref ask);
				}
			}
		}

		void ConvertAndWrite(string outputdir, string inputfile, ref bool overwrite, ref bool ask  )
		{
			var fileName = Path.GetFileName(inputfile);
			if ( string.IsNullOrEmpty(fileName))
				throw new Exception("Bad File: " + fileName);
			var outputFile = Path.Combine(outputdir, fileName);
				if (File.Exists(outputFile))
				{
					if (ask)
					{
						if (DialogResult.No == MessageBox.Show(outputFile + "Exists.  Do want to overwrite ?", "Error",
							    MessageBoxButtons.YesNo))
						{
							overwrite = false;
						}
						else
						{
						overwrite = true;
					}
				}

				ask = false;
				if (!overwrite)
					return;

			}

			string fileContent = "";
			using (FileStream fileStream = File.OpenRead(inputfile))
			{

				using (StreamReader reader = new StreamReader(fileStream))
				{
					fileContent = reader.ReadToEnd();
				}
			}

			foreach (var replace in VectorToMySql.items)
			{
				fileContent = fileContent.Replace(replace.From, replace.To);

			}

			File.WriteAllText(outputFile, fileContent);

		}



		private bool DoesFileExists(string path)
		{
			if (File.Exists(path))
				return true;

			return false;
		}
	}
}
