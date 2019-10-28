using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindVane.PiliPala.Infrastructure.Themes
{
    public class ThemeContext : IThemeContext
    {
        private string _cachedThemeName;
        public string ThemeName
        {
            get
            {
                if (string.IsNullOrEmpty(_cachedThemeName))
                    _cachedThemeName = "Default";

                return _cachedThemeName;
            }
        }
    }
}
