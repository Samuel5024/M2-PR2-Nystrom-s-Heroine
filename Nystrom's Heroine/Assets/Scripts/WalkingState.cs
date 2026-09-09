using UnityEngine;

namespace Chapter.State
{
    public class WalkingState : IHeroineState
    {
        private readonly Heroine _heroine;

        public WalkingState(Heroine heroine)
        {
            _heroine = heroine;
        }
        public void Enter()
        {
            Debug.Log("Enter Walking");
        }

        public void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                _heroine.SetHeroineState(new JumpingState(_heroine));
            }

            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                _heroine.SetHeroineState(new DuckingState(_heroine));
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                _heroine.SetHeroineState(new StandingState(_heroine));
            }
        }

        public void Update()
        {

        }
    }
}