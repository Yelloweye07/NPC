using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье НПС

    public int health = 5;

    //Уровень НПС

   public int level = 1;

    //Скорость НПС

   public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("Жизни:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z = newPosition.z + speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
