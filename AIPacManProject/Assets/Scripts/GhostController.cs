using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{

    public enum GhostStatesEnum
    { 
        respawning,
        Left,
        Right,
        start,
        center,
        movingthroughNodes
    }

    public GhostStatesEnum GhostState;

    public enum Ghostcolors
    { 
        Red,
        Blue,
        Pink,
        Orange
    }

    public Ghostcolors Ghostcolor;

    // Start is called before the first frame update
    void Start()
    {
        if (Ghostcolor == Ghostcolors.Red)
        {
            GhostState = GhostStatesEnum.start;
        }
        else if (Ghostcolor == Ghostcolors.Blue)
        {
            GhostState = GhostStatesEnum.center;
        }
        else if (Ghostcolor == Ghostcolors.Pink)
        {
            GhostState = GhostStatesEnum.Left;
        }
        else if (Ghostcolor == Ghostcolors.Orange)
        {
            GhostState = GhostStatesEnum.Right;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
