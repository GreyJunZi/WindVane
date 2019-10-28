using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindVane.PiliPala.Infrastructure.Themes
{
    public class ThemeableViewLocationExpander : IViewLocationExpander
    {
        private const string THEME_KEY = "Theme";
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            context.Values.TryGetValue(THEME_KEY, out string theme);

            if (!string.IsNullOrEmpty(theme))
            {
                viewLocations = new[] {
                    $"/Themes/{theme}/Areas/{{2}}/Views/{{1}}/{{0}}.cshtml",
                    $"/Themes/{theme}/Areas/{{2}}/Views/Shared/{{0}}.cshtml",
                    $"/Themes/{theme}/Views/{{1}}/{{0}}.cshtml",
                    $"/Themes/{theme}/Views/Shared/{{0}}.cshtml",
                }.Concat(viewLocations);
            }

            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            if (context == null)
                return;

            if (context.ActionContext.ActionDescriptor.DisplayName == null)
                return;

            IThemeContext themeContext = (IThemeContext)context.ActionContext.HttpContext.RequestServices.GetService(typeof(IThemeContext));
            if (themeContext == null)
                return;

            context.Values[THEME_KEY] = themeContext.ThemeName;
        }
    }
}
