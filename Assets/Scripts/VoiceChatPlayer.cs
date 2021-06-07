using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Voice.Unity;
using Photon.Voice.PUN;
using Photon.Pun;
public class VoiceChatPlayer : MonoBehaviourPun
{
    private KeyCode pushkey = KeyCode.P;
    public Recorder voiceRec;
    private PhotonView pv;
    void Start()
    {
        pv = photonView;
        voiceRec.TransmitEnabled = false;
    }

   
    void Update()
    {
        if(Input.GetKeyDown(pushkey))
        {
            if(pv.IsMine)
            {
                voiceRec.TransmitEnabled = true;
            }
        }
        else if(Input.GetKeyUp(pushkey))
        {
            voiceRec.TransmitEnabled = false;
        }
    }
}
