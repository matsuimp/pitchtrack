using System;

namespace Models.Definitions
{
	[Flags]
	public enum Position
	{
		Pitcher = 1,
		Catcher = 2,
		FirstBase = 4,
		SecondBase = 8,
		ThirdBase = 16,
		ShortStop = 32,
		RightField = 64,
		CenterField = 128,
		LeftField = 256,
		Outfield = 512,
		LeftCenterField = 1024,
		RightCenterField = 2048,
		ShortCenterField = 4096,
		DesignatedHitter = 8192,
		ExtraHitter = 16384,
	}
}