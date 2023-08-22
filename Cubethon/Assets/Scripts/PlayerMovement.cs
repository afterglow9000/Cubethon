using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float forwardForce = 2000f;
    public Rigidbody rB;
    public float sideForce = 500f;

    private void FixedUpdate () {

        rB.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
            rB.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
            rB.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (rB.position.y < -1f)
            FindObjectOfType<GamingManager>().EndGame();

	}

}
