using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuDemo : MonoBehaviour
{
    public GameObject CreditsPanel;
    public GameObject HintsPanel;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
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
        SceneManager.LoadScene("Level10by10");
    }

    public void OnCreditButtonClick()
    {
        if(CreditsPanel.active == true)
        {
            CreditsPanel.SetActive(false);
        }
        else
        {
            CreditsPanel.SetActive(true);
        }    
    }

    public void OnHintsButtonClick()
    {
        if (HintsPanel.active == true)
        {
            HintsPanel.SetActive(false);
        }
        else
        {
            HintsPanel.SetActive(true);
        }
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
