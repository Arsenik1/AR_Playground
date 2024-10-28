using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate_Attacker_3_Step : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.name == transform.name)
                {
                    if (anim.GetCurrentAnimatorStateInfo(0).IsName("CombatIdle"))
                    {
                        anim.SetTrigger("ClickOnAttacker");
                        // anim.Play("RightHandAttack");
                    }
                    else if(anim.GetCurrentAnimatorStateInfo(0).IsName("RightHandAttack"))
                    {
                        anim.SetTrigger("ClickOnAttacker");
                        // anim.Play("TakeDamage");
                    }
                    else if(anim.GetCurrentAnimatorStateInfo(0).IsName("TakeDamage"))
                    {
                        anim.SetTrigger("ClickOnAttacker");
                        // anim.Play("Death_A");
                    }
                    else if(anim.GetCurrentAnimatorStateInfo(0).IsName("Death_A"))
                    {
                        anim.SetTrigger("ClickOnAttacker");
                        // anim.Play("CombatIdle");
                    }
                    ResetTriggerAfterFrame();
                }
            }
        }
    }
    private System.Collections.IEnumerator ResetTriggerAfterFrame()
    {
        // Wait for the end of the frame to reset the trigger after transition
        yield return new WaitForEndOfFrame();

        // Reset the trigger
        anim.ResetTrigger("YourTriggerName");
    }
}
