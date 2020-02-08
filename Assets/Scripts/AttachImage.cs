using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttachImage : MonoBehaviour
{
    //This script loads textures dynamically onto the playcards.


    public Texture texture;
    public string fotonaam;
    

    void Start()
    {
        texture = Resources.Load("memorykaarten/"+fotonaam) as Texture;
        this.GetComponent<Renderer>().material.mainTexture = texture;

    }

}
