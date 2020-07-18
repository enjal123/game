
using JetBrains.Annotations;
using UnityEngine;

public class playercollions : MonoBehaviour
{

    public NewBehaviourScript movement;

    void OnCollisionEnter(Collision didi)
   
    {
       
        if (didi.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameendscreen>().EndGame();

        }
      }
    }
