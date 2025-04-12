using UnityEngine;

namespace DefaultNamespace
{
    public class EnemyMovement
    {
        private IMovementStrategy movementStrategy;

        public EnemyMovement(IMovementStrategy strategy)
        {
            this.movementStrategy = strategy;
        }

        public void Move(Transform enemyTransform)
        {
            movementStrategy.Move(enemyTransform);
        }
    }
}