using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderChange : MonoBehaviour
{

    public Renderer cubeRenderer;
    public GameObject cube;
    [SerializeField] private Color newColor;//single
    [SerializeField] private Color[] colors;//multi
    private int colorVal;//for multi

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeMat()
    {

        newColor = Random.ColorHSV();//makes new Color Random

        cubeRenderer.material.color = newColor;
    }

}
