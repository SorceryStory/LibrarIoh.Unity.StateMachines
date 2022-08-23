using SorceressSpell.LibrarIoh.StateMachines;

namespace SorceressSpell.LibrarIoh.Unity.StateMachines
{
    public class PushdownAutomataGameStateMachine<TGameState> : PushdownAutomataStateMachine<TGameState>, IGameStateMachine<TGameState>
        where TGameState : GameState<TGameState>
    {
        #region Fields

        protected TGameState ChangeToState;

        #endregion Fields

        #region Constructors

        public PushdownAutomataGameStateMachine()
            : base()
        {
            ChangeToState = null;
        }

        #endregion Constructors

        #region Methods

        public void FixedUpdate(float fixedDeltaTime)
        {
            PushdownAutomataGameStateMachine_OnFixedUpdate(fixedDeltaTime);
        }

        public void LateUpdate(float deltaTime)
        {
            PushdownAutomataGameStateMachine_OnLateUpdate(deltaTime);
        }

        public void Update(float deltaTime)
        {
            PushdownAutomataGameStateMachine_OnUpdate(deltaTime);
        }

        protected virtual void PushdownAutomataGameStateMachine_ChangeStateStrategy(TGameState state)
        {
            ChangeToState = state;
        }

        protected virtual void PushdownAutomataGameStateMachine_OnChangeStateFailure(TGameState state)
        {
            ChangeToState = null;
        }

        protected virtual void PushdownAutomataGameStateMachine_OnChangeStateSuccess(TGameState state)
        {
            ChangeToState = null;
        }

        protected virtual void PushdownAutomataGameStateMachine_OnFixedUpdate(float fixedDeltaTime)
        {
            if (Started)
            {
                CurrentState.FixedUpdate(fixedDeltaTime);
                ChangeStatePrimitive(ChangeToState);
            }
        }

        protected virtual void PushdownAutomataGameStateMachine_OnLateUpdate(float deltaTime)
        {
            if (Started)
            {
                CurrentState.LateUpdate(deltaTime);
                ChangeStatePrimitive(ChangeToState);
            }
        }

        protected virtual void PushdownAutomataGameStateMachine_OnPostUpdate(float deltaTime)
        {
        }

        protected virtual void PushdownAutomataGameStateMachine_OnPreUpdate(float deltaTime)
        {
        }

        protected virtual void PushdownAutomataGameStateMachine_OnStart()
        {
        }

        protected virtual void PushdownAutomataGameStateMachine_OnStatePop(TGameState poppedState)
        {
        }

        protected virtual void PushdownAutomataGameStateMachine_OnStatePush(TGameState pushedState)
        {
        }

        protected virtual void PushdownAutomataGameStateMachine_OnStop()
        {
        }

        protected virtual void PushdownAutomataGameStateMachine_OnUpdate(float deltaTime)
        {
            if (Started)
            {
                CurrentState.Update(deltaTime);
                ChangeStatePrimitive(ChangeToState);
            }
        }

        protected override sealed void PushdownAutomataStateMachine_ChangeStateStrategy(TGameState state)
        {
            PushdownAutomataGameStateMachine_ChangeStateStrategy(state);
        }

        protected override sealed void PushdownAutomataStateMachine_OnChangeStateFailure(TGameState state)
        {
            PushdownAutomataGameStateMachine_OnChangeStateFailure(state);
        }

        protected override sealed void PushdownAutomataStateMachine_OnChangeStateSuccess(TGameState state)
        {
            PushdownAutomataGameStateMachine_OnChangeStateSuccess(state);
        }

        protected override sealed void PushdownAutomataStateMachine_OnStart()
        {
            PushdownAutomataGameStateMachine_OnStart();
        }


        protected override sealed void PushdownAutomataStateMachine_OnStatePop(TGameState poppedState)
        {
            PushdownAutomataGameStateMachine_OnStatePop(poppedState);
        }

        protected override sealed void PushdownAutomataStateMachine_OnStatePush(TGameState pushedState)
        {
            PushdownAutomataGameStateMachine_OnStatePush(pushedState);
        }

        protected override sealed void PushdownAutomataStateMachine_OnStop()
        {
            PushdownAutomataGameStateMachine_OnStop();
        }

        #endregion Methods
    }
}
