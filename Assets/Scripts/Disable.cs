using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Disable : MonoBehaviourPun
{
    private PhotonView pv;
    private MoveBehaviour mv;
    private BasicBehaviour bv;
    void Start()
    {
        mv = GetComponent<MoveBehaviour>();

        pv = GetComponent<PhotonView>();
        bv = GetComponent<BasicBehaviour>();


        if (pv.IsMine)
        {
            gameObject.tag = "Player";
        }
        else
        {
            Destroy(mv);
            Destroy(bv);
            Destroy(this);
        }

    }
}
