using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class  text  : MonoBehaviour
{
 
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update() {
        scoreText.text = player.position.z.ToString("0");

        scoreText.text = (player.position.z + 86).ToString("0");
           
      
    }
}
