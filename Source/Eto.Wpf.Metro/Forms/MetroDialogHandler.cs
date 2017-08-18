using Eto.Wpf.Forms;
using MahApps.Metro.Controls;

namespace Eto.Wpf.Metro.Forms
{
	public class MetroDialogHandler : DialogHandler
	{
		public MetroDialogHandler() : base(new MetroWindow()) { }

		protected override void Initialize()
		{
			base.Initialize();
			Control.AddResources();
		}

		protected override void SetResizeMode()
		{
			base.SetResizeMode();

			var win = Control as MetroWindow;
			if (win != null)
			{
				win.ShowMinButton = Minimizable;
				win.ShowMaxRestoreButton = Resizable && Maximizable;
			}
		}
	}
}