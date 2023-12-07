namespace Dedicated_Host_Switch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnTrue = new Button();
			btnFalse = new Button();
			btnToggle = new Button();
			btnChangeFile = new Button();
			LuaFileOpenDialog = new OpenFileDialog();
			SuspendLayout();
			// 
			// btnTrue
			// 
			btnTrue.Location = new Point(12, 13);
			btnTrue.Name = "btnTrue";
			btnTrue.Size = new Size(111, 27);
			btnTrue.TabIndex = 0;
			btnTrue.Text = "Set to True";
			btnTrue.UseVisualStyleBackColor = true;
			btnTrue.Click += TrueButtonHandler;
			// 
			// btnFalse
			// 
			btnFalse.Location = new Point(129, 12);
			btnFalse.Name = "btnFalse";
			btnFalse.Size = new Size(111, 27);
			btnFalse.TabIndex = 1;
			btnFalse.Text = "Set to False";
			btnFalse.UseVisualStyleBackColor = true;
			btnFalse.Click += FalseButtonHandler;
			// 
			// btnToggle
			// 
			btnToggle.Location = new Point(246, 13);
			btnToggle.Name = "btnToggle";
			btnToggle.Size = new Size(111, 27);
			btnToggle.TabIndex = 2;
			btnToggle.Text = "Toggle State";
			btnToggle.UseVisualStyleBackColor = true;
			btnToggle.Click += ToggleButtonHandler;
			// 
			// btnChangeFile
			// 
			btnChangeFile.Location = new Point(12, 59);
			btnChangeFile.Name = "btnChangeFile";
			btnChangeFile.Size = new Size(345, 36);
			btnChangeFile.TabIndex = 3;
			btnChangeFile.Text = "Change File";
			btnChangeFile.UseVisualStyleBackColor = true;
			btnChangeFile.Click += ChangeFileButtonHandler;
			// 
			// LuaFileOpenDialog
			// 
			LuaFileOpenDialog.Filter = "Lua Source File|*.lua";
			// 
			// Form1
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(376, 106);
			Controls.Add(btnChangeFile);
			Controls.Add(btnToggle);
			Controls.Add(btnFalse);
			Controls.Add(btnTrue);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "Form1";
			Text = "Dedicated Host Switch";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion
		private Button btnTrue;
        private Button btnFalse;
        private Button btnToggle;
        private Button btnChangeFile;
		private OpenFileDialog LuaFileOpenDialog;
	}
}