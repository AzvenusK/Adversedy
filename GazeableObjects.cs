using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeableObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //the virtual function is so that the any kind of child object maybe
    //able to make changes to the function too.
    public virtual void OnGazeEnter(RaycastHit hitInfo)  
    {
        Debug.Log("Gaze Entered on" + gameObject.name);
    }

    public virtual void OnGaze(RaycastHit hitInfo)
    {
        Debug.Log("Gaze held on" + gameObject.name);
    }

    public virtual void OnGazeExit()
    {
        Debug.Log("Gaze exited from" + gameObject.name);
    }

    public virtual void OnPress(RaycastHit hitInfo)
    {
        Debug.Log("Button pressed on" + gameObject.name);
    }

    public virtual void OnHold(RaycastHit hitInfo)
    {
        Debug.Log("Button held on" + gameObject.name);
    }

    public virtual void OnRelease(RaycastHit hitInfo)
    {
        Debug.Log("Button released on" + gameObject.name);
    }

    public void SetText(string str)
    {
         
    }
}

