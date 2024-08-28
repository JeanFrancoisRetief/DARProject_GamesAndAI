using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour
{
    public GameObject NatObj;
    public GameObject RoachObj;
    public GameObject PrawnObj;
    //public GameObject RatObj;
    //public GameObject CrocObj;

    public enum Enemy_Type
    {
        Nat,
        Roach,
        Prawn,
        Rat,
        Croc
    };

    public Enemy_Type currentEnemyType;

    // Start is called before the first frame update
    void Start()
    {
        if(currentEnemyType == Enemy_Type.Nat)
        {
            NatObj.SetActive(true);
        }
        if (currentEnemyType == Enemy_Type.Roach)
        {
            RoachObj.SetActive(true);
        }
        if (currentEnemyType == Enemy_Type.Prawn)
        {
            PrawnObj.SetActive(true);
        }
        if (currentEnemyType == Enemy_Type.Rat)
        {
            //RatObj.SetActive(true);
        }
        if (currentEnemyType == Enemy_Type.Croc)
        {
            //CrocObj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
