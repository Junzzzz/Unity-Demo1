using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1.0F;
    public GameObject completeLevelUI;

    private bool gameEnded = false;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnded) return;

        gameEnded = true;
        var coroutine = Restart();
        StartCoroutine(coroutine);
        // Application.Quit();
    }

    private IEnumerator<WaitForSeconds> Restart()
    {
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}