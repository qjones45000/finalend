using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("GROUND"))
        {
            Destroy(other.gameObject);
           
        }
    }
}
