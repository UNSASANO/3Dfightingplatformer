using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashingControl : MonoBehaviour
{
  
    CharacterController moveScript;

    public float dashSpeed;
    public float dashTime;

// Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponment<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.getkeydown(q))
        {
          StartCoroutine(Dash());
        }
    }

    IEnumerator Dash
    {
        float startTime = Time.time;

        While(Time.time < startTime + dashTime)
        {
          moveScript.controller.Move(moveScript.moveDir * dashSpeed *Time.deltaTime);

          yield return null;
        }
    }
}
