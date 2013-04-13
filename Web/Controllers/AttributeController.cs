using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Pitchtrack.Web.Models.Json;

namespace Pitchtrack.Web.Controllers
{
	public class AttributeController : ApiController
	{
		private static int _idSeed = 1;

		private static readonly Dictionary<int, jAttributeRoot> FakeRepo =
			new[]
				{
					new jAttributeRoot
						{
							GroupId = NextId(), Name = "Pitch Type", Attributes = new[]
								                                                      {
									                                                      new jAttribute {AttributeId = NextId(), Name = "fastball"},
									                                                      new jAttribute {AttributeId = NextId(), Name = "change up"},
									                                                      new jAttribute {AttributeId = NextId(), Name = "curve ball"},
									                                                      new jAttribute {AttributeId = NextId(), Name = "splitter"},
									                                                      new jAttribute {AttributeId = NextId(), Name = "two seamer"},
								                                                      }
						},
					new jAttributeRoot
						{
							GroupId = NextId(), Name = "Ball/Strike", Attributes = new[]
								                                                       {
									                                                       new jAttribute {AttributeId = NextId(), Name = "ball"},
									                                                       new jAttribute {AttributeId = NextId(), Name = "strike"},
								                                                       }
						},
					new jAttributeRoot
						{
							GroupId = NextId(), Name = "Pitch Result", Attributes = new[]
								                                                        {
									                                                        new jAttribute {AttributeId = NextId(), Name = "k"},
									                                                        new jAttribute {AttributeId = NextId(), Name = "ʞ"},
									                                                        new jAttribute {AttributeId = NextId(), Name = "foul"},
									                                                        new jAttribute {AttributeId = NextId(), Name = "BB"},
									                                                        new jAttribute {AttributeId = NextId(), Name = "HBP "},
									                                                        new jAttribute
										                                                        {
											                                                        AttributeId = NextId(), Name = "in play", Attributes = new[]
												                                                                                                               {
													                                                                                                               new jAttribute {AttributeId = NextId(), Name = "ground ball"},
													                                                                                                               new jAttribute {AttributeId = NextId(), Name = "line drive"},
													                                                                                                               new jAttribute {AttributeId = NextId(), Name = "fly ball"},
												                                                                                                               }
										                                                        },
								                                                        }
						},
					new jAttributeRoot
						{
							GroupId = NextId(), Name = "MPH", Attributes = new[]
								                                               {
									                                               new jAttribute {AttributeId = NextId(), Name = "75"},
									                                               new jAttribute {AttributeId = NextId(), Name = "76"},
									                                               new jAttribute {AttributeId = NextId(), Name = "77"},
									                                               new jAttribute {AttributeId = NextId(), Name = "78"},
									                                               new jAttribute {AttributeId = NextId(), Name = "79"},
									                                               new jAttribute {AttributeId = NextId(), Name = "80"},
									                                               new jAttribute {AttributeId = NextId(), Name = "81"},
									                                               new jAttribute {AttributeId = NextId(), Name = "82"},
									                                               new jAttribute {AttributeId = NextId(), Name = "83"},
									                                               new jAttribute {AttributeId = NextId(), Name = "84"},
									                                               new jAttribute {AttributeId = NextId(), Name = "85"},
									                                               new jAttribute {AttributeId = NextId(), Name = "86"},
									                                               new jAttribute {AttributeId = NextId(), Name = "87"},
									                                               new jAttribute {AttributeId = NextId(), Name = "88"},
									                                               new jAttribute {AttributeId = NextId(), Name = "89"},
									                                               new jAttribute {AttributeId = NextId(), Name = "90"},
									                                               new jAttribute {AttributeId = NextId(), Name = "91"},
									                                               new jAttribute {AttributeId = NextId(), Name = "92"},
									                                               new jAttribute {AttributeId = NextId(), Name = "93"},
									                                               new jAttribute {AttributeId = NextId(), Name = "94"},
									                                               new jAttribute {AttributeId = NextId(), Name = "95"},
									                                               new jAttribute {AttributeId = NextId(), Name = "96"},
									                                               new jAttribute {AttributeId = NextId(), Name = "97"},
									                                               new jAttribute {AttributeId = NextId(), Name = "98"},
									                                               new jAttribute {AttributeId = NextId(), Name = "99"},
									                                               new jAttribute {AttributeId = NextId(), Name = "100"},
									                                               new jAttribute {AttributeId = NextId(), Name = "101"},
									                                               new jAttribute {AttributeId = NextId(), Name = "102"},
									                                               new jAttribute {AttributeId = NextId(), Name = "103"},
								                                               }
						},
				}.ToDictionary(group => group.GroupId, group => group);

		private static int NextId()
		{
			return _idSeed++;
		}


		public IEnumerable<jAttributeRoot> GetRoots(IEnumerable<int> rootIds)
		{
			if (rootIds.IsNullOrEmpty())
				return FakeRepo.Select(x => x.Value).ToArray();

			return rootIds.Select(rootId =>
				                      {
					                      jAttributeRoot root;
					                      return FakeRepo.TryGetValue(rootId, out root)
						                             ? root
						                             : null;
				                      }).Where(x => null != x).ToArray();
		}
	}
}