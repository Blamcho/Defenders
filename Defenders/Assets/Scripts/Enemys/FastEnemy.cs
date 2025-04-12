using UnityEngine;

namespace DefaultNamespace
{
    public class FastEnemy : Enemy
    {
        public override void Initialize(int health, int damage, IMovementStrategy movementStrategy)
        {
            base.Initialize(health, damage, movementStrategy);
            Debug.Log("FastEnemy creado");
        }
    }
}