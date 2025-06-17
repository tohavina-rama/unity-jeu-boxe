using UnityEngine;

public class DoJab : MonoBehaviour
{
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
        }
        if (Input.GetMouseButtonDown(0)) 
        {
            animator.SetTrigger("LeftJab");
        }
    }
}
