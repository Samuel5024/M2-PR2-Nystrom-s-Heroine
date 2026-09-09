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

        }
        public void Update()
        {

        }
    }
}


