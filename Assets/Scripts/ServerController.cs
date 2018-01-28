using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerController : MonoBehaviour {

	public string iptoConnect;
	public int portToConnect;
	public int numberPlayers;

	// Use this for initialization
	void Start () {
		iptoConnect = Network.player.ipAddress;

		
	}//START 
	
	// Update is called once per frame
	void Update () {
		
	}
	void StartServer(){
		if(Network.peerType ==  NetworkPeerType.Disconnected){
			Debug.Log(Network.InitializeServer (numberPlayers, portToConnect, false));
		} 
	}//INICAR O SERVER
	void ConnectToServer(){
		if (Network.peerType == NetworkPeerType.Disconnected) {
			Debug.Log(Network.Connect (iptoConnect, portToConnect));
		}//IF
	}//CONEXAO SERVer

	void OnGUI(){
		if (Network.peerType == NetworkPeerType.Disconnected) {
			if (GUI.Button (new Rect (Screen.width / 2 - 100, 10, 200, 30), "Inicializar Servidor")) {
				StartServer ();
			}
			iptoConnect = GUI.TextField (new Rect (Screen.width / 2 - 100, 40, 200, 30), iptoConnect);
			if (GUI.Button (new Rect (Screen.width / 2 - 100, 70, 200, 30), "Conectar ao Servidor")) {
				ConnectToServer ();
			}//IF
		}//teste
	}//ONGUI
}//CLASS
