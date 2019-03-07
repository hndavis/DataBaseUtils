namespace DataBaseUtils
{
	partial class SchemaTool
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
			this.cbxDriver = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxHost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxPort = new System.Windows.Forms.TextBox();
			this.cbxDatabase = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnExtract = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pbCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbxDriver
			// 
			this.cbxDriver.FormattingEnabled = true;
			this.cbxDriver.Location = new System.Drawing.Point(58, 41);
			this.cbxDriver.Name = "cbxDriver";
			this.cbxDriver.Size = new System.Drawing.Size(121, 24);
			this.cbxDriver.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Driver";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Host";
			// 
			// tbxHost
			// 
			this.tbxHost.Location = new System.Drawing.Point(58, 112);
			this.tbxHost.Name = "tbxHost";
			this.tbxHost.Size = new System.Drawing.Size(378, 22);
			this.tbxHost.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(468, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Port";
			// 
			// tbxPort
			// 
			this.tbxPort.Location = new System.Drawing.Point(471, 112);
			this.tbxPort.Name = "tbxPort";
			this.tbxPort.Size = new System.Drawing.Size(100, 22);
			this.tbxPort.TabIndex = 5;
			// 
			// cbxDatabase
			// 
			this.cbxDatabase.FormattingEnabled = true;
			this.cbxDatabase.Location = new System.Drawing.Point(58, 191);
			this.cbxDatabase.Name = "cbxDatabase";
			this.cbxDatabase.Size = new System.Drawing.Size(354, 24);
			this.cbxDatabase.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Database";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 279);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "File &Location";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(64, 321);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(672, 22);
			this.textBox1.TabIndex = 10;
			// 
			// btnExtract
			// 
			this.btnExtract.Location = new System.Drawing.Point(648, 362);
			this.btnExtract.Name = "btnExtract";
			this.btnExtract.Size = new System.Drawing.Size(75, 23);
			this.btnExtract.TabIndex = 11;
			this.btnExtract.Text = "Extract";
			this.btnExtract.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(648, 391);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Create";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pbCancel
			// 
			this.pbCancel.Location = new System.Drawing.Point(64, 391);
			this.pbCancel.Name = "pbCancel";
			this.pbCancel.Size = new System.Drawing.Size(75, 23);
			this.pbCancel.TabIndex = 13;
			this.pbCancel.Text = "Cancel";
			this.pbCancel.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pbCancel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnExtract);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbxDatabase);
			this.Controls.Add(this.tbxPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxHost);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxDriver);
			this.Name = "SchemaTool";
			this.Text = "SchemaTool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxDriver;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxHost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxPort;
		private System.Windows.Forms.ComboBox cbxDatabase;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnExtract;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button pbCancel;
	}
}

