using System;
using Gtk;
using AssimpConverterGUI;

public partial class MainWindow : Gtk.Window
{
    FileSelectorBuilder fileSelectorBuilder = new FileSelectorBuilder();

    SelectedPaths selectedPaths = new SelectedPaths();

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void LoksimExeButtonOnClick(object sender, EventArgs e)
	{
		fileSelectorBuilder.setHeaderText("Loksimedit.exe auswählen");
		FileChooserDialog fileChooser = fileSelectorBuilder.buildFileChooser(this);
		fileChooser.SelectMultiple = false;
		if (fileChooser.Run() == -5)
		{
			selectedPaths.loksimEditExePath = fileChooser.Filename;
			SetEntryText("loksimEditPathField", fileChooser.Filename);
		}
		fileChooser.Destroy();
	}

	void SetEntryText(string entryName, string text)
	{
		Fixed child = (Fixed)base.Child;
		Widget[] children = child.Children;
		foreach (Widget childWidget in children)
		{
			if (childWidget.Name == entryName)
			{
				Entry childWidgetEntry = (Entry)childWidget;
				childWidgetEntry.Text = text;
			}
		}
	}

	string GetEntryText(string entryName)
	{
		Fixed child = (Fixed)base.Child;
		Widget[] children = child.Children;
		foreach (Widget childWidget in children)
		{
			if (childWidget.Name == entryName)
			{
				Entry childWidgetEntry = (Entry)childWidget;
				return childWidgetEntry.Text;
			}
		}
		return "";
	}

	protected void ObjectButtonOnClick(object sender, EventArgs e)
	{
		fileSelectorBuilder.setHeaderText("Zu konvertierendes Objekt auswählen");
		FileChooserDialog fileChooser = fileSelectorBuilder.buildFileChooser(this);
		fileChooser.SelectMultiple = false;
		if (fileChooser.Run() == -5)
		{
			SetEntryText("objectPathEntry", fileChooser.Filename);
		}
		fileChooser.Destroy();
	}

	protected void DestinationButtonOnClick(object sender, EventArgs e)
	{
		fileSelectorBuilder.setHeaderText("Zielordner auswählen");
		fileSelectorBuilder.setFileChooserAction(FileChooserAction.SelectFolder);
		FileChooserDialog fileChooser = fileSelectorBuilder.buildFileChooser(this);
		fileChooser.SelectMultiple = false;
		if (fileChooser.Run() == -5)
		{
			selectedPaths.destinationPath = fileChooser.Filename;
			SetEntryText("destinationPathEntry", fileChooser.Filename);
		}
		fileChooser.Destroy();
	}

	protected void convertButtonClicked(object sender, EventArgs e)
	{
		selectedPaths.loksimEditExePath = GetEntryText("loksimEditPathField");
		selectedPaths.objectPath = GetEntryText("objectPathEntry");
		selectedPaths.destinationPath = GetEntryText("destinationPathEntry");
		if (!selectedPaths.isValid())
		{
			MessageDialog errorMessage = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Close, "Alle Parameter müssen angegeben werden!", Array.Empty<object>());
			errorMessage.Run();
			errorMessage.Destroy();
				return;
		}
			selectedPaths.ExecuteConvert();
			MessageDialog successMessage = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Info, ButtonsType.Close, "Objekt wurde erfolgreich nach " + selectedPaths.destinationPath + " konvertiert.", Array.Empty<object>());
			successMessage.Run();
			successMessage.Destroy();		}
}
