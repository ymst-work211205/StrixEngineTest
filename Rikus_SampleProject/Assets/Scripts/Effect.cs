using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    ParticleSystem particleSys;
    public void PlayEffect()
    {
        particleSys = this.GetComponent<ParticleSystem>();
        particleSys.Play();
    }
}
