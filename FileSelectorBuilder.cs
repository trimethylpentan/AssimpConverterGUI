using Gtk;
namespace AssimpConverterGUI
{
	public class FileSelectorBuilder
	{
		string headerText = "Datei auswählen";

		FileChooserAction fileChooserAction = FileChooserAction.Open;

		public void setHeaderText(string headerText)
		{
			this.headerText = headerText;
		}

		public void setFileChooserAction(FileChooserAction fileChooserAction)
		{
			this.fileChooserAction = fileChooserAction;
		}

		public FileChooserDialog buildFileChooser(Window parentWindow)
		{
			return new FileChooserDialog(headerText, parentWindow, fileChooserAction, "Auswählen", ResponseType.Ok, "Abbrechen", ResponseType.Close);
		}
	}
}