using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinishTrigger : MonoBehaviour
{

        public Transform particle1;
        public Transform particle2;
        public Transform particle3;


    // Start is called before the first frame update
    void Start()
    {
        particle1.GetComponent<ParticleSystem>().enableEmission = false;
        particle2.GetComponent<ParticleSystem>().enableEmission = false;
        particle3.GetComponent<ParticleSystem>().enableEmission = false;

    }
    private void OnTriggerEnter (Collider other){
        if(other.CompareTag("Player")){
            particle1.GetComponent<ParticleSystem>().enableEmission = true;
            particle2.GetComponent<ParticleSystem>().enableEmission = true;
            particle3.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(stop());
            Debug.Log("Finish");
            other.GetComponent<Movement>().enabled = false;
        }
    }

    IEnumerator stop(){
        yield return new WaitForSeconds(.4f);
        particle1.GetComponent<ParticleSystem>().enableEmission = false;
        particle2.GetComponent<ParticleSystem>().enableEmission = false;
        particle3.GetComponent<ParticleSystem>().enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
