using System.Windows;
using Eto.Drawing;
using Eto.Forms;
using Eto.Forms.ThemedControls;
using Eto.Wpf.Forms;
using Eto.Wpf.Metro.Forms;
using Eto.Wpf.Metro.Forms.Controls;
using MahApps.Metro.Controls;
using Application = Eto.Forms.Application;

namespace Eto.Wpf.Metro
{
	public class MetroSpinnerHandler : WpfFrameworkElement<ProgressRing, Spinner, Control.ICallback>, Spinner.IHandler
	{
		public MetroSpinnerHandler()
		{
			Control = new ProgressRing();
		}

		public override bool Enabled
		{
			get => Control.IsActive;
			set => Control.IsActive = value;
		}

		public override Color BackgroundColor
		{
			get => Control.Background.ToEtoColor();
			set => Control.Background = value.ToWpfBrush();
		}
	}

	public class Platform : Wpf.Platform
	{
		public Platform()
		{
			Add(typeof(Form.IHandler), () => new MetroFormHandler());
			Add(typeof(Dialog.IHandler), () => new MetroDialogHandler());
			Add(typeof(TextBox.IHandler), () => new MetroTextBoxHandler());
			Add(typeof(Button.IHandler), () => new MetroButtonHandler());
			Add(typeof(Spinner.IHandler), () => new MetroSpinnerHandler());
			Add(typeof(Application.IHandler), () => new MetroApplicationHandler());
		}
	}
}
