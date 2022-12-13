using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEatSound : MonoBehaviour
{
private AudioSource eatSound;

void Start(){
    eatSound=GetComponent<AudioSource>();
}
private void OnTriggerEnter(Collider other){
    
    if(other.CompareTag("BrachHead")){
        Debug.Log("Brach Head entered");
        eatSound.Play();
    }
}

private void OnTriggerExit(Collider other){
    if(other.CompareTag("BrachHead")){
        Debug.Log("Brach Head EXIT");
        eatSound.Stop();
    }
}

}
