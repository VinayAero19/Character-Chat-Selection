using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;
public class Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject[] playerprefab;
    [SerializeField]
    private Dropdown dp;
    [SerializeField]
    private GameObject instructions;

    [SerializeField]
    private GameObject main;
   
    void Awake()
    {
    
             
    }
   
 

    void Start()
    {
        
       

    }

   public  void Spawn()
    {
        if (dp.value == 1)
        {
            PhotonNetwork.Instantiate(playerprefab[0].name, Vector3.zero, Quaternion.identity);
        
        }
        if (dp.value == 2)
        {
            PhotonNetwork.Instantiate(playerprefab[1].name, Vector3.zero, Quaternion.identity);
                    
        }else if (dp.value == 3)
        {
            PhotonNetwork.Instantiate(playerprefab[2].name, Vector3.zero, Quaternion.identity);
          
           
        } else if (dp.value ==4)
        {
            PhotonNetwork.Instantiate(playerprefab[3].name, Vector3.zero, Quaternion.identity);
          
            
        }else if (dp.value == 5)
        {
            PhotonNetwork.Instantiate(playerprefab[4].name, Vector3.zero, Quaternion.identity);
                      
        }
       
        dp.gameObject.SetActive(false);
        Invoke("camHeadache", 1f);    
        Destroy(instructions, 5f);
       
            
       
    }

    void camHeadache()
    {
        main.SetActive(true);
        instructions.SetActive(true);
    }
      
    
    
}
