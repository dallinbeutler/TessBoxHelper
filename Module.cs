using Caliburn.Micro;
using Gemini.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TessBoxHelper.Modules.ViewModels;

namespace TessBoxHelper
{
    [Export(typeof(IModule))]
    class Module : ModuleBase
    {
        Module()
        {
            var file = new BoxMakerViewModel();//IoC.Get<BoxMakerViewModel>();

            file.ImagePath = @"C:\Users\BeutlerD\Pictures\front.tif";
            this.Shell.OpenDocument(file);
        }
    }
}
