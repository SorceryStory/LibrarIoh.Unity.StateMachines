using SorceressSpell.LibrarIoh.StateMachines;

namespace SorceressSpell.LibrarIoh.Unity.StateMachines
{
    public abstract class GameState<TGameState> : State<TGameState>, IGameState
        where TGameState : class
    {
        #region Constructors

        protected GameState()
        { }

        #endregion Constructors

        #region Methods

        public void FixedUpdate(float fixedDeltaTime)
        {
            GameState_OnFixedUpdate(fixedDeltaTime);
        }

        public void LateUpdate(float deltaTime)
        {
            GameState_OnLateUpdate(deltaTime);
        }

        public void Update(float deltaTime)
        {
            GameState_OnUpdate(deltaTime);
        }

        protected virtual void GameState_OnEnter(TGameState previousState)
        {
        }

        protected virtual void GameState_OnExit()
        {
        }

        protected virtual void GameState_OnFixedUpdate(float fixedDeltaTime)
        {
        }

        protected virtual void GameState_OnLateUpdate(float deltaTime)
        {
        }

        protected virtual void GameState_OnPause()
        {
        }

        protected virtual void GameState_OnResume(TGameState previousState)
        {
        }

        protected virtual void GameState_OnUpdate(float deltaTime)
        {
        }

        protected virtual void GameState_RegisterInputs()
        {
        }

        protected virtual void GameState_UnregisterInputs()
        {
        }

        protected override sealed void State_OnEnter(TGameState previousState)
        {
            GameState_OnEnter(previousState);
            GameState_RegisterInputs();
        }

        protected override sealed void State_OnExit()
        {
            GameState_UnregisterInputs();
            GameState_OnExit();
        }

        protected override sealed void State_OnPause()
        {
            GameState_UnregisterInputs();
            GameState_OnPause();
        }

        protected override sealed void State_OnResume(TGameState previousState)
        {
            GameState_OnResume(previousState);
            GameState_RegisterInputs();
        }

        #endregion Methods
    }
}
