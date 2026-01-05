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

	IEnumerator OnInteractPropEmployeeDoor( IProp prop )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("It's a restricted area..");
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("..maybe I should go inside!");
		yield return E.WaitSkip();
		
		
		
		yield return E.Break;
	}

	IEnumerator OnInteractPropPeople( IProp prop )
	{
		yield return C.FaceClicked();
		yield return C.WalkToClicked();
		
		if (E.Occurrence("usePeople") > 1)
		{
			yield return C.Pebbles.Say("someone should cheer them up!");
		}
		else
		{
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("The audience looks pretty sad..");
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("Maybe someone cheer them up!");
			yield return E.WaitSkip();
		}
		yield return E.Break;
	}

	IEnumerator OnInteractPropLeak( IProp prop )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		
		if (E.Occurrence("useLeak") > 1)
		{
			yield return C.Pebbles.Say("again, maybe I can use this for something...");
		
		}
		else
		{
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("The dolphin enclosure always has a leak...");
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("maybe I can use it for something");
		yield return E.WaitSkip();
		}
		
		
		
		yield return E.Break;
	}

	IEnumerator OnInteractPropKeypad( IProp prop )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		
		if (Prop("Keypad").UseCount == 0)
		{
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("It's a keypad to unlock the door..");
			yield return E.WaitSkip();
			yield return C.Pebbles.Say(".. I can't do anything with it while the audience is watching");
			yield return E.WaitSkip();
		}
		else if (C.HappyPeng.Visible == true && C.HappyPeng.Clickable == true)
		{
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("The audience is distracted!");
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("Maybe I can finally disable the keypad!");
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("If only I had a way to some water to short circuit it...");
			yield return E.WaitSkip();
		
		}
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotEnclosure( IHotspot hotspot )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("That's the dolphin enclosure");
		yield return E.WaitSkip();
		yield return C.Pebbles.Say(" It's especially leaky this time of year...");
		yield return E.Break;
	}

	IEnumerator OnLookAtPropLeak( IProp prop )
	{

		yield return E.Break;
	}

	IEnumerator OnLookAtPropPeople( IProp prop )
	{

		yield return E.Break;
	}

	void OnEnterRoom()
	{
	}

	IEnumerator OnEnterRoomAfterFade()
	{
		// Put things here that happen when you enter a room
		
		if ( FirstTimeVisited && EnteredFromEditor == false ) // Only run this part the first time you visit, and not when debugging
		{
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("Well, I guess this is a test project for an adventure game");
			yield return C.Pebbles.WalkTo(Point("EntryWalk"));
			yield return C.Pebbles.Say("Sure looks adventurey!");
			Audio.PlayMusic("MusicExample");
			yield return E.WaitSkip();
			yield return C.Display("Left Click to Walk & Interact\nRight Click to Look At");
		}
		
		
		C.Pebbles.WalkToBG(Point("EntryPoint"));
		bool fedPeng = false;
		
		
		yield return E.Break;
	}

	IEnumerator OnInteractPropFishBucket( IProp prop )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		yield return C.Display("pebbles stoops to pick up the bucket");
		Audio.Play("Bucket");
		prop.Disable();
		I.FishBucket.Add();
		yield return E.WaitSkip();
		yield return C.Plr.FaceDown();
		yield return C.Pebbles.Say("Yaaay! I got a bucket!");
		yield return E.WaitSkip();
		yield return C.Display("Access your Inventory from the top of the screen");
		
		yield return E.Break;
	}

	IEnumerator OnUseInvPropPeople( IProp prop, IInventory item )
	{

		yield return E.Break;
	}

	IEnumerator OnUseInvPropKeypad( IProp prop, IInventory item )
	{
		if ( item == I.WaterBucket )
		{
		
			I.WaterBucket.Remove();
			yield return E.WaitSkip();
			yield return C.Display("Pebbles spills the water on the keypad");
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("I should be able to open the employee door now!");
			yield return E.WaitSkip();
		
		}
		yield return E.Break;
	}

	IEnumerator OnUseInvPropEmployeeDoor( IProp prop, IInventory item )
	{

		yield return E.Break;
	}

	IEnumerator OnUseInvPropLeak( IProp prop, IInventory item )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		if ( item == I.EmptyBucket)
		{
			I.EmptyBucket.Remove();
			I.WaterBucket.AddAsActive();
			yield return E.WaitSkip();
			yield return C.Display("Pebbles fills the empty bucket with water");
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("The bucket's full now!");
			yield return E.WaitSkip();
		}
		yield return E.Break;
	}

	IEnumerator OnUseInvHotspotEnclosure( IHotspot hotspot, IInventory item )
	{

		yield return E.Break;
	}

	IEnumerator OnInteractPropIceberg( IProp prop )
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("That's our iceberg!");
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("...it's probably fake.");
		yield return E.WaitSkip();
		
		yield return E.Break;
	}
}