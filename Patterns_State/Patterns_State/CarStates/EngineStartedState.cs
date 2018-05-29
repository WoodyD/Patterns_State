using System;

namespace Patterns_State.CarStates {

	public class EngineStartedState : IState {

		private Car _car;

		public EngineStartedState (Car car) {
			_car = car;
		}

		public void FillTank () {
			Console.WriteLine ("You cant fill tank when engine is on");
		}

		public void TurnKey () {
			Console.WriteLine ("Turn off engine");
		}

		public void Drive () {
			Console.WriteLine ("Try to driving");
			_car.SetCarState (_car.Driving);
		}

		public void Stop () {
			Console.WriteLine ("You dont drive now");
		}

		private void TryToDrive () {
			if (_car.Fuel > 0) {
				Console.WriteLine ("Start driving");
				_car.SetCarState (_car.Driving);
			} else {
				Console.WriteLine ("Youre out of fuel");
				_car.SetCarState (_car.EmptyTank);
			}
		}

	}
}
