using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuScript : MonoBehaviour
{

    private GameObject selectedButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectedButton = EventSystem.current.currentSelectedGameObject;

        if (Input.GetKeyDown(KeyCode.U))
        {
            selectedButton.GetComponent<Button>().onClick.Invoke();
        }
    }

    public void playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void DeathScreen()
    {
        SceneManager.LoadScene(2);
    }

    public void WinScreen()
    {
        SceneManager.LoadScene(3);
    }

    public void Settings()
    {
        SceneManager.LoadScene(4);
    }
}
