using UnityEngine;
using Photon.Pun;

// This script is responsible for spawning the player object when the player joins the game.
// It uses Photon Network to instantiate the player prefab at a random position within specified bounds.
public class Spawner : MonoBehaviourPun
{
    void Start()
    {
        if (PhotonNetwork.IsConnectedAndReady)
        {
            GameObject player = PhotonNetwork.Instantiate("Player", new Vector3(Random.Range(-6, 6), -2f, 0f), Quaternion.identity);

            // Activate the Mark only for the local player
            if (player.GetComponent<PhotonView>().IsMine)
            {
                player.transform.Find("Mark").gameObject.SetActive(true);
            }
        }
    }
}
