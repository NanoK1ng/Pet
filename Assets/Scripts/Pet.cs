using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Pet : MonoBehaviour
{
    public enum EMode { idle, walk, sit, jump, run }

    public static Pet Instance;

    [Header("Set in Inspector")]
    public float Happy = 0.7f;
    public float Speed = 2f;
    public float TimeThinkMin = 1f;
    public float TimeThinkMax = 4f;

    public AudioSource StepSound;

    [Header("Set Dynamically")]
    public float TimeNextDecision = 0f;

    public bool IsMoving = true;

    public EMode Mode = EMode.idle;

    private Animator _anim;
    private Rigidbody _rigid;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _rigid = GetComponent<Rigidbody>();

        if (Instance == null)
            Instance = this;
        else
            Destroy(this);


    }

    private void Start()
    {
        SpawnPet();
        
    }

    private void Update()
    {
        float currentSpeed = _rigid.velocity.magnitude;
        //Debug.Log(currentSpeed);

        //Debug.Log(Mode);
        
        if (!IsMoving || (Time.time > TimeNextDecision))
        {
            DecideDirection();
            IsMoving = true;

        }
        else
        {
            MoveForward();
            StepSound.pitch = Random.Range(0.8f, 1.1f);
            StepSound.Play();
        }

        if (Happy == 0 || Speed == 0)
        {
            Mode = EMode.idle;
        }
        else
        {
            Mode = EMode.walk;
        }

        if (transform.position.y <= -10)
            SpawnPet();

        switch (Mode)
        {
            case EMode.idle:
                _anim.CrossFade("Idle_A", 0);
                _anim.speed = 0.25f;
                break;
            case EMode.walk:
                _anim.CrossFade("Walk", 0);
                _anim.speed = 0.5f;
                break;
            case EMode.run:
                _anim.CrossFade("Run", 0);
                _anim.speed = 1;
                break;
            case EMode.jump:
                _anim.CrossFade("Jump", 0);
                _anim.speed = 1;
                break;
            case EMode.sit:
                _anim.CrossFade("Sit", 0);
                _anim.speed = 0.2f;
                break;
        }
    }

    private void DecideDirection()
    {
        RandomRotate();
        TimeNextDecision = Time.time + Random.Range(TimeThinkMin, TimeThinkMax);
    }

    private void MoveForward()
    {
        if (IsMoving)
            transform.Translate(Vector3.forward * Time.deltaTime * Speed * Happy);
    }

    private void SpawnPet() => transform.position = Vector3.zero;
    public void RandomRotate()
    {
        float angle = Random.Range(0, 361);

        Vector3 newRotation = new Vector3(0, angle, 0);

        transform.rotation = Quaternion.Euler(newRotation);
    }


    

}
