using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public void restartgame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit () 
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}
