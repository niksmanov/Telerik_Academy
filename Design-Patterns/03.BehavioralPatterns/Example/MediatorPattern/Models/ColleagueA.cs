using System;

namespace MediatorPattern.Models
{
    public class ColleagueA : Colleague
    {
        public ColleagueA(Mediator mediator) : base(mediator)
        {
        }

        public void Send()
        {
            Console.WriteLine("ColleagueA sent message");
            this.mediator.SendMessage(this);
        }

        public void Receive()
        {
            Console.WriteLine("ColleagueA received message");
        }
    }
}
