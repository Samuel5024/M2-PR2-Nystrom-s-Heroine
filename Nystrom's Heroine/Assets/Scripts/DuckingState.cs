using UnityEngine;

namespace Chapter.State
{
    public class DuckingState : IHeroineState
    {
        private readonly Heroine _heroine;

        public DuckingState(Heroine heroine)
        {
            _heroine = heroine;
        }

        public void Enter()
        {
            Debug.Log("Enter Ducking");
        }

        public void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                _heroine.SetHeroineState(new StandingState(_heroine));
            }
        }

        public void Update()
        {

        }
    }

}
