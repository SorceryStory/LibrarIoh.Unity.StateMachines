using SorceressSpell.LibrarIoh.StateMachines;

namespace SorceressSpell.LibrarIoh.Unity.StateMachines
{
    public class FiniteGameStateMachine<TGameState> : FiniteStateMachine<TGameState>, IGameStateMachine<TGameState>
        where TGameState : GameState<TGameState>
    {
        #region Constructors

        public FiniteGameStateMachine()
            : base()
        {
        }

        #endregion Constructors

        #region Methods

        public void FixedUpdate(float fixedDeltaTime)
        {
            FiniteGameStateMachine_OnFixedUpdate(fixedDeltaTime);
        }

        public void LateUpdate(float deltaTime)
        {
            FiniteGameStateMachine_OnLateUpdate(deltaTime);
        }

        public void Update(float deltaTime)
        {
            FiniteGameStateMachine_OnUpdate(deltaTime);
        }

        protected virtual void FiniteGameStateMachine_OnChangeStateFailure(TGameState state)
        {
        }

        protected virtual void FiniteGameStateMachine_OnChangeStateSuccess(TGameState state)
        {
        }

        protected virtual void FiniteGameStateMachine_OnFixedUpdate(float fixedDeltaTime)
        {
            if (Started)
            {
                CurrentState.FixedUpdate(fixedDeltaTime);
            }
        }

        protected virtual void FiniteGameStateMachine_OnLateUpdate(float deltaTime)
        {
            if (Started)
            {
                CurrentState.LateUpdate(deltaTime);
            }
        }

        protected virtual void FiniteGameStateMachine_OnStart()
        {
        }

        protected virtual void FiniteGameStateMachine_OnStop()
        {
        }

        protected virtual void FiniteGameStateMachine_OnUpdate(float deltaTime)
        {
            if (Started)
            {
                CurrentState.Update(deltaTime);
            }
        }

        protected override sealed void FiniteStateMachine_OnChangeStateFailure(TGameState state)
        {
            FiniteGameStateMachine_OnChangeStateFailure(state);
        }

        protected override sealed void FiniteStateMachine_OnChangeStateSuccess(TGameState state)
        {
            FiniteGameStateMachine_OnChangeStateSuccess(state);
        }

        protected override sealed void FiniteStateMachine_OnStart()
        {
            FiniteGameStateMachine_OnStart();
        }

        protected override sealed void FiniteStateMachine_OnStop()
        {
            FiniteGameStateMachine_OnStop();
        }

        #endregion Methods
    }
}
