using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<BombController>())
        {
            Destroy(collision.gameObject);
        }
    }
}
