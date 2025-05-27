using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int scorePoints;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.name=="player")
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
