
namespace MediatorPattern.Models
{
    public abstract class MediatorBase
    {
        public abstract void SendMessage(Colleague caller);
    }
}
