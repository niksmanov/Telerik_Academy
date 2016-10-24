using FactoryMethod.Models;

namespace FactoryMethod.Contracts
{
    public interface Image
    {
        Thumbnail CreateThumbnail();
    }
}
