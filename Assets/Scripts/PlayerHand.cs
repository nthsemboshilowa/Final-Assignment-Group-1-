using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public List<PlayerHand> Hand = new List<PlayerHand>();


    public GameObject HandPrefab;
    public bool[] availableHandSlots;
}
