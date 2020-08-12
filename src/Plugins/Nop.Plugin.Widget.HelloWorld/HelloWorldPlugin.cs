using Nop.Services.Cms;
using Nop.Services.Plugins;
using System;
using System.Collections.Generic;

namespace Nop.Plugin.Widget.HelloWorld
{
    public class HelloWorldPlugin : BasePlugin, IWidgetPlugin
    {
        /// <summary>
        /// Gets a value indicating whether to hide this plugin on the widget list page in the admin area
        /// </summary>
        public bool HideInWidgetList => false;

        bool IWidgetPlugin.HideInWidgetList => throw new NotImplementedException();

        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "HelloWorldWidget";
        }

        /// <summary>
        /// Gets a name of a view component for displaying widget
        /// </summary>
        /// <param name="widgetZone">Name of the widget zone</param>
        /// <returns>View component name</returns>
        public IList<string> GetWidgetZones()
        {
            return new List<string> { "home_page_before_categories" };
        }

        public override void Install()
        {
            //Logic during installation goes here...

            base.Install();
        }

        public override void Uninstall()
        {
            //Logic during uninstallation goes here...

            base.Uninstall();
        }

        //string IWidgetPlugin.GetWidgetViewComponentName(string widgetZone)
        //{
        //    throw new NotImplementedException();
        //}

        //IList<string> IWidgetPlugin.GetWidgetZones()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
