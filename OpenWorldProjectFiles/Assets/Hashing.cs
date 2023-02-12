using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hashing : MonoBehaviour
{
    public int jumpBool;
    public int landingBool;
    public int speedFloat;
    public int movingBool;
    public int fallingBool;
    public int armedBool;
    public int attack1Bool;
    public int rollBool;
    public int deathBool;

    private void Awake()
    {
        movingBool = Animator.StringToHash("Moving");
        jumpBool = Animator.StringToHash("Jump");
        landingBool = Animator.StringToHash("Landing");
        speedFloat = Animator.StringToHash("AnimationSpeed");
        fallingBool = Animator.StringToHash("Falling");
        armedBool = Animator.StringToHash("Armed");
        attack1Bool = Animator.StringToHash("Attack-1");
        rollBool = Animator.StringToHash("Roll");
        deathBool = Animator.StringToHash("Death");
    }
}
