using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public GameObject boutonRetourMenu;

    private Button menuBTN;

    void Start()
    {
        menuBTN = boutonRetourMenu.transform.GetComponent<Button>();
        menuBTN.onClick.AddListener(ReturnToMenu);
    }

    private void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
