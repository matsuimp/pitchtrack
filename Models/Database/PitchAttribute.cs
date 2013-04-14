using System.Collections.Generic;

namespace Models.Database
{
	public class PitchAttribute
	{
		public int PitchAttributeId { get; set; }
		public string Name { get; set; }
		public IList<PitchAttribute> SubAttributes { get; set; }
	}
}