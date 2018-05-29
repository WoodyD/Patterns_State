using System;

namespace Patterns_State.CarStates {

	public class TankWithFuelState : IState {

		private Car _car;

		public TankWithFuelState (Car car) {
			_car = car;
		}

		public void FillTank () {
			Console.WriteLine ("Try to fill more fuel");
		}

		public void TurnKey () {
			Console.WriteLine ("Try to turn on engine");
			TryStartEngine ();
		}


		public void Drive () {
			Console.WriteLine ("You need to turn on engine to drive");
		}

		public void Stop () {
			Console.WriteLine ("You dont drive now");
		}

		private void TryStartEngine () {
			if (_car.Fuel > 0) {
				_car.SetCarState (_car.EngineStarted);
				Console.WriteLine ("Engine is turn on");
			} else {
				Console.WriteLine ("You must fill tank to drive");
			}
		}
	}
}
