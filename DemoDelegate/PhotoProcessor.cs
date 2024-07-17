using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    internal class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler handler)
        {
            var photo = Photo.Load(path);
            handler(photo);
            photo.Save();
        }

        public void ProcessDelegate(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            PhotoFilterHandler handler;
            handler = filters.ApplyBrightness;
            handler += filters.ApplyContrast;
            handler += filters.Resize;
            handler(photo);

            photo.Save();
        }
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}
