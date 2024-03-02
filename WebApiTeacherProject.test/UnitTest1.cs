using Microsoft.AspNetCore.Http.HttpResults;
using WebApiWithController.Controllers;
using Tournament_Management_System.Models;
namespace WebApiTeacherProject.test
{
    public class Tests
    {
        private SportsController controller;
        [SetUp]
        public void Setup()
        {
            controller = new SportsController();
        }

        [Test]
        public void TestMethodForGetTournament()
        {
            IEnumerable<Sportsmodal> result = controller.GetTournament();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostTournament()
        {
            var newItem = new Sportsmodal
            {
                Tournament_Id = 1,
                Tournament_type = "test",
                Tournament_name = "test",
                Maximum_players = 1,
                Total_prizes_count = 1,
                First_price_amount = 1,
                Second_price_count = 1,
                Consolation_prize_amount = 1
            };
            var actionResult = controller.PostTournament(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostTournamentNull()
        {
            var newItem = new Sportsmodal
            {
                Tournament_Id = 1,
                Tournament_type = null,
                Tournament_name = null,
                Maximum_players = null,
                Total_prizes_count = null,
                First_price_amount = null,
                Second_price_count = null,
                Consolation_prize_amount = null
            };
            var actionResult = controller.PostTournament(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}

/*tournament type,tournament name ,maximum players
  total prizes count,first price amount,second price count,consolation prize amount*/