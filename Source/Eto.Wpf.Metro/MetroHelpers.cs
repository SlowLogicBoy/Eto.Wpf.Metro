using System;
using System.Windows;

namespace Eto.Wpf.Metro
{
	static class MetroHelpers
	{
	    private static readonly string[] ResourceSources =
	    {
	        "pack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseDark.xaml",
	        "pack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml",
	        "pack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml",
	        "pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml",
	        "pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml"
        };

		public static void AddResources(this FrameworkElement frameworkElement)
		{
		    foreach (var resourceSource in ResourceSources)
		    {
			    frameworkElement.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri(resourceSource, UriKind.RelativeOrAbsolute) });
            }
        }

		public static void AddResources(this Application app)
		{
		    foreach (var resourceSource in ResourceSources)
		    {
		        app.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri(resourceSource, UriKind.RelativeOrAbsolute) });
		    }
        }
	}
}
