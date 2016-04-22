using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeLevel : MonoBehaviour
{
    public string levelToLoad;
    private bool playerInTrigger;

    // Use this for initialization
    void Start()
    {
        playerInTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTrigger && Input.GetAxis("Vertical") > 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }

    void OnTriggerEnter2D(Collider2D sprite)
    {
        if (sprite.tag == "Player")
        {
            playerInTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D sprite)
    {
        if (sprite.tag == "Player")
        {
            playerInTrigger = false;
        }
    }
}
