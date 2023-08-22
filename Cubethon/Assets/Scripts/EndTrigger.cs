using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GamingManager gamingManager;

    private void OnTriggerEnter () {

        gamingManager.LevelComplete();

    }

}
