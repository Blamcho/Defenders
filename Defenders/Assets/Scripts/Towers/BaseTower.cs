using UnityEngine;
using Defenders.interfaces;

namespace Defenders.interfaces
{
    public abstract class BaseTower :MonoBehaviour, ITower,IEvolution
    {
        protected IAttackStrategy attackStrategy;
        protected GameObject currentTarget;

        public virtual void Initialize() { }

        public virtual void Attack()
        {
            if (currentTarget != null)
                attackStrategy.ExecuteAttack(transform, currentTarget);
        }

        public void SetAttackStrategy(IAttackStrategy strategy)
        {
            attackStrategy = strategy;
        }

        public abstract ITower Evolve();
    }
}
