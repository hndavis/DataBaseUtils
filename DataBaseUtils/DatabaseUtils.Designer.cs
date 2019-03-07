namespace DataBaseUtils
{
	partial class DatabaseUtils
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
			this.btnConvertToMySql = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnConvertToMySql
			// 
			this.btnConvertToMySql.Location = new System.Drawing.Point(43, 44);
			this.btnConvertToMySql.Name = "btnConvertToMySql";
			this.btnConvertToMySql.Size = new System.Drawing.Size(227, 39);
			this.btnConvertToMySql.TabIndex = 0;
			this.btnConvertToMySql.Text = "ConvertSchema To MySql...";
			this.btnConvertToMySql.UseVisualStyleBackColor = true;
			this.btnConvertToMySql.Click += new System.EventHandler(this.btnConvertToMySql_Click);
			// 
			// DatabaseUtils
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnConvertToMySql);
			this.Name = "DatabaseUtils";
			this.Text = "DatabaseUtils";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnConvertToMySql;
	}
}