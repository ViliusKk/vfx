using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinTester : MonoBehaviour
{
    public ParticleSystem slashEffect;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Slash());
        }
    }

    IEnumerator Slash()
    {
        animator.Play("Slash");
        yield return new WaitForSeconds(0.8f);
        slashEffect.Play();
    }
}
