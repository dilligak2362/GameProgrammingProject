using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject bigEnemyPrefab;

    [SerializeField]
    private float enemyInterval = 3.5f;
    [SerializeField]
    private float bigEnemyInterval = 10f;
    [SerializeField]
    private int bigEnemyNum = 1;
    [SerializeField]
    private int enemyNum = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab, enemyNum));
        StartCoroutine(spawnEnemy(bigEnemyInterval, bigEnemyPrefab, bigEnemyNum));
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 spawnPos = GameObject.Find("Player").transform.position;
        //spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        //Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
    }

    void FixedUpdate() {
        
    }

        private IEnumerator spawnEnemy(float interval, GameObject enemy, int amount)
    {
        yield return new WaitForSeconds(interval);
        for(int i = 0; i < amount; i++) {
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        }
        amount = amount + amount - 1;
        interval = (interval / 2) + Math.Sqrt(interval);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
