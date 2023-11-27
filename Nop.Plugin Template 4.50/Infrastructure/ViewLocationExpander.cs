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
                viewLocations = new[] {
                    $"~/Plugins/{Defaults.SYSTEM_NAME}/Areas/Admin/Views/{{1}}/{{0}}.cshtml"
                }
                .Concat(viewLocations);
            }
            else
            {
                viewLocations = new[] {
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
