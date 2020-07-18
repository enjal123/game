
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameendscreen : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartTime = 1f;

    public GameObject gameoverUI;

    public void levelend ()

    {
        gameoverUI.SetActive(true);

    }

    public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
           Invoke ("Restart", restartTime);

        }

    }
   void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}