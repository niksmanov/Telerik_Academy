using FactoryMethod.Contracts;

namespace FactoryMethod.Models
{
    public class GifImage : Image
    {
        public Thumbnail CreateThumbnail()
        {
            return new Thumbnail();
        }
    }
}
