using Microsoft.AspNetCore.Mvc.Razor;
using $safeprojectname$;

using System.Collections.Generic;
using System.Linq;

namespace $safeprojectname$.Infrastructure
{
    public class ViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (context.AreaName == "Admin")
            {
                // Admin paths
                viewLocations = new[] {
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Areas/Admin/Views/{{1}}/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Areas/Admin/Views/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Areas/Admin/Views/Shared/{{1}}/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Areas/Admin/Views/Shared/{{0}}.cshtml",
                }
                .Concat(viewLocations);
            }
            else
            {
                // Theme Paths
                viewLocations = new string[]
                {
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Themes/Pacific/Views/{{1}}/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Themes/Pacific/Views/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Themes/Pacific/Views/Shared/{{1}}/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Themes/Pacific/Views/Shared/{{0}}.cshtml",
                }
                .Concat(viewLocations);

                // Plugin Paths
                viewLocations = new[]
                {
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Views/{{1}}/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Views/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Views/Shared/{{1}}/{{0}}.cshtml",
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Views/Shared/{{0}}.cshtml",
                }
                .Concat(viewLocations);
            }

            return viewLocations;
        }
    }
}
