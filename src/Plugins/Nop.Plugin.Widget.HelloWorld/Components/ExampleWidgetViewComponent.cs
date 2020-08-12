using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Widget.HelloWorld.Components
{
    [ViewComponent(Name = "HelloWorldWidget")]
    public class ExampleWidgetViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke(string widgetZone)
        {
            return Content("Hello World");
        }
    }
}
