using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenEffects : MonoBehaviour
{
    private GlitchEffect glitch;

   

    public Transform monster;

    public float monsterDistance = 20;

    // Start is called before the first frame update
    void Start()
    {
        glitch = GetComponent<GlitchEffect>();
        glitch.GetComponent<GlitchEffect>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Glitch();

        
    }

   void Glitch()
    {
        float distance = Vector3.Distance(monster.position, transform.position);

        if(distance < monsterDistance)
        {
            glitch.GetComponent<GlitchEffect>().enabled = true;
        }
        else
            glitch.GetComponent<GlitchEffect>().enabled = false;
    }

    void PostProcessing()
    {
        
    }

}
