using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    void OnTriggerEnter()
    {
        if (gameObject.CompareTag("level1"))
        {
            SceneManager.LoadScene(2);
        }

        if (gameObject.CompareTag("level2"))
        {
            SceneManager.LoadScene(3);
        }
        if (gameObject.CompareTag("level3"))
        {
            SceneManager.LoadScene(4);
        }

        if (gameObject.CompareTag("mainmenu"))
        {
            SceneManager.LoadScene(0);
        }


    }
}
