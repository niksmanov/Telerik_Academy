using FactoryMethod.Contracts;
using System.Collections.Generic;

namespace FactoryMethod.Models
{
    public class ImageCollection
    {
        private IList<Image> images;

        public ImageCollection(IList<Image> images)
        {
            this.images = images;
        }

        public IList<Thumbnail> CreateThumbnails()
        {
            IList<Thumbnail> thumbnails = new List<Thumbnail>(images.Count);

            foreach (Image th in images)
            {
                thumbnails.Add(th.CreateThumbnail());
            }
            return thumbnails;
        }
    }
}
