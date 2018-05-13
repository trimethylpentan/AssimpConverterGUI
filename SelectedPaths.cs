using System.Diagnostics;
using System.IO;

namespace AssimpConverterGUI
{
	public class SelectedPaths
	{
		public string loksimEditExePath;

		public string objectPath;

		public string destinationPath;

		public void ExecuteConvert()
		{
			string command = loksimEditExePath + " -convert " + objectPath + " " + destinationPath + "\\" + Path.GetFileName(objectPath);
			Process.Start("cmd", "/C " + command);
		}

		public bool isValid()
		{
			if (loksimEditExePath != "" && objectPath != "" && destinationPath != "")
			{
				return true;
			}
			return false;
		}
	}
}