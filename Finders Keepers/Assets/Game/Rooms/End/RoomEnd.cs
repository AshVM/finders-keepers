using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class RoomEnd : RoomScript<RoomEnd>
{


	void OnEnterRoom()
	{
		G.InventoryBar.Hide();
		G.Toolbar.Hide();
	}
}