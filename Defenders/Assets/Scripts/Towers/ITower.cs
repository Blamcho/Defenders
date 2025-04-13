namespace Defenders.interfaces
{
    public interface ITower
    {
        void Initialize();
        void Attack();
        void SetAttackStrategy(IAttackStrategy strategy);
    }
}
