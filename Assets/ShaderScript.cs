using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{
    public GameObject gameEvent;
    private GameObject player;
    SpriteRenderer m_SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        if (Vector3.Distance(player.transform.position, transform.position) <= 1 && Input.GetButtonDown("Jump"))
        {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();
            //Set the GameObject's Color quickly to a set Color (blue)
            m_SpriteRenderer.color = Color.blue;
        }

    }

    void spawnEvent()
    {
        Instantiate(gameEvent);
    }
}
