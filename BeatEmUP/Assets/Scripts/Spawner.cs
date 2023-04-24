using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    [SerializeField]
    private Transform playerTransform;

    public float minSpawnDistance = 10;
    public float maxSpawnDistance = 100;

    [SerializeField]
    public int wave = 0;

    [SerializeField]
    private int numBigGuys = 1;
    [SerializeField]
    private int numGuys = 10;

    [SerializeField]
    public static List<GameObject> enemies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab, enemyNum));
        //StartCoroutine(spawnEnemy(bigEnemyInterval, bigEnemyPrefab, bigEnemyNum));
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 spawnPos = GameObject.Find("Player").transform.position;
        //spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        //Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);

        if (enemies.Count < 5)
            spawnWave();

    }


    public GameObject spawnOneEnemy(GameObject prefab)
    {
        GameObject enemyClone = Instantiate(prefab);

        enemyClone.transform.RotateAround(playerTransform.position, new Vector3(0, 1, 0), Random.Range(0, 360));
        float spawnDistance = Random.Range(minSpawnDistance, maxSpawnDistance);
        Vector3 newPos = enemyClone.transform.forward * spawnDistance;
        newPos.y = 3;
        enemyClone.transform.position = newPos;

        return enemyClone;
    }

    public void spawnWave()
    {
        wave++;

        for (int i=0; i <= numGuys; i++)
        {
            GameObject newEnemy = spawnOneEnemy(enemyPrefab);
            enemies.Add(newEnemy);
        }

        if (wave % 5 == 0)
        {
            for (int i = 0; i <= numBigGuys; i++)
            {
                Debug.Log("SPAWNIGN BEEGH AGYAGY");
                GameObject newEnemy = spawnOneEnemy(bigEnemyPrefab);
                enemies.Add(newEnemy);
            }
            numBigGuys++;
        }

        numGuys += 5;

    }


    private IEnumerator spawnEnemy(float interval, GameObject enemy, int amount)
    {
        yield return new WaitForSeconds(interval);
        for(int i = 0; i < amount; i++) 
        {
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        }
        amount = amount + amount - 1;
        interval = (interval / 2) + Mathf.Sqrt(interval);
        StartCoroutine(spawnEnemy(interval, enemy, amount));
    }
}
