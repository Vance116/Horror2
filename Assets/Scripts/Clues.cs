using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clues : MonoBehaviour
{
    FirstPersonController firstPersonController;
    public int clues;
    public AudioClip jumpScare;
    // Start is called before the first frame update
    void Start()
    {
        clues = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        firstPersonController = GetComponent<FirstPersonController>();

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("You have found " + clues + " clue!");
            

        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Clue")
        {
            clues++;
            AudioSource.PlayClipAtPoint(jumpScare, transform.position);
            other.gameObject.SetActive(false);
            if (clues == 4)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
