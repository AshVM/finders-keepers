using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class RoomIgloo : RoomScript<RoomIgloo>
{
	
	
	
	IEnumerator OnInteractHotspotWall( IHotspot hotspot )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		yield return E.WaitSkip();
		yield return C.Dave.Say("That's definitely a wall im trying to use!");
		
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotWall( IHotspot hotspot )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		yield return E.WaitSkip();
		yield return C.Dave.Say("That's definitely a wall im looking at!");
		yield return E.Break;
	}

	IEnumerator OnUseInvHotspotWall( IHotspot hotspot, IInventory item )
	{

		yield return E.Break;
	}

	IEnumerator OnWalkTo()
	{
		
		yield return E.Break;
	}
}