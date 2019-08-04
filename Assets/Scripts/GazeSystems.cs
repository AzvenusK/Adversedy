using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeSystems : MonoBehaviour
{

    public GameObject reticle;
    public Color inactiveColor = Color.gray;
    public Color activeColor = Color.blue;
    private GazeableObjects currentGazeableObject;
    private GazeableObjects currentSelectedObject;
    private RaycastHit lastHit;

    private void Start()
    {
        SetReticleColor(inactiveColor);
    }
    private void Update()
    {
        ProcessGaze();
        CheckForInput(lastHit);
    }

    public void ProcessGaze()
    {
        Ray raycastRay = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        if (SpaceShuttleSystemInstance.instance.activeMode == SpaceShuttleSystemInstance.InputModes.TELEPORT)
        {
            Debug.DrawRay(raycastRay.origin, raycastRay.direction * 100000);
        }

        else
        {
            Debug.DrawRay(raycastRay.origin, raycastRay.direction * 100);
        }

        if (Physics.Raycast(raycastRay, out hitInfo))
        {
            //Do Something to the object.

            //check if the object is interactable
            //1. get the gameobject from the hitinfo
            GameObject hitObject = hitInfo.collider.gameObject;

            //2. check if the object is the gazeable object
            GazeableObjects gazeObject = hitObject.GetComponent<GazeableObjects>();

            //3. if object has a gazeable component
            if (hitObject != null)
            {
                //object we are looking at is different(new)
                if (gazeObject != currentGazeableObject)
                {
                    ClearCurrentGazeObject();
                    currentGazeableObject = gazeObject;
                    currentGazeableObject.OnGazeEnter(hitInfo);
                    SetReticleColor(activeColor);

                }
                else
                {
                    currentGazeableObject.OnGazeEnter(hitInfo);
                }
            }
            else
            {
                ClearCurrentGazeObject();
            }
            lastHit = hitInfo; //

            //check if the item is new(it is the first time you are lookin at the object)
        }
        else
        {
            ClearCurrentGazeObject();
        }
    }

    public void SetReticleColor(Color reticleColor)
    {

        //set the color of the reticle
        reticle.GetComponent<Renderer>().material.SetColor("_Color", reticleColor);


    }

    public void CheckForInput(RaycastHit hitInfo)
    {
        //check for down
        if(Input.GetMouseButtonDown(0) && currentGazeableObject != null)
        {
            currentSelectedObject = currentGazeableObject;
            currentSelectedObject.OnPress(hitInfo);
        }

        //check for hold
        else if(Input.GetMouseButton(0) && currentSelectedObject != null)
        {
            currentSelectedObject.OnHold(hitInfo);
        }

        //check for release
        else if(Input.GetMouseButtonUp(0) && currentSelectedObject != null)
        {
            currentSelectedObject.OnRelease(hitInfo);
            currentSelectedObject = null;
        }
    }

    public void ClearCurrentGazeObject()
    {
        if (currentGazeableObject != null)
        {
            currentGazeableObject.OnGazeExit();
            SetReticleColor(inactiveColor);
            currentGazeableObject = null;
        }
    }

}
