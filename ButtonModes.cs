using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonModes : GazeableButtons {

    [SerializeField]
    private SpaceShuttleSystemInstance.InputModes mode;

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);

        if (parentPanel.currentSelectedButton != null)
        {
            SpaceShuttleSystemInstance.instance.activeMode = mode;
            
        }
    }
}
