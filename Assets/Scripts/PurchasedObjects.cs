using SaveData;
using System.Collections.Generic;
using UnityEngine;

public class PurchasedObjects : MonoBehaviour
{
    public static PurchasedObjects Instance { get; private set; }

    public Dictionary<BuyObject.ObjectsToBuy, bool> PurchasedDict;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializePurchasedDict();
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void InitializePurchasedDict()
    {
        var gameData = SaveManager.Load<SaveData.GameData>("mainSave");

        PurchasedDict = new Dictionary<BuyObject.ObjectsToBuy, bool>
        {
            { BuyObject.ObjectsToBuy.Arch,    gameData.PurchasedArch },
            { BuyObject.ObjectsToBuy.Wheel,   gameData.PurchasedWheel },
            { BuyObject.ObjectsToBuy.Pipe,    gameData.PurchasedPipe },
            { BuyObject.ObjectsToBuy.Home,    gameData.PurchasedHome },
            { BuyObject.ObjectsToBuy.Watchtower,gameData.PurchasedWatchtower },
            { BuyObject.ObjectsToBuy.Maze,    gameData.PurchasedMaze },
            { BuyObject.ObjectsToBuy.Ball1,   gameData.PurchasedBall1 },
            { BuyObject.ObjectsToBuy.Ball2,   gameData.PurchasedBall2 },
            { BuyObject.ObjectsToBuy.Ball3,   gameData.PurchasedBall3 },
            { BuyObject.ObjectsToBuy.Ball4,   gameData.PurchasedBall4 },
            { BuyObject.ObjectsToBuy.Ball5,   gameData.PurchasedBall5 },
            { BuyObject.ObjectsToBuy.Ball6,   gameData.PurchasedBall6 },
            { BuyObject.ObjectsToBuy.Circle1, gameData.PurchasedCircle1 },
            { BuyObject.ObjectsToBuy.Circle2, gameData.PurchasedCircle2 },
            { BuyObject.ObjectsToBuy.Circle3, gameData.PurchasedCircle3 },
            { BuyObject.ObjectsToBuy.Circle4, gameData.PurchasedCircle4 },
            { BuyObject.ObjectsToBuy.Circle5, gameData.PurchasedCircle5 },
            { BuyObject.ObjectsToBuy.Circle6, gameData.PurchasedCircle6 },
            { BuyObject.ObjectsToBuy.Wall1,   gameData.PurchasedWall1 },
            { BuyObject.ObjectsToBuy.Wall2,   gameData.PurchasedWall2 },
            { BuyObject.ObjectsToBuy.Wall3,   gameData.PurchasedWall3 },
            { BuyObject.ObjectsToBuy.Wall4,   gameData.PurchasedWall4 },
            { BuyObject.ObjectsToBuy.Wall5,   gameData.PurchasedWall5 },
            { BuyObject.ObjectsToBuy.Wall6,   gameData.PurchasedWall6 },
            { BuyObject.ObjectsToBuy.Wall7,   gameData.PurchasedWall7 }
        };


    }

    public void UpdatePurchasedDict()
    {
        var gameData = SaveManager.Load<SaveData.GameData>("mainSave");

        Game.Instance.PurchArch = PurchasedDict[BuyObject.ObjectsToBuy.Arch];
        Game.Instance.PurchWheel = PurchasedDict[BuyObject.ObjectsToBuy.Wheel];
        Game.Instance.PurchPipe = PurchasedDict[BuyObject.ObjectsToBuy.Pipe];
        Game.Instance.PurchHome = PurchasedDict[BuyObject.ObjectsToBuy.Home];
        Game.Instance.PurchWatchtower = PurchasedDict[BuyObject.ObjectsToBuy.Watchtower];
        Game.Instance.PurchMaze = PurchasedDict[BuyObject.ObjectsToBuy.Maze];
        Game.Instance.PurchBall1 = PurchasedDict[BuyObject.ObjectsToBuy.Ball1];
        Game.Instance.PurchBall2 = PurchasedDict[BuyObject.ObjectsToBuy.Ball2];
        Game.Instance.PurchBall3 = PurchasedDict[BuyObject.ObjectsToBuy.Ball3];
        Game.Instance.PurchBall4 = PurchasedDict[BuyObject.ObjectsToBuy.Ball4];
        Game.Instance.PurchBall5 = PurchasedDict[BuyObject.ObjectsToBuy.Ball5];
        Game.Instance.PurchBall6 = PurchasedDict[BuyObject.ObjectsToBuy.Ball6];
        Game.Instance.PurchCircle1 = PurchasedDict[BuyObject.ObjectsToBuy.Circle1];
        Game.Instance.PurchCircle2 = PurchasedDict[BuyObject.ObjectsToBuy.Circle2];
        Game.Instance.PurchCircle3 = PurchasedDict[BuyObject.ObjectsToBuy.Circle3];
        Game.Instance.PurchCircle4 = PurchasedDict[BuyObject.ObjectsToBuy.Circle4];
        Game.Instance.PurchCircle5 = PurchasedDict[BuyObject.ObjectsToBuy.Circle5];
        Game.Instance.PurchCircle6 = PurchasedDict[BuyObject.ObjectsToBuy.Circle6];
        Game.Instance.PurchWall1 = PurchasedDict[BuyObject.ObjectsToBuy.Wall1];
        Game.Instance.PurchWall2 = PurchasedDict[BuyObject.ObjectsToBuy.Wall2];
        Game.Instance.PurchWall3 = PurchasedDict[BuyObject.ObjectsToBuy.Wall3];
        Game.Instance.PurchWall4 = PurchasedDict[BuyObject.ObjectsToBuy.Wall4];
        Game.Instance.PurchWall5 = PurchasedDict[BuyObject.ObjectsToBuy.Wall5];
        Game.Instance.PurchWall6 = PurchasedDict[BuyObject.ObjectsToBuy.Wall6];
        Game.Instance.PurchWall7 = PurchasedDict[BuyObject.ObjectsToBuy.Wall7];


    }
}
