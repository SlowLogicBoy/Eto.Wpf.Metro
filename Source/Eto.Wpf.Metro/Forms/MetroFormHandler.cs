using Eto.Wpf.Forms;
using MahApps.Metro.Controls;

namespace Eto.Wpf.Metro.Forms
{
	public class MetroFormHandler : FormHandler
	{
		protected override System.Windows.Window CreateControl() => new MetroWindow();
		public MetroFormHandler(System.Windows.Window window) : base(window) { }
		public MetroFormHandler() : base(new MetroWindow()) { }
	}
}