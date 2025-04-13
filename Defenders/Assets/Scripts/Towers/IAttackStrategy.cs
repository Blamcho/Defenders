using UnityEngine;

namespace Defenders.interfaces
{
    public interface IAttackStrategy
    {
        void ExecuteAttack(Transform origin, GameObject target);
    }
}
