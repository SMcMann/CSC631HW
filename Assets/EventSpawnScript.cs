using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSpawnScript : MonoBehaviour
{
    public GameObject gameEvent;
    private GameObject player;
    public GameObject SomeCube;

    // Start is called before the first frame update
    void Start()
    {
        spawnEvent();
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        if (Vector3.Distance(player.transform.position, transform.position) <= 1 && Input.GetButtonDown("Jump"))
        {
            spawnEvent();
        }

    }

    void spawnEvent()
    {
        Instantiate(SomeCube, transform.position, transform.rotation);
    }
}
