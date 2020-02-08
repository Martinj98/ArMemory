using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MatchChecker : MonoBehaviour
{
    public List<CardMatch> cardMatches;
    public GameObject cross;
    public GameObject check;

   
    void OnGUI()
    {
        StateManager sm = TrackerManager.Instance.GetStateManager();
        cardMatches = new List<CardMatch>();
        check.SetActive(false);
        cross.SetActive(false);

        foreach (TrackableBehaviour tb in sm.GetActiveTrackableBehaviours())
        {
            if (tb is ImageTargetBehaviour)
            {
                //First card
                if (cardMatches.Count == 0)
                {
                    cardMatches.Add(tb.gameObject.GetComponentInParent<CardMatch>());
                }
                // if there is already 1 card in the list check if its part of the same match
                else
                {
                    if (cardMatches.Contains(tb.gameObject.GetComponentInParent<CardMatch>()))
                    {
                        check.SetActive(true);
                    }
                    else
                    {
                        cross.SetActive(true);
                    }
                }
            }
        }
    }
}