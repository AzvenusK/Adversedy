using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCanvas : MonoBehaviour {

    public GazeableButtons currentSelectedButton;

    public Color selectedColor = Color.green;
    public Color unselectedColor = Color.white;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetActiveButton(GazeableButtons activeButton)
    {
        //If there was a previously active Button, disable it.
        if (currentSelectedButton != null)
        {
            currentSelectedButton.SetButtonColor(unselectedColor);
        }

        if (activeButton != null && currentSelectedButton != activeButton)
        {
            currentSelectedButton = activeButton;
            currentSelectedButton.SetButtonColor(selectedColor);
        }

        else
        {
            Debug.Log("Resetting");
            currentSelectedButton = null;
            SpaceShuttleSystemInstance.instance.activeMode = SpaceShuttleSystemInstance.InputModes.NONE;
        }
    }
}
