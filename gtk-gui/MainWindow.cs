
// This file has been generated by the GUI designer. Do not modify.
using Gtk;
using Stetic;
using Mono.Unix;
using System;

public partial class MainWindow
{
	private Fixed mainWidget;

private Entry loksimEditPathField;

private Button loksimeditExeButton;

private Entry objectPathEntry;

private Button objectButton;

private Label destinationPathLabel;

private Label objectPathLabel;

private Label label1;

private Entry destinationPathEntry;

private Button destinationButton;

private Button convertButton;


	protected virtual void Build()
	{
		Gui.Initialize(this);
		base.Name = "MainWindow";
		base.Title = Catalog.GetString("Assimp-Converter-GUI");
		base.WindowPosition = WindowPosition.CenterOnParent;
mainWidget = new Fixed();
mainWidget.Name = "mainWidget";
		mainWidget.HasWindow = false;
		loksimEditPathField = new Entry();
loksimEditPathField.WidthRequest = 484;
		loksimEditPathField.CanFocus = true;
		loksimEditPathField.Name = "loksimEditPathField";
		loksimEditPathField.IsEditable = true;
		loksimEditPathField.InvisibleChar = '●';
		mainWidget.Add(loksimEditPathField);
		Fixed.FixedChild w19 = (Fixed.FixedChild)((Container)mainWidget)[loksimEditPathField];
w19.X = 28;
		w19.Y = 81;
		loksimeditExeButton = new Button();
loksimeditExeButton.CanFocus = true;
		loksimeditExeButton.Name = "loksimeditExeButton";
		loksimeditExeButton.UseUnderline = true;
		loksimeditExeButton.Label = Catalog.GetString("Datei auswählen");
		mainWidget.Add(loksimeditExeButton);
		Fixed.FixedChild w18 = (Fixed.FixedChild)((Container)mainWidget)[loksimeditExeButton];
w18.X = 523;
		w18.Y = 79;
		objectPathEntry = new Entry();
objectPathEntry.WidthRequest = 480;
		objectPathEntry.CanFocus = true;
		objectPathEntry.Name = "objectPathEntry";
		objectPathEntry.IsEditable = true;
		objectPathEntry.InvisibleChar = '●';
		mainWidget.Add(objectPathEntry);
		Fixed.FixedChild w17 = (Fixed.FixedChild)((Container)mainWidget)[objectPathEntry];
w17.X = 30;
		w17.Y = 168;
		objectButton = new Button();
objectButton.CanFocus = true;
		objectButton.Name = "objectButton";
		objectButton.UseUnderline = true;
		objectButton.Label = "Datei auswählen";
		mainWidget.Add(objectButton);
		Fixed.FixedChild w16 = (Fixed.FixedChild)((Container)mainWidget)[objectButton];
w16.X = 522;
		w16.Y = 166;
		destinationPathLabel = new Label();
destinationPathLabel.Name = "destinationPathLabel";
		destinationPathLabel.LabelProp = "Zielpfad nach der Konvertierung (leerer Ordner!):";
		mainWidget.Add(destinationPathLabel);
		Fixed.FixedChild w15 = (Fixed.FixedChild)((Container)mainWidget)[destinationPathLabel];
w15.X = 35;
		w15.Y = 232;
		objectPathLabel = new Label();
objectPathLabel.Name = "objectPathLabel";
		objectPathLabel.LabelProp = "Pfad zum Objekt:";
		mainWidget.Add(objectPathLabel);
		Fixed.FixedChild w14 = (Fixed.FixedChild)((Container)mainWidget)[objectPathLabel];
w14.X = 34;
		w14.Y = 145;
		label1 = new Label();
label1.Name = "label1";
		label1.LabelProp = "Pfad zur LoksimEdit.exe:";
		mainWidget.Add(label1);
		Fixed.FixedChild w13 = (Fixed.FixedChild)((Container)mainWidget)[label1];
w13.X = 32;
		w13.Y = 60;
		destinationPathEntry = new Entry();
destinationPathEntry.WidthRequest = 480;
		destinationPathEntry.CanFocus = true;
		destinationPathEntry.Name = "destinationPathEntry";
		destinationPathEntry.IsEditable = true;
		destinationPathEntry.InvisibleChar = '●';
		mainWidget.Add(destinationPathEntry);
		Fixed.FixedChild w12 = (Fixed.FixedChild)((Container)mainWidget)[destinationPathEntry];
w12.X = 25;
		w12.Y = 254;
		destinationButton = new Button();
destinationButton.CanFocus = true;
		destinationButton.Name = "destinationButton";
		destinationButton.UseUnderline = true;
		destinationButton.Label = Catalog.GetString("Ordner auswählen");
		mainWidget.Add(destinationButton);
		Fixed.FixedChild w11 = (Fixed.FixedChild)((Container)mainWidget)[destinationButton];
w11.X = 520;
		w11.Y = 253;
		convertButton = new Button();
convertButton.CanFocus = true;
		convertButton.Name = "convertButton";
		convertButton.UseUnderline = true;
		convertButton.Label = Catalog.GetString("Konvertieren");
		mainWidget.Add(convertButton);
		Fixed.FixedChild w10 = (Fixed.FixedChild)((Container)mainWidget)[convertButton];
w10.X = 646;
		w10.Y = 373;
		base.Add(mainWidget);
		if (base.Child != null)
		{
			base.Child.ShowAll();
		}
		base.DefaultWidth = 748;
		base.DefaultHeight = 443;
		base.Show();
		base.DeleteEvent += OnDeleteEvent;
		loksimeditExeButton.Clicked += LoksimExeButtonOnClick;
		objectButton.Clicked += ObjectButtonOnClick;
		destinationButton.Clicked += DestinationButtonOnClick;
		convertButton.Clicked += convertButtonClicked;
	}
}
