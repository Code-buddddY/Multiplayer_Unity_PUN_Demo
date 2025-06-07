using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class connectToServer : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // Connect to photon server
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(); // On connect Master executes which means we are connected to photon server now we should enter lobby
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
