using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class InventoryFishBucket : InventoryScript<InventoryFishBucket>
{


	IEnumerator OnLookAtInventory( IInventory thisItem )
	{

		yield return E.Break;
	}
}