using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeReference]
    GameObject UIInstruction;

    public void PlayGame()
    {
        GetComponent<AudioSource>().Play();
        /*Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        */
        GameObject.Find("MainMenu").SetActive(false);
        UIInstruction.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
