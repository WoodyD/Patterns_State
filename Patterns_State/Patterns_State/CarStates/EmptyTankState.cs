using System;

namespace Patterns_State.CarStates {

	public class EmptyTankState : IState {

		private Car _car;

		public EmptyTankState (Car car) {
			_car = car;
		}

		public void FillTank () {
			Console.WriteLine ("Tank successfully filled");
			_car.SetCarState (_car.TankWithFuel);
		}

		public void TurnKey () {
			Console.WriteLine ("You must fill tank to drive");
		}

		public void Drive () {
			Console.WriteLine ("You must fill tank and start engine to drive");
		}

		public void Stop () {
			Console.WriteLine ("You dont drive now");
		}

	}
}
