using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 10;
    public string[] animals;

    private float moveX;

    // Start is called before the first frame update
    
    void Start()
    {
        speed = 10;
        int whichAnimal = Random.Range(0, animals.Length);
        Debug.Log(animals[whichAnimal]);
    }
    

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.right * moveX * speed * Time.deltaTime);
    }

    // function to move enemies
    // function to shoot projectiles

}
