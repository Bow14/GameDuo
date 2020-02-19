using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYER1, PLAYER2, WON, LOST }

public class BattleSystem : MonoBehaviour
{

	public GameObject player1Prefab1;
	public GameObject player1Prefab2;
	public GameObject player1Prefab3;
	public GameObject player2Prefab1;
	public GameObject player2Prefab2;
	public GameObject player2Prefab3;

	public Transform player1List;
	public Transform player2List;

	private Unit player1Unit1;
	private Unit player1Unit2;
	private Unit player1Unit3;
	private Unit player2Unit1;
	private Unit player2Unit2;
	private Unit player2Unit3;

	public BattleHUD player1hud1;
	public BattleHUD player1hud2;
	public BattleHUD player1hud3;
	public BattleHUD player2hud1;
	public BattleHUD player2hud2;
	public BattleHUD player2hud3;
	
	public BattleState state;
	
	void Start ()
	{
		state = BattleState.START;
		SetupBattle();
	}

	void SetupBattle()
	{
		GameObject player1Go = Instantiate(player1Prefab1, player1List);
		player1Unit1 = player1Go.GetComponent<Unit>();
		
		player1Go = Instantiate(player1Prefab2, player1List);
		player1Unit2 = player1Go.GetComponent<Unit>();
		
		player1Go = Instantiate(player1Prefab3, player1List);
		player1Unit3 = player1Go.GetComponent<Unit>();
		
		GameObject player2Go = Instantiate(player2Prefab1, player2List);
		player2Unit1 = player2Go.GetComponent<Unit>();
		
		player2Go = Instantiate(player2Prefab2, player2List);
		player2Unit2 = player2Go.GetComponent<Unit>();
		
		player2Go = Instantiate(player2Prefab3, player2List);
		player2Unit3 = player2Go.GetComponent<Unit>();
		
		player1hud1.SetHUD(player1Unit1);
		player1hud2.SetHUD(player1Unit2);
		player1hud3.SetHUD(player1Unit3);
		player2hud1.SetHUD(player2Unit1);
		player2hud2.SetHUD(player2Unit2);
		player2hud3.SetHUD(player2Unit3);
		
	}

}
