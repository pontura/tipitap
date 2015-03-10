﻿using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WordsData : MonoBehaviour {

    public int ZoneID;
    public int LevelID;
    public int WordID;

    private Zone[] actualZone;

    public void Init(int ZoneID, int LevelID, int WordID)
    {
        SetZone(ZoneID);
        this.ZoneID = ZoneID;
        this.LevelID = LevelID;
        this.WordID = WordID;
        Events.SetNextWord += SetNextWord;
    }

    [Serializable]
    public class Word
    {
        [SerializeField]
        public string sightWord;

        public string wrong1;
        public string wrong2;
        public string wrong3;

        public int score;
    }

    [Serializable]
    public class Zone
    {
        [SerializeField]
        public string title;
        public Word[] words;
    }

    public Zone[] Zone1;
    public Zone[] Zone2;

    public void SetNextWord()
    {
        WordID++;
        if (actualZone[LevelID-1].words.Length < WordID)
        {
            WordID = 1;
            LevelID++;
        }
        if (actualZone.Length < LevelID)
        {
            LevelID = 1;
            ZoneID++;
            SetZone(ZoneID);
        }
    }
    public Word GetWordData()
    {
        return actualZone[LevelID-1].words[WordID-1];    
    }
    void SetZone(int id)
    {
        switch (id)
        {
            case 1: actualZone = Zone1; break;
            default: actualZone = Zone2; break;
        }
    }
}
