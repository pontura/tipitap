﻿using UnityEngine;
using System.Collections;

public class ItemsRewardSignal : MonoBehaviour {

    public GameObject Canvas;
    public GameObject[] rewardHats;
    public GameObject[] rewardChairs;
    public GameObject[] rewardHShoes;

    void Awake()
    {
        Events.CheckItemsToReward += CheckItemsToReward;
    }
    void OnDestroy()
    {
        Events.CheckItemsToReward -= CheckItemsToReward;
    }
	void Start () 
    {
        Canvas.SetActive(false);
	}

    void CheckItemsToReward(WordsData.Reward reward)
    {
        Invoke("waited", 0.5f);
        Canvas.SetActive(true);

        foreach (GameObject item in rewardHats)
            item.SetActive(false);
        foreach (GameObject item in rewardChairs)
            item.SetActive(false);
        foreach (GameObject item in rewardHShoes)
            item.SetActive(false);

        GameObject _item;
        switch (reward.rewardType)
        {
            case "hats": _item = rewardHats[reward.num - 1]; break;
            case "chairs": _item = rewardChairs[reward.num - 1]; break;
            default: _item = rewardHShoes[reward.num - 1]; break;
        }
        _item.SetActive(true);
    }
    void waited()
    {
        if(Random.Range(0,100)>50)
            Events.OnSoundFX("21_GetThreeStarsToWinThisItem");
        else
            Events.OnSoundFX("22_ToEarnThreeStars");
        
    }
	public void Close()
    {
        print("Close");
        Events.OnSoundFX("backPress");
        Canvas.SetActive(false);
        Events.OnStartCountDown();
        Events.OnSoundFX("");
	}
}
