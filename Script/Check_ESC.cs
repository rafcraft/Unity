using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Check_ESC : MonoBehaviour
{
    public Button back;
    public Button exit;
    public Canvas menu;

    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(ResumeGame);
        exit.onClick.AddListener(delegate {
            SceneManager.LoadScene("Scenes/Main_menu");
        });
    }
    void PauseGame()
    {
        menu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        menu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
}
