using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision  collision) {
      Debug.Log("collision: " + collision.gameObject.tag);
      if(collision.gameObject.tag == "Player") {
        Destroy(gameObject);
      }
    }
}
