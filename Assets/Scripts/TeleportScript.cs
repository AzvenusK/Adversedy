using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : GazeableObjects {



    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);

        

        if (SpaceShuttleSystemInstance.instance.activeMode == SpaceShuttleSystemInstance.InputModes.TELEPORT)
        {
            Vector3 hitPoint = hitInfo.point;
            Vector3 bufferSubtract = new Vector3(100,100,100);
            Vector3 teleportLocation = hitPoint - bufferSubtract;

            SpaceShuttleSystemInstance.instance.transform.position = teleportLocation;

        }
    }

}
