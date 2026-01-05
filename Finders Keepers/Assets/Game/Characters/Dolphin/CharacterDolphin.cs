using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class CharacterDolphin : CharacterScript<CharacterDolphin>
{


	IEnumerator OnLookAt()
	{

		yield return E.Break;
	}

	IEnumerator OnInteract()
	{
		yield return C.FaceClicked();
		
		if (E.Occurrence("useDolphin") > 0)
		{
			yield return C.Pebbles.Say("Hi, dolphin!");
		}
		else
		{
			yield return E.WaitSkip();
			yield return C.Pebbles.Say("That's a dolphin!");
			yield return E.WaitSkip();
		}
		
		yield return E.Break;
	}

	IEnumerator OnUseInv( IInventory item )
	{

		yield return E.Break;
	}
}