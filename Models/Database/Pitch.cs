using System.Collections.Generic;

namespace Models.Database
{
	public class Pitch
	{
		public int PitchId { get; set; }
		public int PlayerId { get; set; }
		public int GameId { get; set; }
		public IList<PitchAttribute> PitchAttributes { get; set; }
	}
}