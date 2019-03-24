using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.PostProcessing;

public class EnableDisable : MonoBehaviour
{
    public GameObject dayObject;
    public GameObject nightObject;
    public GameObject sun;
    private bool nightObjectBool;
    private bool dayObjectBool;

    public float coolDown = 2;
    private float coolDownTimer;

    public GameObject bar;
    public GameObject timer;
    public int time =5;

    //post processing
    public PostProcessingBehaviour nightPP;

    void Start()
    {
        nightObjectBool = true;
        dayObjectBool = false;
        sun.SetActive(false);
        //post processing
        nightPP.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (coolDownTimer >= 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if(coolDownTimer < 0 )
        {
            coolDownTimer = 0;
        }

        if(coolDownTimer == 0)
        {
            sun.SetActive(true);
            InputDetectionLeftShift();
            InputDetectionRightShift();
        }
    }
    

   void InputDetectionLeftShift()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (dayObjectBool == false)
            {
               
                nightPP.enabled = false;
                AnimateBar();
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
                timer.SetActive(true);
                StartCoroutine(AnimateBar());
                StartCoroutine(ChangeToNight());
            }
        }
    }
    
    void InputDetectionRightShift()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           
            Debug.Log("Click");
         
            if(dayObjectBool == false)
            {
               
                nightPP.enabled = false;
                AnimateBar();
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
                timer.SetActive(true);
                StartCoroutine(AnimateBar());
               
                StartCoroutine(ChangeToNight());
            }
        }
    }

    IEnumerator ChangeToNight()
    {
        
        yield return new WaitForSeconds(5);
        
        nightPP.enabled = true;
        dayObjectBool = false;
            nightObjectBool = true;
            dayObject.SetActive(false);
            nightObject.SetActive(true);
            coolDownTimer = coolDown;
            sun.SetActive(false);
          
        
    }
    
    IEnumerator AnimateBar ()
    {
        int scale = 0;
        LeanTween.scaleX(bar, 0, time);
        yield return new WaitForSeconds(5);
        scale = 1;
        LeanTween.scaleX(bar, 1,time);

    }
}
