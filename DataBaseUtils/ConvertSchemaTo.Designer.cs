namespace DataBaseUtils
{
	partial class ConvertSchemaTo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtInputDir = new System.Windows.Forms.TextBox();
			this.btnPickInputDir = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOutputDir = new System.Windows.Forms.TextBox();
			this.btnPickOutputDir = new System.Windows.Forms.Button();
			this.cbSingleFile = new System.Windows.Forms.CheckBox();
			this.txtSingleFile = new System.Windows.Forms.TextBox();
			this.btnPickSingleFile = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnShowFileToBeConverted = new System.Windows.Forms.Button();
			this.lbFilesToBeConverted = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input Directory";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtInputDir
			// 
			this.txtInputDir.Location = new System.Drawing.Point(6, 54);
			this.txtInputDir.Name = "txtInputDir";
			this.txtInputDir.Size = new System.Drawing.Size(627, 22);
			this.txtInputDir.TabIndex = 1;
			this.txtInputDir.TextChanged += new System.EventHandler(this.txtInputDir_TextChanged);
			// 
			// btnPickInputDir
			// 
			this.btnPickInputDir.Location = new System.Drawing.Point(639, 54);
			this.btnPickInputDir.Name = "btnPickInputDir";
			this.btnPickInputDir.Size = new System.Drawing.Size(40, 23);
			this.btnPickInputDir.TabIndex = 2;
			this.btnPickInputDir.Text = "...";
			this.btnPickInputDir.UseVisualStyleBackColor = true;
			this.btnPickInputDir.Click += new System.EventHandler(this.btnPickInputDir_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Output Directory";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtOutputDir
			// 
			this.txtOutputDir.Location = new System.Drawing.Point(9, 169);
			this.txtOutputDir.Name = "txtOutputDir";
			this.txtOutputDir.Size = new System.Drawing.Size(625, 22);
			this.txtOutputDir.TabIndex = 4;
			// 
			// btnPickOutputDir
			// 
			this.btnPickOutputDir.Location = new System.Drawing.Point(640, 168);
			this.btnPickOutputDir.Name = "btnPickOutputDir";
			this.btnPickOutputDir.Size = new System.Drawing.Size(39, 23);
			this.btnPickOutputDir.TabIndex = 5;
			this.btnPickOutputDir.Text = "...";
			this.btnPickOutputDir.UseVisualStyleBackColor = true;
			this.btnPickOutputDir.Click += new System.EventHandler(this.btnPickOutputDir_Click);
			// 
			// cbSingleFile
			// 
			this.cbSingleFile.AutoSize = true;
			this.cbSingleFile.Location = new System.Drawing.Point(9, 83);
			this.cbSingleFile.Name = "cbSingleFile";
			this.cbSingleFile.Size = new System.Drawing.Size(103, 21);
			this.cbSingleFile.TabIndex = 6;
			this.cbSingleFile.Text = "SingleFile ?";
			this.cbSingleFile.UseVisualStyleBackColor = true;
			this.cbSingleFile.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// txtSingleFile
			// 
			this.txtSingleFile.Enabled = false;
			this.txtSingleFile.Location = new System.Drawing.Point(9, 111);
			this.txtSingleFile.Name = "txtSingleFile";
			this.txtSingleFile.Size = new System.Drawing.Size(624, 22);
			this.txtSingleFile.TabIndex = 7;
			// 
			// btnPickSingleFile
			// 
			this.btnPickSingleFile.Enabled = false;
			this.btnPickSingleFile.Location = new System.Drawing.Point(640, 110);
			this.btnPickSingleFile.Name = "btnPickSingleFile";
			this.btnPickSingleFile.Size = new System.Drawing.Size(39, 23);
			this.btnPickSingleFile.TabIndex = 8;
			this.btnPickSingleFile.Text = "...";
			this.btnPickSingleFile.UseVisualStyleBackColor = true;
			this.btnPickSingleFile.Click += new System.EventHandler(this.btnPickSingleFile_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(577, 479);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(133, 37);
			this.btnConvert.TabIndex = 9;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(28, 493);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnShowFileToBeConverted
			// 
			this.btnShowFileToBeConverted.Location = new System.Drawing.Point(686, 52);
			this.btnShowFileToBeConverted.Name = "btnShowFileToBeConverted";
			this.btnShowFileToBeConverted.Size = new System.Drawing.Size(75, 23);
			this.btnShowFileToBeConverted.TabIndex = 11;
			this.btnShowFileToBeConverted.Text = "Show...";
			this.btnShowFileToBeConverted.UseVisualStyleBackColor = true;
			this.btnShowFileToBeConverted.Click += new System.EventHandler(this.btnShowFileToBeConverted_Click);
			// 
			// lbFilesToBeConverted
			// 
			this.lbFilesToBeConverted.FormattingEnabled = true;
			this.lbFilesToBeConverted.ItemHeight = 16;
			this.lbFilesToBeConverted.Location = new System.Drawing.Point(701, 94);
			this.lbFilesToBeConverted.Name = "lbFilesToBeConverted";
			this.lbFilesToBeConverted.Size = new System.Drawing.Size(285, 180);
			this.lbFilesToBeConverted.TabIndex = 12;
			// 
			// ConvertSchemaTo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 528);
			this.Controls.Add(this.lbFilesToBeConverted);
			this.Controls.Add(this.btnShowFileToBeConverted);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnPickSingleFile);
			this.Controls.Add(this.txtSingleFile);
			this.Controls.Add(this.cbSingleFile);
			this.Controls.Add(this.btnPickOutputDir);
			this.Controls.Add(this.txtOutputDir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnPickInputDir);
			this.Controls.Add(this.txtInputDir);
			this.Controls.Add(this.label1);
			this.Name = "ConvertSchemaTo";
			this.Text = "ConvertSchemaTo";
			this.Load += new System.EventHandler(this.ConvertSchemaTo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInputDir;
		private System.Windows.Forms.Button btnPickInputDir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOutputDir;
		private System.Windows.Forms.Button btnPickOutputDir;
		private System.Windows.Forms.CheckBox cbSingleFile;
		private System.Windows.Forms.TextBox txtSingleFile;
		private System.Windows.Forms.Button btnPickSingleFile;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnShowFileToBeConverted;
		private System.Windows.Forms.ListBox lbFilesToBeConverted;
	}
}