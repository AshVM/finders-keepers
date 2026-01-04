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
}