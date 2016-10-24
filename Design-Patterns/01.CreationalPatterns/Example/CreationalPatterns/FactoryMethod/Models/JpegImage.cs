using FactoryMethod.Contracts;
using System;

namespace FactoryMethod.Models
{
    public class JpegImage : Image
    {
        public Thumbnail CreateThumbnail()
        {
            return new Thumbnail();
        }
    }
}
