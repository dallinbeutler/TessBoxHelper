using Gemini.Framework;
using Gemini.Framework.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TessBoxHelper.Modules.ViewModels
{
    [Export(typeof(BoxMakerViewModel))]
    class BoxMakerViewModel : PersistedDocument
    {
        public string ImagePath { get; set; }
        protected override Task DoLoad(string filePath)
        {
            ImagePath = filePath;
            return TaskUtility.Completed;
        }

        protected override Task DoNew()
        {
            throw new NotImplementedException();
        }

        protected override Task DoSave(string filePath)
        {
            throw new NotImplementedException();
        }
        public void MouseDown()//object sender,  MouseButtonEventArgs me )
        {

        }
        public void MouseDragging(object sender, MouseEventArgs me)
        {

        }
        public void MouseUp(object sender, MouseButtonEventArgs me)
        {

        }
    }
}
