using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool GiveMoney = true;

    public int Reward = 1;

    public string TargetTag = "Ball";

    public ParticleSystem ParticleGoal;

    public AudioSource GoalSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TargetTag))
            if (GiveMoney)
            {
                RewardForGoal(Reward);
                SetChildObjectsActive(false);
                GiveMoney = false;
                PlayGoalParticles();
                GoalSound.Play();
            }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(TargetTag))
        {
            GiveMoney = true;
            SetChildObjectsActive(true);
        }
    }

    private void SetChildObjectsActive(bool active)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(active);
        }
    }
    private void RewardForGoal(int reward) => Game.Instance.Money.Coins += reward;

    private void PlayGoalParticles()
    {
        if (ParticleGoal != null)
            ParticleGoal.Play();
    }
}
