using UnityEngine;
using System.Collections;

public class TeleportPlayer : MonoBehaviour {
    private bool playerInTrigger;
    public Collider2D other;
    public float xTransform;
    public float yTransform;

    void Start()
    {
        playerInTrigger = false;
    }

    void Update()
    {
        if(playerInTrigger && Input.GetButtonDown("Jump"))
        {
            other.transform.position = new Vector2(xTransform, yTransform);
        }
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            playerInTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInTrigger = false;
        }
    }
}
