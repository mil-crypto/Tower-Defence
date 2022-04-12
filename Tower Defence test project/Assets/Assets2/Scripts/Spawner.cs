using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public Enemy EnemyPrefab;
    public float TimeToSpawn;
    public Transform[] Points;
    public float MainHP, IncreaseHP;

    private float timer;

    void Start()
    {
        timer = TimeToSpawn;
    }
    
    void Update()
    {
        timer -= Time.deltaTime;
        InstantiateEnemy();
        
        if (timer < -1)
            timer = TimeToSpawn;
    }

    void InstantiateEnemy()
    {
        if (timer <= 0)
        {
            Enemy enemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            enemy.Points = Points;
            enemy.SetHP(MainHP);

            MainHP += IncreaseHP;
            timer = TimeToSpawn;
        }
    }
}
