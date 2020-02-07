using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Changes
{
    Campaign,
    Time_Attack,
    Count
}

public static class GlobalSwitchState
{
    public static Changes current = Changes.Campaign;
    public static GameObject car = null;
    public static Rigidbody rb = null;
    public static bool isPaused = false;
}
