using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGet : MonoBehaviour
{
    [SerializeField]
    bool item = false;
    
    

    public void ItemCollected()
    {
        item = true;
    }
}
