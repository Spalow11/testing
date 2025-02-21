using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   
    public int health;
    public int level;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
    health += level;    //здоровье зависит от уровн€ игрока
    print("«доровье игрока: "+ health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
