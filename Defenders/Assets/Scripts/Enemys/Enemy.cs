using UnityEngine;

namespace DefaultNamespace
{
    public abstract class Enemy : MonoBehaviour, IDamageable
    {
        protected int health;
        protected int damage;
        protected EnemyMovement movement;

        public virtual void Initialize(int health, int damage, IMovementStrategy movementStrategy)
        {
            this.health = health;
            this.damage = damage;
            this.movement = new EnemyMovement(movementStrategy);
        }

        public void Move()
        {
            movement.Move(transform);
        }

        public void TakeDamage(int amount)
        {
            health -= amount;
            if (health <= 0)
            {
                Die();
            }
        }

        protected virtual void Die()
        {
            Debug.Log($"{gameObject.name} ha muerto.");
            Destroy(gameObject);
        }

        protected virtual void Update()
        {
            Move();
        }
    }
}