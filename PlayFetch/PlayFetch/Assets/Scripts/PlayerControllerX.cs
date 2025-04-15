using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
  
{
    private float leftLimit = -45;
    private float bottomLimit = -5;
    public float coolDownTimerDefault = 4f;
    private float coolDownTimer = 0;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolDownTimer <= 0)
        {
            coolDownTimer = coolDownTimerDefault;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
           
        }

        coolDownTimer -= Time.deltaTime;
    }
}
