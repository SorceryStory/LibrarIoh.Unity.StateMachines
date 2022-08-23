namespace SorceressSpell.LibrarIoh.Unity.StateMachines
{
    public interface IGameState
    {
        #region Methods

        public void FixedUpdate(float fixedDeltaTime);

        public void LateUpdate(float deltaTime);

        public void Update(float deltaTime);

        #endregion Methods
    }
}
