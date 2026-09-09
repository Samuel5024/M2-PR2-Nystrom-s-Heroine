using UnityEngine;

namespace Chapter.State
{
    public class JumpingState : IHeroineState
    {
        private readonly Heroine _heroine;

        public JumpingState(Heroine heroine)
        {
            _heroine = heroine;
        }

        public void Enter()
        {
            Debug.Log("Enter Jumping");
        }

        public void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                _heroine.SetHeroineState(new DivingState(_heroine));
            }
        }

        public void Update()
        {

        }
    }

}

