using System.Collections;
using UnityEngine;

public class DoJab : MonoBehaviour
{

public int wait = 50;
public FistHitbox fist;

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            animator.SetTrigger("RightJab");
           fist.isPunching = true;
         
        }
        if (Input.GetMouseButtonDown(0)) 
        {
            animator.SetTrigger("LeftJab");
           fist.isPunching = true;
        }
      
        if (Input.GetMouseButtonUp(0)) 
        {
         StartCoroutine(WaitAndSetPunching());
        }

        if (Input.GetMouseButtonUp(1)) 
        {
            StartCoroutine(WaitAndSetPunching());
        }

    }

    IEnumerator WaitAndSetPunching()
    {
      
        for (int i = 0; i < wait; i++)
            yield return null; // Wait for 'wait' frames
    
        fist.isPunching = false ;  }
}

