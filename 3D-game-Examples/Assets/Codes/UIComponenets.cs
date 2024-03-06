using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIComponenets : MonoBehaviour
{
    [SerializeFields] private int _coinCount = 0;
    //[SerializeField] private 
    
    // Start is called before the first frame update
    void Start()
    {
    DisplayCoinCount(); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }
      public void DisplayCoinCount()
      {
        _copoinCountText.text = "Coins: " + _coinCount.ToString();
      }
    public void UpDateCoinCount()
    {
    _coinCount++;
    DisplayCoinCount();
    if(_coinCount >= _amountToOpenTheDoor)
        {
            GameObject.Find("Door".GetComponent<Doors>().DoorCanBeOpened);
        }

    }
}
