public delegate void MovementDelegate(float inputX, 
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
bool idleDown
);

public static class EventHandler
{
    // movement event
    public static event MovementDelegate MovementEvent;

    // publisher call
    public static void CallMovementEvent(float inputX,
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
        bool idleDown
    )
    {
        if (MovementEvent != null)
        {
            MovementEvent(inputX, inputY, isWalking, isRunning, isIdle, isCarrying, toolEffect, isUsingToolRight, isUsingToolLeft,
            isUsingToolUp, isUsingToolDown, isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown, isPickingToolRight,
            isPickingToolLeft, isPickingToolUp, isPickingToolDown, isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp,
            isSwingingToolDown, idleRight, idleLeft, idleUp, idleDown);
        }
    }

}
