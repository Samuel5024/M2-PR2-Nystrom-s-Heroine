using UnityEngine;

namespace Chapter.State
{
    public class ChargingState : IHeroineState
    {
        private readonly Heroine _heroine;

        public ChargingState(Heroine heroine)
        {
            _heroine = heroine;
        }

        public void Enter()
        {
            Debug.Log("Enter Charging");
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _heroine.SetHeroineState(new StandingState(_heroine));
            }
        }

        public void Update()
        {

        }
    }

}
