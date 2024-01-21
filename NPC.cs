using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
     //healt NPC
    public int healt = 3;

     //level NPC
    public int level = 1;

     //speed NPC
    public float speed = 2.1f;



    // Start is called before the first frame update
    void Start()
    {
         // значения по заданию
        healt += level;

        print("lives: "+healt);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
