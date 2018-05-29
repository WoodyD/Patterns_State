
namespace Patterns_State.CarStates {

	public interface IState {

		void FillTank ();
		void TurnKey ();
		void Drive ();
		void Stop ();
	}
}
