namespace SorceressSpell.LibrarIoh.Unity.StateMachines
{
    public interface IGameStateMachine<TGameState> : IGameState
        where TGameState : GameState<TGameState>
    {
    }
}
