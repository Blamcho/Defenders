using UnityEngine;

namespace DefaultNamespace
{
    public class StrongEnemy : Enemy
    {
        public override void Initialize(int health, int damage, IMovementStrategy movementStrategy)
        {
            base.Initialize(health, damage, movementStrategy);
            Debug.Log("StrongEnemy creado");
        }

        protected override void Die()
        {
            Debug.Log("¡StrongEnemy Exploto");
            base.Die();
        }
    }
}
