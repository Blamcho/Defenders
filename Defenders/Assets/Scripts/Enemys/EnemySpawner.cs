using DefaultNamespace;
using UnityEngine;

    public class EnemySpawner : MonoBehaviour
    {
        public GameObject enemyPrefa;

        void Start()
        {
            InvokeRepeating(nameof(SpawnEnemy), 1f, 3f);
        }

        public void SpawnEnemy()
        {
            GameObject enemyGameObject = Instantiate(enemyPrefa, transform.position, Quaternion.identity);
            Enemy enemy = enemyGameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.Initialize(100, 10, new LinearMovement(2f));
            }

        }
    }

