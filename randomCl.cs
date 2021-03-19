using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomCl : MonoBehaviour
{

    public Material mat;
    void Start()
    {
       // mat.color = Random.ColorHSV();// random hsv color
        mat.color = Color.red;
        mat.color = new Color32(0,3,255,255);// color with rgb parameters

        Color[] colors = new Color[6];
        colors[0] = Color.green ;
        colors[1] = Color.red;
        colors[2] = Random.ColorHSV();
        colors[3] = new Color32(255,0,255,255);
        colors[4] = new Color32();// black 0,0,0,0
        colors[5] = new Color32(255,255,255,255);//white
        // you can add as many colors you want 
        // thanks for watching 

        mat.color = colors[Random.Range(0,colors.Length)]; // random color from list colors from 0 to length


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
