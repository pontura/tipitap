﻿using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class Character : MonoBehaviour {

    int distance ;
    float timeToCrossLane;
    public Lane lane;
    public states state;

    public enum states
    {
        IDLE,
        CHANGE,
        JUMP
    }
    public void Init()
    {
        distance = Data.Instance.gameData.laneSeparation / 2;
        timeToCrossLane = Data.Instance.gameData.timeToCrossLane / 2;
    }
	public void MoveUP()
    {
        Vector3 pos = transform.localPosition;
        pos.y += distance;
        Move(pos);
    }
    public void MoveDown()
    {
        Vector3 pos = transform.localPosition;
        pos.y -= distance;
        Move(pos);
    }
    public void GotoCenterOfLane()
    {
        Vector3 pos = transform.localPosition;
        pos.y = 0;
        Move(pos);
    }
    public void Move(Vector3 pos)
    {
        state = states.CHANGE;
        TweenParms parms = new TweenParms();
        parms.Prop("localPosition", pos);
        parms.Ease(EaseType.Linear);
        if(pos.y == 0)
            parms.OnComplete(OnChangeLaneComplete);
        else
            parms.OnComplete(OnChangeingLane);
        HOTween.To(transform, timeToCrossLane, parms);
    }
    void OnChangeingLane()
    {
        Events.OnChangeingLane();
    }
    void OnChangeLaneComplete()
    {
        state = states.IDLE;
        Events.OnChangeLaneComplete();
    }
}
