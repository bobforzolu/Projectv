using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ball_data",menuName ="Data/Ball Data/ base Data")]
public class Ball_State_data : ScriptableObject
{
    [Header("freeze state")]
    public int freeze = 0;
    public float freeze_gravity = 0;
    public float freeze_position_y = 0;
    public float freeze_position_x = 0;

}
