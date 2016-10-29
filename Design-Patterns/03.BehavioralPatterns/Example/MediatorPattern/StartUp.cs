using MediatorPattern.Models;

namespace MediatorPattern
{
    class StartUp
    {
        static void Main()
        {
            var mediator = new Mediator();
            var firstColleague = new ColleagueA(mediator);
            var secondColleague = new ColleagueB(mediator);

            firstColleague.Send();
            secondColleague.Receive();
            mediator.SendMessage(firstColleague);       

        }
    }
}
