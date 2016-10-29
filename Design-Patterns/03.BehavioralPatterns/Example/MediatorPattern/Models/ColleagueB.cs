using System;

namespace MediatorPattern.Models
{
    public class ColleagueB : Colleague
    {
        public ColleagueB(Mediator mediator) : base(mediator)
        {
        }

        public void Send()
        {
            Console.WriteLine("ColleagueB sent message");
            this.mediator.SendMessage(this);
        }

        public void Receive()
        {
            Console.WriteLine("ColleagueB received message");
        }
    }
}
