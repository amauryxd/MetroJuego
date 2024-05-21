using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip[] SonidosRandom;
    private AudioSource source;
    public float time, indicador;
    bool jugar = true;

    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(Elegirsonido());

    }

    // Update is called once per frame
    void Update()
    {
  
    }
    private IEnumerator Elegirsonido()
    {
        while(jugar)
        { 
        indicador = Random.Range(1, 4);
        yield return new WaitForSeconds(time);
        }
    }
    
}
