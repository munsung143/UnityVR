using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ARAVRInput
{
    public static Vector3 RHandPosition;
    public static Vector3 RhansDirection;

    public static Vector3 LHandPosition;
    public static Vector3 LhandDirection;

    public static TransForm LHand
    {
        get
        {
            if (lHand == null)
            {
                GameObject handObj = new GameObject("LHand");
                lHand = handObj.transform;
                lHand.parent = Camara.main.transform;
            }
            return lHand;
        }
    }
    public static TransForm RHand
    {
        get
        {
            if (rHand == null)
            {
                GameObject handObj = new GameObject("RHand");
                rHand = handObj.transform;
                rHand.parent = Camara.main.transform;
            }
            return rHand;
        }
    }

    public static TransForm lHand;
    public static TransForm rHand;
}
