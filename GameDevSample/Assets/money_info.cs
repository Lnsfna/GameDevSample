using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class money_info : MonoBehaviour
{
    public static int money;

    [SerializeField]
    public Text TextMoney;

    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
