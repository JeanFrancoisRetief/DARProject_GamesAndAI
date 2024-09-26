using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        /*
        if (Input.GetKeyDown(KeyCode.G))
        {
            OnDemoGameClick();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            OnDemoMapClick();
        }

        */

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void OnDemoGameClick()
    {
        SceneManager.LoadScene("DemoSceneGameplay");
    }

    public void OnDemoMapClick()
    {
        SceneManager.LoadScene("DemoSceneMap");
    }

    public void OnLevel4by4Click()
    {
        SceneManager.LoadScene("Level4by4");
    }

    public void OnLevel6by6Click()
    {
        SceneManager.LoadScene("Level6by6");
    }
    public void OnLevel10by10Click()
    {
        SceneManager.LoadScene("Level6by6");
    }

    /*
    public void OnMap4by4Click()
    {
        SceneManager.LoadScene("Map4by4");
    }

    public void OnMap6by6Click()
    {
        SceneManager.LoadScene("Map6by6");
    }
    public void OnMap10by10Click()
    {
        SceneManager.LoadScene("Map10by10");
    }
    */


}
