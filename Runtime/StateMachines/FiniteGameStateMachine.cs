using SorceressSpell.LibrarIoh.StateMachines;

namespace SorceressSpell.LibrarIoh.Unity.StateMachines
{
    public class FiniteGameStateMachine<TGameState> : FiniteStateMachine<TGameState>, IGameStateMachine<TGameState>
        where TGameState : GameState<TGameState>
    {
        #region Properties

        protected TGameState ChangeToState { set; get; }

        #endregion Properties

        #region Constructors

        public FiniteGameStateMachine()
            : base()
        {
            ChangeToState = null;
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

        protected virtual void FiniteGameStateMachine_ChangeStateStrategy(TGameState state)
        {
            ChangeToState = state;
        }

        protected virtual void FiniteGameStateMachine_OnChangeStateFailure(TGameState state)
        {
            ChangeToState = null;
        }

        protected virtual void FiniteGameStateMachine_OnChangeStateSuccess(TGameState state)
        {
            ChangeToState = null;
        }

        protected virtual void FiniteGameStateMachine_OnFixedUpdate(float fixedDeltaTime)
        {
            if (Started)
            {
                CurrentState.FixedUpdate(fixedDeltaTime);
                ChangeStatePrimitive(ChangeToState);
            }
        }

        protected virtual void FiniteGameStateMachine_OnLateUpdate(float deltaTime)
        {
            if (Started)
            {
                CurrentState.LateUpdate(deltaTime);
                ChangeStatePrimitive(ChangeToState);
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
                ChangeStatePrimitive(ChangeToState);
            }
        }

        protected override sealed void FiniteStateMachine_ChangeStateStrategy(TGameState state)
        {
            FiniteGameStateMachine_ChangeStateStrategy(state);
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
