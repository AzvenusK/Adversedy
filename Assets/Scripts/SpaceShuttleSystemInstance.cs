using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShuttleSystemInstance : MonoBehaviour {

    public static SpaceShuttleSystemInstance instance;

    [SerializeField]
    private float speed = 1000.0f;

    public enum InputModes
    {
        NONE,
        MOVE,
        TELEPORT
    }

    public InputModes activeMode = InputModes.NONE;

    private void Awake()
    {
        if (instance != null)
        {
            GameObject.Destroy(instance.gameObject);
        }

        instance = this;

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    public void Move()
    {
       if(Input.GetMouseButton(0) && activeMode == InputModes.MOVE)
        {
            Vector3 forward = Camera.main.transform.forward;

            Vector3 newPosition = transform.position + forward * Time.deltaTime * speed;

            transform.position = newPosition;

        }
    }
        
}
