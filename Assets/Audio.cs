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
    private void sonido()
    {
        indicador = Random.Range(1, 4);
        if (indicador == 3)
        {
            source.clip = SonidosRandom[Random.Range(0, SonidosRandom.Length)];
            source.Play();
        }
        Debug.Log(indicador);
        //8000 HZ CALIDAD 1
    }
}
