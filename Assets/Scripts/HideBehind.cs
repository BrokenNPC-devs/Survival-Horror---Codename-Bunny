using UnityEngine;
using System.Collections;

public class HideBehind : MonoBehaviour {
    private bool playerInTrigger;
    public static bool playerIsHiding;
	
        // Use this for initialization
	void Start () {
        playerInTrigger = false;
        playerIsHiding = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (playerInTrigger && Input.GetKey(KeyCode.E))
            playerIsHiding = true;
        else
            playerIsHiding = false;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            playerInTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            playerInTrigger = false;
    }
}
