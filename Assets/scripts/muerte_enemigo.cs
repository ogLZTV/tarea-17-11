using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte_enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ammo")
        {
            Instantiate(explosion, transform.position,transform.rotation);
        }
    }
}
