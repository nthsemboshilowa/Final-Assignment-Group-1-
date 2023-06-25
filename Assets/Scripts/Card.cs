using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool hasBeenPlayed;
    public int handIndex;

    private GameManager gm;

    private void Start()
    {
     gm = FindAnyObjectByType<GameManager>();
    }

    public void OnMouseDown()
    {
        if(hasBeenPlayed == false)
        {
            transform.position += Vector3.up * 5;
            hasBeenPlayed = true;
            gm.availableCardSlots[handIndex] = true;
            Invoke("MoveToDiscardPile", 2f);
        }
    }

    private void OnAnimatorMove()
    {
        gm.discardPile.Add(this);
        gameObject.SetActive(false);
    }
}
