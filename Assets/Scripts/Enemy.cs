using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damagePoints;
    public DamageBox[] boxes;
    public DamageBox destination;
    public EnemyNavigation nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<EnemyNavigation>();
        int random = Random.Range(0,4);
        destination = boxes[random];
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == destination.transform.position)
        {
            damagePoints += destination.points;
            int random = Random.Range(0,4);
            destination = boxes[random];
        }
    }
}