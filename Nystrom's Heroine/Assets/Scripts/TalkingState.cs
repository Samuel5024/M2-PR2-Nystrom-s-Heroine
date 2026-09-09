using UnityEngine;

namespace Chapter.State
{
    public class TalkingState : IHeroineState
    {
        private readonly Heroine _heroine;

        public TalkingState(Heroine heroine)
        {
            _heroine = heroine;
        }

        public void Enter()
        {
            Debug.Log("Enter Talking");
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _heroine.SetHeroineState(new StandingState(_heroine));
            }
        }

        public void Update()
        {

        }
    }

}
