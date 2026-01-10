using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class CharacterPeng : CharacterScript<CharacterPeng>
{


	IEnumerator OnInteract()
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("He seems sad..");
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("Maybe I can cheer him up!");
		yield return E.WaitSkip();
		yield return E.Break;
	}

	IEnumerator OnUseInv( IInventory item )
	{
		// NB: You need to check they used the correct item!
		if ( item == I.FishBucket )
		{
			yield return C.WalkToClicked();
			yield return C.FaceClicked();
		
		
			I.FishBucket.Remove();
			I.EmptyBucket.Add();
			yield return C.Display("Pebbles feeds the fish to Peng");
			yield return C.Peng.Say("Yaaay! Peng seems to have regained his spirit!");
		
			C.Peng.Visible = false;
			C.Peng.Clickable = false;
		
			C.HappyPeng.Visible = true;
			C.HappyPeng.Clickable = true;
		
			yield return E.Wait(1);
			yield return C.Display("You now have an empty bucket");
			yield return E.WaitSkip();
			yield return C.Pebbles.FaceDown();
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("Yaay! maybe I can fill it with something!");
			yield return E.WaitSkip();
		
		
		}
		yield return E.Break;
	}

	IEnumerator OnLookAt()
	{

		yield return E.Break;
	}
}