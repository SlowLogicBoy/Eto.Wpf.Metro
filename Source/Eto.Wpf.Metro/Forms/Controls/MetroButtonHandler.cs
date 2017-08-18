using Eto.Wpf.Forms;
using Eto.Wpf.Forms.Controls;

namespace Eto.Wpf.Metro.Forms.Controls
{
	public class MetroButtonHandler : ButtonHandler
	{
		protected override void Initialize()
		{
			base.Initialize();
			Control.Style = (System.Windows.Style) ApplicationHandler.Instance.Control.FindResource("MetroFlatButton");
		}
	}
}