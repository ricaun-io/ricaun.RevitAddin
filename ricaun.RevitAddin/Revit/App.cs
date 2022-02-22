using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ricaun.Revit.UI;
using System;

namespace ricaun.RevitAddin.Revit
{
    [Console]
    public class App : IExternalApplication
    {
        private RibbonPanel panel;

        public Result OnStartup(UIControlledApplication application)
        {
            panel = application.CreatePanel("RevitAddin");
            var button = panel.AddPushButton<Commands.Command>();
            button.LargeImage = Resources.Resource.RevitAddin32.GetBitmapSource();
            button.Image = Resources.Resource.RevitAddin32.GetBitmapSource().Scale(0.5);
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            panel.Remove();
            return Result.Succeeded;
        }
    }
}
