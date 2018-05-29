using System;
using Patterns_State.CarStates;

namespace Patterns_State {

	public class Car {

		public int Fuel { get; private set; }

		public EmptyTankState EmptyTank;
		public TankWithFuelState TankWithFuel;
		public EngineStartedState EngineStarted;
		public DrivingState Driving;

		private IState _currentState;

		public Car () {
			Fuel = 0;

			EmptyTank = new EmptyTankState (this);
			TankWithFuel = new TankWithFuelState (this);
			EngineStarted = new EngineStartedState (this);
			Driving = new DrivingState (this);

			_currentState = EmptyTank;
		}

		public void SetCarState (IState state) {
			_currentState = state;
		}

		public void FillTank () {
			if (_currentState == EmptyTank || _currentState == TankWithFuel)
				Fuel = 50;

			_currentState.FillTank ();
		}

		public void TurnKey () {
			_currentState.TurnKey ();
		}

		public void Drive () {
			if (_currentState == Driving)
				Fuel -= 10;

			_currentState.Drive ();
		}

		public void Stop () {
			_currentState.Stop ();
		}

	}
}
