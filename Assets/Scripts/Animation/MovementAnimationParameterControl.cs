using UnityEngine;

public class MovementAnimationParameterControl : MonoBehaviour
{
    private Animator animator;

    private void Awake() 
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        // subscribe to movement event
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    private void OnDisable()
    {
        EventHandler.MovementEvent -= SetAnimationParameters;
    }

    private void AnimationEventPlayFootstepSound()
    {

    }

    private void SetAnimationParameters(float inputX,
        float inputY, 
        bool isWalking, 
        bool isRunning, 
        bool isIdle, 
        bool isCarrying, 
        ToolEffect toolEffect, 
        bool isUsingToolRight,
        bool isUsingToolLeft,
        bool isUsingToolUp,
        bool isUsingToolDown,
        bool isLiftingToolRight,
        bool isLiftingToolLeft,
        bool isLiftingToolUp,
        bool isLiftingToolDown,
        bool isPickingToolRight,
        bool isPickingToolLeft,
        bool isPickingToolUp,
        bool isPickingToolDown,
        bool isSwingingToolRight,
        bool isSwingingToolLeft,
        bool isSwingingToolUp,
        bool isSwingingToolDown,
        bool idleRight,
        bool idleLeft,
        bool idleUp,
        bool idleDown)
    {
        animator.SetFloat(Settings.xInput, inputX);
        animator.SetFloat(Settings.yInput, inputY);
        animator.SetBool(Settings.isWalking, isWalking);
        animator.SetBool(Settings.isRunning, isRunning);

        Debug.Log("set running to: " + isRunning);
        Debug.Log("animator: " + animator.name);

        animator.SetInteger(Settings.toolEffect, (int) toolEffect);

        if (isUsingToolRight) 
        {
            animator.SetTrigger(Settings.isUsingToolRight);
        }
        if (isUsingToolLeft) 
        {
            animator.SetTrigger(Settings.isUsingToolLeft);
        }
        if (isUsingToolUp) 
        {
            animator.SetTrigger(Settings.isUsingToolUp);
        }
        if (isUsingToolDown) 
        {
            animator.SetTrigger(Settings.isUsingToolDown);
        }

        if (isLiftingToolRight) 
        {
            animator.SetTrigger(Settings.isLiftingToolRight);
        }
        if (isLiftingToolLeft) 
        {
            animator.SetTrigger(Settings.isLiftingToolLeft);
        }
        if (isLiftingToolUp) 
        {
            animator.SetTrigger(Settings.isLiftingToolUp);
        }
        if (isLiftingToolDown) 
        {
            animator.SetTrigger(Settings.isLiftingToolDown);
        }

        if (isPickingToolRight) 
        {
            animator.SetTrigger(Settings.isPickingToolRight);
        }
        if (isPickingToolLeft) 
        {
            animator.SetTrigger(Settings.isPickingToolLeft);
        }
        if (isPickingToolUp) 
        {
            animator.SetTrigger(Settings.isPickingToolUp);
        }
        if (isPickingToolDown) 
        {
            animator.SetTrigger(Settings.isPickingToolDown);
        }

        if (isSwingingToolRight) 
        {
            animator.SetTrigger(Settings.isSwingingToolRight);
        }
        if (isSwingingToolLeft) 
        {
            animator.SetTrigger(Settings.isSwingingToolLeft);
        }
        if (isSwingingToolUp) 
        {
            animator.SetTrigger(Settings.isSwingingToolUp);
        }
        if (isSwingingToolDown) 
        {
            animator.SetTrigger(Settings.isSwingingToolDown);
        }

        if (idleRight) 
        {
            animator.SetTrigger(Settings.idleRight);
        }
        if (idleLeft) 
        {
            animator.SetTrigger(Settings.idleLeft);
        }
        if (idleUp) 
        {
            animator.SetTrigger(Settings.idleUp);
        }
        if (idleDown) 
        {
            animator.SetTrigger(Settings.idleDown);
        }


    }
}
