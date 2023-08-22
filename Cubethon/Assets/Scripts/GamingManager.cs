using UnityEngine;
using UnityEngine.SceneManagement;

public class GamingManager : MonoBehaviour {

    public float delay = 1f;
    private bool hasEnded = false;
    public GameObject levelCompleteUI;

    public void EndGame () {

        if (hasEnded == false) {
            hasEnded = true;
            Invoke("Restart", delay);
        }

    }

    public void LevelComplete () {

        levelCompleteUI.SetActive(true);

    }

    private void Restart () {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
