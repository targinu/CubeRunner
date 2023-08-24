using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //adiciona a variavel forwardForce no "z"
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //adiciona a variacel sidewaysForce no "x"
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //adiciona a variacel sidewaysForce no "x", valor negativo para se movimentar para a dire��o oposta
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<Manager>().EndGame();
        }
    }
}
