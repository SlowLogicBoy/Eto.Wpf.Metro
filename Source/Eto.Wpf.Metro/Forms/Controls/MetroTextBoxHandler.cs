using System.Windows.Controls;
using Eto.Wpf.Forms.Controls;
using MahApps.Metro.Controls;

namespace Eto.Wpf.Metro.Forms.Controls
{
	public class MetroTextBoxHandler : TextBoxHandler<TextBox, Eto.Forms.TextBox, Eto.Forms.TextBox.ICallback>
	{
		protected override void Initialize()
		{
			base.Initialize();
			Control.AddResources();
		}

		public MetroTextBoxHandler()
		{
			Control = new TextBox();
		}
		protected override TextBox TextBox => Control;

		public override string PlaceholderText
		{
			get => TextBoxHelper.GetWatermark(Control);
			set => TextBoxHelper.SetWatermark(Control, value);
		}

		public bool ShowClearTextButton
		{
			get => TextBoxHelper.GetClearTextButton(Control);
			set => TextBoxHelper.SetClearTextButton(Control, value);
		}
	}
}