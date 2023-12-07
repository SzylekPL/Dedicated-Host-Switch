namespace Dedicated_Host_Switch
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (SaveFile.Empty)
			{
				while (LuaFileOpenDialog.ShowDialog() != DialogResult.OK) ;
				SaveFile.Content = LuaFileOpenDialog.FileName;
				LuaFile.Initialize(LuaFileOpenDialog.FileName);
				return;
			}
			LuaFile.Initialize();
		}
		private void TrueButtonHandler(object sender, EventArgs e)
		{
			LuaFile.DedicatedHost = true;
			LuaFile.Save();
		}

		private void FalseButtonHandler(object sender, EventArgs e)
		{
			LuaFile.DedicatedHost = false;
			LuaFile.Save();
		}

		private void ToggleButtonHandler(object sender, EventArgs e)
		{
			LuaFile.DedicatedHost = !LuaFile.DedicatedHost;
			LuaFile.Save();
		}

		private void ChangeFileButtonHandler(object sender, EventArgs e)
		{
			if (LuaFileOpenDialog.ShowDialog() == DialogResult.OK)
			{
				SaveFile.Content = LuaFileOpenDialog.FileName;
				LuaFile.Initialize(LuaFileOpenDialog.FileName);
			}
		}

	}
}