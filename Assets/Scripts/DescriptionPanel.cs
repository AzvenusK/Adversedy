using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionPanel : GazeableObjects {
    public Material material0;
    public Material material1;
    public Material material2;
    public Material material3;
    public Material material4;
    public Material material5;
    public Material material6;
    public Material material7;
    public Material material8;
    public Material material9;
    public Material originalMaterial;

    public override void OnGaze(RaycastHit hitInfo)
    {
        base.OnHold(hitInfo);

        if (gameObject.name == "Mercury")
        {
            GetComponent<Renderer>().material = material1;
        }

        else if (gameObject.name == "Venus")
        {
            GetComponent<Renderer>().material = material2;
        }

        else if (gameObject.name == "Earth")
        {
            GetComponent<Renderer>().material = material3;
        }

        else if (gameObject.name == "Mars")
        {
            GetComponent<Renderer>().material = material4;
        }

        else if (gameObject.name == "Jupiter")
        {
            GetComponent<Renderer>().material = material5;
        }

        else if (gameObject.name == "Saturn")
        {
            GetComponent<Renderer>().material = material6;
        }

        else if (gameObject.name == "Uranus")
        {
            GetComponent<Renderer>().material = material7;
        }

        else if (gameObject.name == "Neptune")
        {
            GetComponent<Renderer>().material = material8;
        }

        else if (gameObject.name == "Pluto")
        {
            GetComponent<Renderer>().material = material9;
        }

        else if (gameObject.name == "Sun")
        {
            GetComponent<Renderer>().material = material0;
        }
        else
        {
            GetComponent<Renderer>().material = originalMaterial;
        }
    }

}
