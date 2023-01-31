using SorceressSpell.LibrarIoh.StateMachines;

namespace SorceressSpell.LibrarIoh.Unity.StateMachines
{
    public interface IGameStateMachine<TGameState> : IStateMachine<TGameState>, IGameState
        where TGameState : GameState<TGameState>
    {
    }
}
