using System;

namespace Patterns_State {

	class Program {

		static void Main (string[] args) {

			Car car = new Car ();

			car.Drive ();
			car.FillTank ();
			car.TurnKey ();
			car.Drive ();
			car.Drive ();
			car.Drive ();
			car.Drive ();
			car.Drive ();
			car.Drive ();
			car.FillTank ();
			car.TurnKey ();
			car.Drive ();
			car.Stop ();
			car.TurnKey ();

			Console.ReadLine ();

		}
	}
}
