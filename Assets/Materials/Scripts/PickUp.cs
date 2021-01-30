using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   [SerializeField]
   public PickUpType PickupType;
   public enum PickUpType
    {
        Regular,
        SpeedUp
    }
}
