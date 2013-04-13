namespace Models.Database
{
	public class Pitch
	{
		public int PitchId { get; set; }
		public int PlayerId { get; set; }
		public int GameId { get; set; }
		public int PitchTypeId { get; set; }
		public bool? Strike { get; set; }
		public int? XLocation { get; set; }
		public int? YLocation { get; set; }
		public double? Speed { get; set; }
		public int? PitchNumber { get; set; }
	}
}