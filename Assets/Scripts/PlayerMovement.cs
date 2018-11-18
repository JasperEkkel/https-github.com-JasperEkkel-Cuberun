using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float Forwardmovement = 2000f;
    public float Sidewaysforce = 500f;
    public float jumpForce = 500f;

	// We gebruiken FixedUpdate Omdat we met krachten werken
	void FixedUpdate () 
    {

        rb.AddForce(0, 0, Forwardmovement * Time.deltaTime);

        if (Input.GetKey("d") ) 
        {
            rb.AddForce(Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
      
        if (rb.position.y < 1.90f)
            FindObjectOfType<GameManager>().EndGame();

        if (rb.position.y > 17f)
            FindObjectOfType<GameManager>().EndGame();
    }
}

