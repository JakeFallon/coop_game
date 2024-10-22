using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlackMove : MonoBehaviour
{

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Player2");
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 3f * Time.deltaTime);

    }
}
