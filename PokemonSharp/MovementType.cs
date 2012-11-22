using System;
namespace PokemonSharp
{
	public enum MovementType : byte
	{
		NoMovement,
		LookAround,
		LookUp,
		LookDown,
		LookLeft,
		LookRight,
		LookClockwise,
		LookCounterClockwise,
		WalkAround,
		WalkUpAndDown,
		WalkLeftAndRight
	}
}
