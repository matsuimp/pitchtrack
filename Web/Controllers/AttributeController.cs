using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ModelBinding;
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
							groupId = NextId(), name = "Pitch Type", attributes = new[]
								                                                      {
									                                                      new jAttribute {attributeId = NextId(), name = "fastball"},
									                                                      new jAttribute {attributeId = NextId(), name = "change up"},
									                                                      new jAttribute {attributeId = NextId(), name = "curve ball"},
									                                                      new jAttribute {attributeId = NextId(), name = "splitter"},
									                                                      new jAttribute {attributeId = NextId(), name = "two seamer"},
								                                                      }
						},
					new jAttributeRoot
						{
							groupId = NextId(), name = "Ball/Strike", attributes = new[]
								                                                       {
									                                                       new jAttribute {attributeId = NextId(), name = "ball"},
									                                                       new jAttribute {attributeId = NextId(), name = "strike"},
								                                                       }
						},
					new jAttributeRoot
						{
							groupId = NextId(), name = "Pitch Result", attributes = new[]
								                                                        {
									                                                        new jAttribute
										                                                        {
											                                                        attributeId = NextId(), name = "strike out", attributes = new[]
												                                                                                                                  {
													                                                                                                                  new jAttribute {attributeId = NextId(), name = "swinging"},
													                                                                                                                  new jAttribute {attributeId = NextId(), name = "looking"}
												                                                                                                                  }
										                                                        },
									                                                        new jAttribute {attributeId = NextId(), name = "foul"},
									                                                        new jAttribute {attributeId = NextId(), name = "BB"},
									                                                        new jAttribute {attributeId = NextId(), name = "HBP "},
									                                                        new jAttribute
										                                                        {
											                                                        attributeId = NextId(), name = "in play", attributes = new[]
												                                                                                                               {
													                                                                                                               new jAttribute {attributeId = NextId(), name = "ground ball"},
													                                                                                                               new jAttribute {attributeId = NextId(), name = "line drive"},
													                                                                                                               new jAttribute {attributeId = NextId(), name = "fly ball"},
												                                                                                                               }
										                                                        },
								                                                        }
						},
					new jAttributeRoot
						{
							groupId = NextId(), name = "MPH", attributes = new[]
								                                               {
									                                               new jAttribute {attributeId = NextId(), name = "90"},
									                                               new jAttribute {attributeId = NextId(), name = "91"},
									                                               new jAttribute {attributeId = NextId(), name = "92"},
									                                               new jAttribute {attributeId = NextId(), name = "93"},
									                                               new jAttribute {attributeId = NextId(), name = "94"},
									                                               new jAttribute {attributeId = NextId(), name = "95"},
									                                               new jAttribute {attributeId = NextId(), name = "96"},
									                                               new jAttribute {attributeId = NextId(), name = "97"},
									                                               new jAttribute {attributeId = NextId(), name = "98"},
									                                               new jAttribute {attributeId = NextId(), name = "99"},
									                                               new jAttribute {attributeId = NextId(), name = "100"},
								                                               }
						},
				}.ToDictionary(group => group.groupId, group => group);

		private static int NextId()
		{
			return _idSeed++;
		}


		public jAttributeRootContainer GetRoots([ModelBinder] IEnumerable<int> rootIds)
		{
			var roots = rootIds.IsNullOrEmpty()
				            ? FakeRepo.Select(x => x.Value)
				            : rootIds.Select(rootId => FakeRepo.GetOrDefault(rootId)).Where(x => x != null);

			return new jAttributeRootContainer {roots = roots.ToArray()};
		}
	}
}