using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Menu : MonoBehaviourPunCallbacks
{
    private bool isconnecting = false;
    private const string version = "1.0";
    private const int MaxplayerPerRoom = 20;

    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }
   
    public void SearchForGame()
    {
        isconnecting = true;
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            PhotonNetwork.GameVersion = version;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected");
        if(isconnecting)
        {
            PhotonNetwork.JoinRandomRoom();
        }
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
      Debug.Log("disconnectd due to : { cause}");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log(" no one has made any room");
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = MaxplayerPerRoom });
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("client joined");
        PhotonNetwork.LoadLevel("Game");
    }
}
