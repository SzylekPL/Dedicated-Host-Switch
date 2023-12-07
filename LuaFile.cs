namespace Dedicated_Host_Switch
{
	internal static class LuaFile
	{
		private static string? Path;
		private static string[] Content;
		internal static bool DedicatedHost
		{
			get => Content[11] == @"	DedicatedHost = true,";
			set
			{
				if (value)
					Content[11] = @"	DedicatedHost = true,";
				else
					Content[11] = @"	DedicatedHost = false,";
			}
		}
		internal static void Initialize(string? arg = null)
		{
			arg ??= SaveFile.Content;
			Path = arg;
			Content = File.ReadAllLines(Path);
		}
		internal static void Save() => File.WriteAllLines(Path, Content);
	}
}
