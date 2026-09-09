using UnityEngine;

public interface IHeroineState
{
    void Enter();
    void HandleInput();
    void Update();
}
public class Heroine : MonoBehaviour
{
    private IHeroineState _state;
    private void Awake()
    {
        _state = new StandingState(this);
        _state.Enter();
    }

    public void SetHeroineState(IHeroineState newState)
    {
        _state = newState;
        _state.Enter();
    }

    private void Update()
    {
        _state.HandleInput();
        _state.Update();
    }
}
