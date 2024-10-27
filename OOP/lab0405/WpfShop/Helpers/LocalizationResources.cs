using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfShop {
    internal static class LocalizationResources {
        public static ResourceDictionary RU = new ResourceDictionary() { Source = new Uri(@"Localizations\RU.xaml", UriKind.Relative) };
        public static ResourceDictionary EN = new ResourceDictionary() { Source = new Uri(@"Localizations\EN.xaml", UriKind.Relative) };

        public static ResourceDictionary GetResource(LocalizationCode localizationCode) {
            switch (localizationCode) {
                case LocalizationCode.RU: return RU;
                case LocalizationCode.EN: return EN;
                default: throw new ArgumentException($"No localization resourse for code '{localizationCode}'");
            }
        }
    }
}
