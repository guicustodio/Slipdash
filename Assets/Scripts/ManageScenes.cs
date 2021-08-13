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
        SceneManager.LoadScene("Choose Levels");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("Level 7");
    }
    public void Level8()
    {
        SceneManager.LoadScene("Level 8");
    }
    public void Level9()
    {
        SceneManager.LoadScene("Level 9");
    }
    public void Level10()
    {
        SceneManager.LoadScene("Level 10");
    }
    public void Level11()
    {
        SceneManager.LoadScene("Level 11");
    }
    public void Level12()
    {
        SceneManager.LoadScene("Level 12");
    }
    public void Level13()
    {
        SceneManager.LoadScene("Level 13");
    }
    public void Level14()
    {
        SceneManager.LoadScene("Level 14");
    }
    public void Level15()
    {
        SceneManager.LoadScene("Level 15");
    }
    public void Level16()
    {
        SceneManager.LoadScene("Level 16");
    }
    public void Level17()
    {
        SceneManager.LoadScene("Level 17");
    }
    public void Level18()
    {
        SceneManager.LoadScene("Level 18");
    }
    public void Level19()
    {
        SceneManager.LoadScene("Level 19");
    }
    public void Level20()
    {
        SceneManager.LoadScene("Level 20");
    }
    public void Level21()
    {
        SceneManager.LoadScene("Level 21");
    }
    public void Level22()
    {
        SceneManager.LoadScene("Level 22");
    }
    public void Level23()
    {
        SceneManager.LoadScene("Level 23");
    }
    public void Level24()
    {
        SceneManager.LoadScene("Level 24");
    }
    public void Level25()
    {
        SceneManager.LoadScene("Level 25");
    }
    public void Level26()
    {
        SceneManager.LoadScene("Level 26");
    }
    public void Level27()
    {
        SceneManager.LoadScene("Level 27");
    }
    public void Level28()
    {
        SceneManager.LoadScene("Level 28");
    }
    public void Level29()
    {
        SceneManager.LoadScene("Level 29");
    }
    public void Level30()
    {
        SceneManager.LoadScene("Level 30");
    }
    public void Level31()
    {
        SceneManager.LoadScene("Level 31");
    }
    public void Level32()
    {
        SceneManager.LoadScene("Level 32");
    }
    public void Level33()
    {
        SceneManager.LoadScene("Level 33");
    }
    public void Level34()
    {
        SceneManager.LoadScene("Level 34");
    }
    public void Level35()
    {
        SceneManager.LoadScene("Level 35");
    }
    public void Level36()
    {
        SceneManager.LoadScene("Level 36");
    }
    public void Level37()
    {
        SceneManager.LoadScene("Level 37");
    }
    public void Level38()
    {
        SceneManager.LoadScene("Level 38");
    }
    public void Level39()
    {
        SceneManager.LoadScene("Level 39");
    }
    public void Level40()
    {
        SceneManager.LoadScene("Level 40");
    }

}
