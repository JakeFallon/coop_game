using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSpawn : MonoBehaviour
{
    
    private GameObject enemyinst;
    [SerializeField] private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("blackspawn", 1f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void blackspawn()
    {
        enemyinst = Instantiate(enemy, new Vector2(Random.Range(10f, 20f), Random.Range(0f, 10f)), Quaternion.identity);
        enemyinst = Instantiate(enemy, new Vector2(Random.Range(-10f, -20f), Random.Range(0f, 10f)), Quaternion.identity);
        enemyinst = Instantiate(enemy, new Vector2(Random.Range(10f, 20f), Random.Range(-10f, -20f)), Quaternion.identity);
        enemyinst = Instantiate(enemy, new Vector2(Random.Range(-10f, -20f), Random.Range(10f, 20f)), Quaternion.identity);
    }
}
