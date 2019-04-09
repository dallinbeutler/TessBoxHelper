using Caliburn.Micro;
using Gemini.Framework;
using Gemini.Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TessBoxHelper.Modules.ViewModels;

namespace TessBoxHelper
{
    [Export(typeof(IEditorProvider))]
    public class EditorProvider : IEditorProvider
    {
        private List<EditorFileType> _FileTypes = new List<EditorFileType> {
          new EditorFileType("PNG", ".png")
         ,new EditorFileType("JPEG", ".jpeg")
         ,new EditorFileType("jpg", ".jpg")
         ,new EditorFileType("bmp", ".bmp")
         ,new EditorFileType("tiff", ".tiff")
         ,new EditorFileType("tif", ".tif")
      };

        public IEnumerable<EditorFileType> FileTypes
        {
            get
            {
                return _FileTypes;
            }
        }

        public bool Handles(string path)
        {
            var extension = Path.GetExtension(path);
            bool result = extension != null && _FileTypes.First(x => x.FileExtension == extension) != null;//extension == ".txt";
            return result;
        }

        public IDocument Create()
        {
            return IoC.Get<BoxMakerViewModel>();
        }

        public async Task New(IDocument document, string name)
        {
            await ((BoxMakerViewModel)document).New(name);
        }

        public async Task Open(IDocument document, string path)
        {
            await ((BoxMakerViewModel)document).Load(path);
        }
    }
}
