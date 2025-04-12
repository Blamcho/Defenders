using UnityEngine;

namespace DefaultNamespace
{
    public class LinearMovement :IMovementStrategy
    {
        private float Speed;

        public LinearMovement(float speed)
        {
            this.Speed = speed;
        }

        public void Move(Transform enemyTransform)
        {
            enemyTransform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
    }
}
