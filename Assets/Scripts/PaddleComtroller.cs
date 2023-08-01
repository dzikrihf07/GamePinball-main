using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleComtroller : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    private float targetPressed;
    private float targetReleased;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }
    
    private void ReadInput()
    {
        JointSpring jointspring = hinge.spring;
        if(Input.GetKey(input))
        {
            jointspring.targetPosition = targetPressed;
        }
        else
        {
            jointspring.targetPosition = targetReleased;
        }

        hinge.spring = jointspring;
    }
}
