using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class CharacterHappyPeng : CharacterScript<CharacterHappyPeng>
{


	IEnumerator OnInteract()
	{
		yield return C.WalkToClicked();
		yield return C.FaceClicked();
		
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("He seems a lot a happier!");
		yield return E.WaitSkip();
		yield return C.Pebbles.Say("...and the audience is distracted!");
		yield return E.WaitSkip();
		yield return E.Break;
	}
}