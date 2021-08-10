using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    public void ChooseLevel()
    {
        SceneManager.LoadScene("ChooseLevel");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
