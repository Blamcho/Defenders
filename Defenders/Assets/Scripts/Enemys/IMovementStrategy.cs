using UnityEngine;

namespace DefaultNamespace
{
    public interface IMovementStrategy
    {
        void Move(Transform enemyTransform);
    }
}