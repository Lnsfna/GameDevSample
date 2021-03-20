using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SimpleCoin : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public int value;
    private void OnTriggerEnter(Collider other){
        money_info.money += value;
        Debug.Log("Amount of money: " + money_info.money);

        if (other.CompareTag("Player")){
            GameObject.FindGameObjectWithTag ("Player").GetComponent<money_info> ().TextMoney.text = money_info.money.ToString();
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0,rotationSpeed,0);
        
    }
}

