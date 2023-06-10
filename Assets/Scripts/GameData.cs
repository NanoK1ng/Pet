using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SaveData
{
    [System.Serializable]
    public class GameData
    {
        //public Money Coins;

        public TransformData PetTransform;
        public TransformData BallTransform;
        public TransformData Ball1Transform;
        public TransformData Ball2Transform;
        public TransformData Ball3Transform;
        public TransformData Ball4Transform;
        public TransformData Ball5Transform;
        public TransformData Ball6Transform;
        public TransformData CircleTransform;
        public TransformData Circle1Transform;
        public TransformData Circle2Transform;
        public TransformData Circle3Transform;
        public TransformData Circle4Transform;
        public TransformData Circle5Transform;
        public TransformData Circle6Transform;

        public TransformData ArchTransform;
        public TransformData WheelTransform;
        public TransformData PipeTransform;
        public TransformData HomeTransform;
        public TransformData WatchtowerTransform;
        public TransformData MazeTransform;

        public TransformData Wall1;
        public TransformData Wall2;
        public TransformData Wall3;
        public TransformData Wall4;
        public TransformData Wall5;
        public TransformData Wall6;
        public TransformData Wall7;
        
        public bool PurchasedArch;

        public bool PurchasedWheel;

        public bool PurchasedPipe;

        public bool PurchasedHome;

        public bool PurchasedWatchtower;

        public bool PurchasedMaze;

        public bool PurchasedBall1;
        public bool PurchasedBall2;
        public bool PurchasedBall3;
        public bool PurchasedBall4;
        public bool PurchasedBall5;
        public bool PurchasedBall6;

        public bool PurchasedCircle1;
        public bool PurchasedCircle2;
        public bool PurchasedCircle3;
        public bool PurchasedCircle4;
        public bool PurchasedCircle5;
        public bool PurchasedCircle6;

        public bool PurchasedWall1;
        public bool PurchasedWall2;
        public bool PurchasedWall3;
        public bool PurchasedWall4;
        public bool PurchasedWall5;
        public bool PurchasedWall6;
        public bool PurchasedWall7;

        public GameData()
        {
            PetTransform = new TransformData()
            {
                position = new Vector3(0f, 0.1f, 0f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };

            CircleTransform = new TransformData()
            {
                position = new Vector3(0f, 0f, -3f),
                rotation = Quaternion.identity,
                scale = new Vector3(1.25f,1,1)
            };

            Circle1Transform = new TransformData()
            {
                position = new Vector3(3f, 0f, -1f),
                rotation = Quaternion.identity,
                scale = new Vector3(1.25f, 1, 1)
            };
            Circle2Transform = new TransformData()
            {
                position = new Vector3(10f, 0f, -3f),
                rotation = Quaternion.identity,
                scale = new Vector3(1.25f, 1, 1)
            };
            Circle3Transform = new TransformData()
            {
                position = new Vector3(-10f, 0f, -3f),
                rotation = Quaternion.identity,
                scale = new Vector3(1.25f, 1, 1)
            };
            Circle4Transform = new TransformData()
            {
                position = new Vector3(10f, 0f, 13f),
                rotation = Quaternion.identity,
                scale = new Vector3(1.25f, 1, 1)
            };
            Circle5Transform = new TransformData()
            {
                position = new Vector3(0f, 0f, 8f),
                rotation = Quaternion.identity,
                scale = new Vector3(1.25f, 1, 1)
            };
            Circle6Transform = new TransformData()
            {
                position = new Vector3(-10f, 0f, 13f),
                rotation = Quaternion.identity,
                scale = new Vector3(1.25f, 1, 1)
            };

            BallTransform = new TransformData()
            {
                position = new Vector3(-1f, 1f, -1f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            Ball1Transform = new TransformData()
            {
                position = new Vector3(1f, 1f, -1f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            Ball2Transform = new TransformData()
            {
                position = new Vector3(10f, 1f, -1f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            Ball3Transform = new TransformData()
            {
                position = new Vector3(-19f, 1f, -1f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            Ball4Transform = new TransformData()
            {
                position = new Vector3(10f, 1f, 11f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            Ball5Transform = new TransformData()
            {
                position = new Vector3(0f, 1f, 10f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            Ball6Transform = new TransformData()
            {
                position = new Vector3(-10f, 1f, 11f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };

            ArchTransform = new TransformData()
            {
                position = new Vector3(-3f, 0.45f, 0f),
                rotation = Quaternion.Euler(0f, 90f, 0f),
                scale = Vector3.one
            };
            PipeTransform = new TransformData()
            {
                position = new Vector3(12f, 0.77f, 3f),
                rotation = Quaternion.Euler(0f, -170f, -90f),
                scale = Vector3.one
            };
            WheelTransform = new TransformData()
            {
                position = new Vector3(0f, 1.7f, 13f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            HomeTransform = new TransformData()
            {
                position = new Vector3(-13f, 0f, 0f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };
            WatchtowerTransform = new TransformData()
            {
                position = new Vector3(-12f, 0f, 8f),
                rotation = Quaternion.Euler(0f, -120f, 0f),
                scale = Vector3.one
            };
            MazeTransform = new TransformData()
            {
                position = new Vector3(10f, 0f, 8f),
                rotation = Quaternion.identity,
                scale = Vector3.one
            };

        }

    }

    [System.Serializable]
    public class TransformData
    {
        public Vector3 position;
        public Quaternion rotation;
        public Vector3 scale;
    }
}
