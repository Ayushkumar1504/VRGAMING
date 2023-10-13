using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorcontroller : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    
    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    void Update()
    {
        // Check for input, for example, the left mouse button
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //             if (!animator.enabled)
            // {
            //     animator.enabled = true;
            // }


                //   animator.enabled = true;
            // Play the specific animation when the input is detected
            animator.Play("Boxing"); // Replace "YourAnimationName" with the name of your animation state
        }
          if (Input.GetKey("a"))
        {
                        if (!animator.enabled)
            {
                anmator.enabled = true;
            }
i

                //   animator.enabled = true;
            // Play the specific animation when the input is detected
            animator.Play("Illegal Knee"); // Replace "YourAnimationName" with the name of your animation state
        }
    }
}
