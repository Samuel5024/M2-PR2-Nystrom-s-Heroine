using UnityEngine;

namespace Chapter.State
{
    public class DivingState : IHeroineState
    {
        private readonly Heroine _heroine;
        
        public DivingState(Heroine heroine)
        {
            _heroine = heroine;
        }

        public void Enter()
        {
            Debug.Log("Enter Diving");
        }

        public void HandleInput()
        {
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


