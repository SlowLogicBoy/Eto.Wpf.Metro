using Eto.Wpf.Forms;

namespace Eto.Wpf.Metro.Forms
{
	public class MetroApplicationHandler : ApplicationHandler
	{
		protected override void Initialize()
		{
			base.Initialize();
			Control.AddResources();
		}
	}
}