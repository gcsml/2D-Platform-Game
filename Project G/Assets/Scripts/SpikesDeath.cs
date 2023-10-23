using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDeath : MonoBehaviour
{

    [SerializeField] GameObject Player;
    [SerializeField] private AudioSource deathsound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Player.transform.position = new Vector3(-4f, 1f, 0f);
       deathsound.Play();
        }
    }
}