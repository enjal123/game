using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{

    public gameendscreen end;

    void OnTriggerEnter()
    {
        end.levelend();
    }
}
