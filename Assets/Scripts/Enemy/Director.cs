using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Director : MonoBehaviour
{

    public Agent agent;
  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // perform a raycast
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(camRay, out hit))
            {
                // get agent to go to hit point
                agent.GoHere(hit.point);
            }
        }
    }
}
