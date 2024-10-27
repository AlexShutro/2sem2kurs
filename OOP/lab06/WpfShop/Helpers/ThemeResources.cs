using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfShop {
    internal static class ThemeResources {
        public static ResourceDictionary White = new ResourceDictionary() { Source = new Uri(@"Themes\White.xaml", UriKind.Relative) };
        public static ResourceDictionary Beach = new ResourceDictionary() { Source = new Uri(@"Themes\Beach.xaml", UriKind.Relative) };
        public static ResourceDictionary Space = new ResourceDictionary() { Source = new Uri(@"Themes\Space.xaml", UriKind.Relative) };
        public static ResourceDictionary Colors = new ResourceDictionary() { Source = new Uri(@"Themes\Colors.xaml", UriKind.Relative) };

        public static ResourceDictionary GetResource(ThemeCode themeCode) {
            switch (themeCode) {
                case ThemeCode.White: return White;
                case ThemeCode.Beach: return Beach;
                case ThemeCode.Space: return Space;
                case ThemeCode.Colors: return Colors;
                default: throw new ArgumentException($"No theme resourse for code '{themeCode}'");
            }
        }
    }
}
