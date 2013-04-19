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
	public class AttributeControllerTests
	{
		[Test]
		public void TestGameControllerEdit()
		{
			var attributeController = new AttributeController();
			var rootIds = NSubstitute.Substitute.For<List<int>>(10);
			var rootContainer =  attributeController.GetRoots(rootIds);
			Assert.IsNotNull(rootContainer);
		}
	}
}
