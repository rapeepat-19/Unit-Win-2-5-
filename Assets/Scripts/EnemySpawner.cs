using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;       // พรีแฟบของมอนสเตอร์
    public float spawnInterval = 15f;     // เวลาเกิดมอนสเตอร์ใหม่ทุกกี่วินาที
    public Transform[] spawnPoints;      // ตำแหน่งสุ่มเกิด

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (spawnPoints.Length == 0 || enemyPrefab == null) return;

        // สุ่มตำแหน่ง spawn
        int index = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[index];

        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}
