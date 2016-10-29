namespace MediatorPattern.Models
{
    public class Mediator : MediatorBase
    {
        public ColleagueA Colleague1 { get; set; }

        public ColleagueB Colleague2 { get; set; }

        public override void SendMessage(Colleague caller)
        {
            if (caller == Colleague1)
            {
                Colleague2.Receive();
            }
        }
    }
}
