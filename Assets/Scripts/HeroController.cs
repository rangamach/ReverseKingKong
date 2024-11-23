using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private int fakeinp;
    //private bool movetoright;
    [SerializeField] float speed;


    private void Awake()
    {
        //movetoright = true;
        fakeinp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HerorHorizontalMovement()
    {
        Vector3 position = transform.position;
        position.x += fakeinp * speed * Time.deltaTime;
        transform.position = position;
    }
}
