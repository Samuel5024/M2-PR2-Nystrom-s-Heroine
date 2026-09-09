using UnityEngine;

namespace Chapter.State
{
    public class StandingState : IHeroineState
    {
        private readonly Heroine _heroine;

        public StandingState(Heroine heroine)
        {
            _heroine = heroine;
        }

        public void Enter()
        {
            Debug.Log("Enter Standing");
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _heroine.SetHeroineState(new JumpingState(_heroine));
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _heroine.SetHeroineState(new DuckingState(_heroine));
            }

            else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                _heroine.SetHeroineState(new WalkingState(_heroine));
            }

            else if(Input.GetKeyDown(KeyCode.C))
            {
                _heroine.SetHeroineState(new ChargingState(_heroine));
            }

        }
   
        // Update is called once per frame
        public void Update()
        {
        
        }
    }
}

