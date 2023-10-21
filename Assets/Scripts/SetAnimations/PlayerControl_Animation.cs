using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_Animation : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        getUserAction();
    }

    void getUserAction()
    {
        animator.ResetTrigger("trigger01");

        animator.SetBool("double_chamber_punch", Input.GetKey(KeyCode.Y));
        animator.SetBool("punch_comb02", Input.GetKey(KeyCode.U));
        animator.SetBool("punch_comb_all", Input.GetKey(KeyCode.I));
        animator.SetBool("punch_right", Input.GetKey(KeyCode.O));
        animator.SetBool("line_destruction", Input.GetKey(KeyCode.P));
        if(Input.GetKey(KeyCode.B))
        animator.SetTrigger("trigger01");
        animator.SetBool("guard", Input.GetKey(KeyCode.Space));
        animator.SetBool("move_left", Input.GetKey(KeyCode.A));
        animator.SetBool("move_right", Input.GetKey(KeyCode.D));
    }
}
