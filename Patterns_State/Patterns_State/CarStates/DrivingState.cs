using System;

namespace Patterns_State.CarStates {

	public class DrivingState : IState {

		private Car _car;

		public DrivingState (Car car) {
			_car = car;
		}

		public void FillTank () {
			Console.WriteLine ("You cant fill tank when driving");
		}

		public void TurnKey () {
			Console.WriteLine ("You cant turn off engine when driving");
		}

		public void Drive () {
			Console.WriteLine ("Try to continue drive");
			TryToContinueDrive ();
		}

		public void Stop () {
			Console.WriteLine ("Car is stoped");
			_car.SetCarState (_car.EngineStarted);
		}

		private void TryToContinueDrive () {
			if (_car.Fuel > 0) {
				Console.WriteLine ("Continue to drive");
			} else {
				Console.WriteLine ("Youre out of fuel");
				_car.SetCarState (_car.EmptyTank);
			}
		}
	}
}
