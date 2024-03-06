using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FameObject.Find("Game Session").GetComponent<UIComponents>().UpdateCoinCount();
            Destroy(this.gmaeObject);
        }
    }
}
