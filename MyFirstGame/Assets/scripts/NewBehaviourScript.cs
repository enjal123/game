using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{// use public to change name of something
    public Rigidbody enjal;

    public float fowardForce = 1500f;
    public float SidewaysForce;
    public float jumpspeed = 60f;
    void FixedUpdate()
    {
        enjal.AddForce( 0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            enjal.AddForce(SidewaysForce  * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") )
        {
            enjal.AddForce(-SidewaysForce  * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }

        if (enjal.position.y <-15)
        {
            FindObjectOfType<gameendscreen>().EndGame();   
        }

       
    }


}
