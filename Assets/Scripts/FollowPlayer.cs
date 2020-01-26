using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Vector3 offset;
    public Transform player;

	// Update is called once per frame
	private void Update () {

        transform.position = player.position + offset;

	}
}
