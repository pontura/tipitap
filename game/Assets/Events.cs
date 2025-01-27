﻿using UnityEngine;
using System.Collections;

public static class Events {

    public static System.Action<GameObject> OnUIClicked = delegate { };
    

    public static System.Action<string> OnPreloadScene = delegate { };
    public static System.Action<string> OnSceneLoad = delegate { };
    public static System.Action OnLoadSceneReady = delegate { };
    public static System.Action OnSceneReset = delegate { };
    public static System.Action OnTransition = delegate { };
    public static System.Action OnTransitionReady = delegate { };


    //The game:
    public static System.Action StartGame = delegate { };
    public static System.Action OnGameOver = delegate { };
    public static System.Action OnLevelComplete = delegate { };
    public static System.Action<SwipeDetector.directions> OnSwipe = delegate { };

    public static System.Action<float, float> OnSaveVolumes = delegate { };
    public static System.Action<float> OnMusicVolumeChanged = delegate { };
    public static System.Action<float> OnSoundsVolumeChanged = delegate { };
    public static System.Action<bool> OnCapsChanged = delegate { };
    public static System.Action<string> OnVoice = delegate { };
    public static System.Action<string> OnSoundFX = delegate { };
    public static System.Action<string> OnMusicChange = delegate { };

    public static System.Action OnGameComplete = delegate { };
    public static System.Action<bool> OnGamePaused = delegate { };
    public static System.Action OnGameRestart = delegate { };

    public static System.Action<string, int> OnHeroWinClothes = delegate { };
    public static System.Action OnHeroJump = delegate { };
    public static System.Action OnChangeingLane = delegate { };
    public static System.Action OnChangeLaneComplete = delegate { };

    public static System.Action OnHeroCrash = delegate { };
    public static System.Action<int> OnHeroSlide = delegate { };
    public static System.Action OnHeroCelebrate = delegate { };
    public static System.Action OnHeroUnhappy = delegate { };
    public static System.Action OnHeroWin = delegate { };

    public static System.Action<LaneObjectData> OnPlayerHitWord = delegate { };

    public static System.Action SetNextWord = delegate { };
    public static System.Action<WordsData.Word> OnNewWord = delegate { };

    public static System.Action<int> WinDiploma = delegate { };
    
    public static System.Action<int> OnScoreRefresh = delegate { };
    public static System.Action<WordsData.Reward> OnReward = delegate { };

    public static System.Action OnStartCountDown = delegate { };
    public static System.Action<WordsData.Reward> CheckItemsToReward = delegate { };
	public static System.Action<bool> SetPurchasesPanel = delegate { };
    
    
    

}
