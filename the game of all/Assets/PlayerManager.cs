using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject leftbullet;

    Transform firepos;

    // Use this for initialization
    void Start()
    {
        firepos = transform.FindChild("firepos");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

     }

    void Fire()
    {
        Instantiate(leftbullet, firepos.position, Quaternion.identity);
    }

}
