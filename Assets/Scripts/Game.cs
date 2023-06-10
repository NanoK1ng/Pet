using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Game : MonoBehaviour
{
    public static Game Instance;

    [Header("Scriptable Objects")]
    public Money Money;

    [Header("Set in Inspector")]
    public TMP_Text UICoins;

    public GameObject Pet;

    public GameObject Ball;
    public GameObject Ball1;
    public GameObject Ball2;
    public GameObject Ball3;
    public GameObject Ball4;
    public GameObject Ball5;
    public GameObject Ball6;

    public GameObject Circle;
    public GameObject Circle1;
    public GameObject Circle2;
    public GameObject Circle3;
    public GameObject Circle4;
    public GameObject Circle5;
    public GameObject Circle6;

    public GameObject Arch;
    public GameObject Wheel;
    public GameObject Pipe;
    public GameObject Home;
    public GameObject Watchtower;
    public GameObject Maze;

    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject Wall5;
    public GameObject Wall6;
    public GameObject Wall7;


    public bool PurchArch;
    public bool PurchWheel;
    public bool PurchPipe;
    public bool PurchHome;
    public bool PurchWatchtower;
    public bool PurchMaze;

    public bool PurchBall1;
    public bool PurchBall2;
    public bool PurchBall3;
    public bool PurchBall4;
    public bool PurchBall5;
    public bool PurchBall6;

    public bool PurchCircle1;
    public bool PurchCircle2;
    public bool PurchCircle3;
    public bool PurchCircle4;
    public bool PurchCircle5;
    public bool PurchCircle6;

    public bool PurchWall1;
    public bool PurchWall2;
    public bool PurchWall3;
    public bool PurchWall4;
    public bool PurchWall5;
    public bool PurchWall6;
    public bool PurchWall7;

    private bool _firstLaunchGame = true;

    private const string _saveKey = "mainSave";



    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        Load();
        Money.LoadDataFromFile();
        Debug.Log("LoadData");

        if (_firstLaunchGame)
        {
            Money.Coins = 0;
            _firstLaunchGame = false;
        }


    }

    private void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        SetActiveObjectOnScene(sceneName);

        StartCoroutine(SaveDatas());

    }
    private void FixedUpdate()
    {
        UpdateGUI();

    }



    private void UpdateGUI()
    {
        UICoins.text = Money.Coins.ToString();
    }

    IEnumerator SaveDatas()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            Save();
            Money.SaveToFile();
            Debug.Log("SaveData");
        }
    }
    private void Load()
    {
        var data = SaveManager.Load<SaveData.GameData>(_saveKey);

        //Money.Coins = data.Coins.Coins;

        Pet.transform.position = data.PetTransform.position;
        Pet.transform.rotation = data.PetTransform.rotation;

        Ball.transform.position = data.BallTransform.position;
        Ball.transform.rotation = data.BallTransform.rotation;

        Ball1.transform.position = data.Ball1Transform.position;
        Ball1.transform.rotation = data.Ball1Transform.rotation;

        Ball2.transform.position = data.Ball2Transform.position;
        Ball2.transform.rotation = data.Ball2Transform.rotation;

        Ball3.transform.position = data.Ball3Transform.position;
        Ball3.transform.rotation = data.Ball3Transform.rotation;

        Ball4.transform.position = data.Ball4Transform.position;
        Ball4.transform.rotation = data.Ball4Transform.rotation;

        Ball5.transform.position = data.Ball5Transform.position;
        Ball5.transform.rotation = data.Ball5Transform.rotation;

        Ball6.transform.position = data.Ball6Transform.position;
        Ball6.transform.rotation = data.Ball6Transform.rotation;

        Pipe.transform.position = data.PipeTransform.position;
        Pipe.transform.rotation = data.PipeTransform.rotation;

        Home.transform.position = data.HomeTransform.position;
        Home.transform.rotation = data.HomeTransform.rotation;

        Watchtower.transform.position = data.WatchtowerTransform.position;
        Watchtower.transform.rotation = data.WatchtowerTransform.rotation;

        Maze.transform.position = data.MazeTransform.position;
        Maze.transform.rotation = data.MazeTransform.rotation;

        Circle.transform.position = data.CircleTransform.position;

        Circle1.transform.position = data.Circle1Transform.position;
        Circle2.transform.position = data.Circle2Transform.position;
        Circle3.transform.position = data.Circle3Transform.position;
        Circle4.transform.position = data.Circle4Transform.position;
        Circle5.transform.position = data.Circle5Transform.position;
        Circle6.transform.position = data.Circle6Transform.position;

        Arch.transform.position = data.ArchTransform.position;

        PurchArch = data.PurchasedArch;

        PurchWheel = data.PurchasedWheel;

        PurchPipe = data.PurchasedPipe;

        PurchHome = data.PurchasedHome;

        PurchWatchtower = data.PurchasedWatchtower;

        PurchMaze = data.PurchasedMaze;

        PurchBall1 = data.PurchasedBall1;
        PurchBall2 = data.PurchasedBall2;
        PurchBall3 = data.PurchasedBall3;
        PurchBall4 = data.PurchasedBall4;
        PurchBall5 = data.PurchasedBall5;
        PurchBall6 = data.PurchasedBall6;

        PurchCircle1 = data.PurchasedCircle1;
        PurchCircle2 = data.PurchasedCircle2;
        PurchCircle3 = data.PurchasedCircle3;
        PurchCircle4 = data.PurchasedCircle4;
        PurchCircle5 = data.PurchasedCircle5;
        PurchCircle6 = data.PurchasedCircle6;

        PurchWall1 = data.PurchasedWall1;
        PurchWall2 = data.PurchasedWall2;
        PurchWall3 = data.PurchasedWall3;
        PurchWall4 = data.PurchasedWall4;
        PurchWall5 = data.PurchasedWall5;
        PurchWall6 = data.PurchasedWall6;
        PurchWall7 = data.PurchasedWall7;


    }

    public void Save()
    {
        PurchasedObjects.Instance.UpdatePurchasedDict();
        SaveManager.Save(_saveKey, GetSaveSnapshot());

    }

    private SaveData.GameData GetSaveSnapshot()
    {
        var data = new SaveData.GameData()
        {
            //Coins = Money,

            PetTransform = new SaveData.TransformData()
            {
                position = Pet.transform.position,
                rotation = Pet.transform.rotation,
                scale = Pet.transform.localScale
            },
            BallTransform = new SaveData.TransformData()
            {
                position = Ball.transform.position,
                rotation = Ball.transform.rotation,
                scale = Ball.transform.localScale
            },
            Ball1Transform = new SaveData.TransformData()
            {
                position = Ball1.transform.position,
                rotation = Ball1.transform.rotation,
                scale = Ball1.transform.localScale
            },
            Ball2Transform = new SaveData.TransformData()
            {
                position = Ball2.transform.position,
                rotation = Ball2.transform.rotation,
                scale = Ball2.transform.localScale
            },
            Ball3Transform = new SaveData.TransformData()
            {
                position = Ball3.transform.position,
                rotation = Ball3.transform.rotation,
                scale = Ball3.transform.localScale
            },
            Ball4Transform = new SaveData.TransformData()
            {
                position = Ball4.transform.position,
                rotation = Ball4.transform.rotation,
                scale = Ball4.transform.localScale
            },
            Ball5Transform = new SaveData.TransformData()
            {
                position = Ball5.transform.position,
                rotation = Ball5.transform.rotation,
                scale = Ball5.transform.localScale
            },
            Ball6Transform = new SaveData.TransformData()
            {
                position = Ball6.transform.position,
                rotation = Ball6.transform.rotation,
                scale = Ball6.transform.localScale
            },

            CircleTransform = new SaveData.TransformData()
            {
                position = Circle.transform.position,
                rotation = Circle.transform.rotation,
                scale = Circle.transform.localScale
            },
            Circle1Transform = new SaveData.TransformData()
            {
                position = Circle1.transform.position,
                rotation = Circle1.transform.rotation,
                scale = Circle1.transform.localScale
            },
            Circle2Transform = new SaveData.TransformData()
            {
                position = Circle2.transform.position,
                rotation = Circle2.transform.rotation,
                scale = Circle2.transform.localScale
            },
            Circle3Transform = new SaveData.TransformData()
            {
                position = Circle3.transform.position,
                rotation = Circle3.transform.rotation,
                scale = Circle3.transform.localScale
            },
            Circle4Transform = new SaveData.TransformData()
            {
                position = Circle4.transform.position,
                rotation = Circle4.transform.rotation,
                scale = Circle4.transform.localScale
            },
            Circle5Transform = new SaveData.TransformData()
            {
                position = Circle5.transform.position,
                rotation = Circle5.transform.rotation,
                scale = Circle5.transform.localScale
            },
            Circle6Transform = new SaveData.TransformData()
            {
                position = Circle6.transform.position,
                rotation = Circle6.transform.rotation,
                scale = Circle6.transform.localScale
            },

            ArchTransform = new SaveData.TransformData()
            {
                position = Arch.transform.position,
                rotation = Arch.transform.rotation,
                scale = Arch.transform.localScale
            },
            PipeTransform = new SaveData.TransformData()
            {
                position = Pipe.transform.position,
                rotation = Pipe.transform.rotation,
                scale = Pipe.transform.localScale
            },
            HomeTransform = new SaveData.TransformData()
            {
                position = Home.transform.position,
                rotation = Home.transform.rotation,
                scale = Home.transform.localScale
            },
            WatchtowerTransform = new SaveData.TransformData()
            {
                position = Watchtower.transform.position,
                rotation = Watchtower.transform.rotation,
                scale = Watchtower.transform.localScale
            },
            MazeTransform = new SaveData.TransformData()
            {
                position = Maze.transform.position,
                rotation = Maze.transform.rotation,
                scale = Maze.transform.localScale
            },
            PurchasedArch = PurchArch,

            PurchasedWheel = PurchWheel,

            PurchasedPipe = PurchPipe,

            PurchasedHome = PurchHome,

            PurchasedWatchtower = PurchWatchtower,

            PurchasedMaze = PurchMaze,

            PurchasedBall1 = PurchBall1,
            PurchasedBall2 = PurchBall2,
            PurchasedBall3 = PurchBall3,
            PurchasedBall4 = PurchBall4,
            PurchasedBall5 = PurchBall5,
            PurchasedBall6 = PurchBall6,

            PurchasedCircle1 = PurchCircle1,
            PurchasedCircle2 = PurchCircle2,
            PurchasedCircle3 = PurchCircle3,
            PurchasedCircle4 = PurchCircle4,
            PurchasedCircle5 = PurchCircle5,
            PurchasedCircle6 = PurchCircle6,

            PurchasedWall1 = PurchWall1,
            PurchasedWall2 = PurchWall2,
            PurchasedWall3 = PurchWall3,
            PurchasedWall4 = PurchWall4,
            PurchasedWall5 = PurchWall5,
            PurchasedWall6 = PurchWall6,
            PurchasedWall7 = PurchWall7,


        };

        return data;
    }

    private void SetActiveObjectOnScene(string scene)
    {
        if (scene == "Game")
        {
            Arch.SetActive(PurchArch);

            Pipe.SetActive(PurchPipe);

            Wheel.SetActive(PurchWheel);

            Home.SetActive(PurchHome);

            Watchtower.SetActive(PurchWatchtower);

            Maze.SetActive(PurchMaze);

            Ball1.SetActive(PurchBall1);
            Ball2.SetActive(PurchBall2);
            Ball3.SetActive(PurchBall3);
            Ball4.SetActive(PurchBall4);
            Ball5.SetActive(PurchBall5);
            Ball6.SetActive(PurchBall6);

            Circle1.SetActive(PurchCircle1);
            Circle2.SetActive(PurchCircle2);
            Circle3.SetActive(PurchCircle3);
            Circle4.SetActive(PurchCircle4);
            Circle5.SetActive(PurchCircle5);
            Circle6.SetActive(PurchCircle6);

            Wall1.SetActive(!PurchWall1);
            Wall2.SetActive(!PurchWall2);
            Wall3.SetActive(!PurchWall3);
            Wall4.SetActive(!PurchWall4);
            Wall5.SetActive(!PurchWall5);
            Wall6.SetActive(!PurchWall6);
            Wall7.SetActive(!PurchWall7);

        }
        if (scene == "Shop" && !PurchArch)
        {
            Arch.SetActive(!PurchArch);

            Pipe.SetActive(!PurchPipe);

            Wheel.SetActive(!PurchWheel);

            Home.SetActive(!PurchHome);

            Watchtower.SetActive(!PurchWatchtower);

            Maze.SetActive(!PurchMaze);

            Ball1.SetActive(!PurchBall1);
            Ball2.SetActive(!PurchBall2);
            Ball3.SetActive(!PurchBall3);
            Ball4.SetActive(!PurchBall4);
            Ball5.SetActive(!PurchBall5);
            Ball6.SetActive(!PurchBall6);

            Circle1.SetActive(!PurchCircle1);
            Circle2.SetActive(!PurchCircle2);
            Circle3.SetActive(!PurchCircle3);
            Circle4.SetActive(!PurchCircle4);
            Circle5.SetActive(!PurchCircle5);
            Circle6.SetActive(!PurchCircle6);
        }
    }

}
