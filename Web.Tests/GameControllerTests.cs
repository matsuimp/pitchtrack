using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pitchtrack.Web.Controllers;

namespace Pitchtrack.Web.Tests
{
	[TestFixture]
	public class GameControllerTests
	{
		[Test]
		public void TestGameControllerEdit()
		{
			var gameController = new GameController();
			var result = gameController.Edit();
			Assert.IsNotNull(result);
		}
	}
}
