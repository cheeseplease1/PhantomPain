using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour
{
    public InputActionReference grip;
    public InputActionReference trigger;
    public InputActionReference thumb;

    private Animator anim;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Grip", grip.action.ReadValue<float>());
        anim.SetFloat("Trigger", trigger.action.ReadValue<float>());
        anim.SetFloat("Thumb", thumb.action.ReadValue<float>());
    }
    //fff
}
