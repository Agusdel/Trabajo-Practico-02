using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Animator anim;
    public bool haduken;

	void Start () {
        anim = gameObject.GetComponent<Animator>();

	}
	
	void Update ()
    {
        anim.SetBool("Haduken", haduken);
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            haduken = true;
            Debug.Log("HAAADUUUKEEEEN!!!");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0))
        {
            haduken = false;
            Debug.Log("Idle.");
        }

    }
}
