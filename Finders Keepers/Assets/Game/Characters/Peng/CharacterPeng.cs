using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class CharacterPeng : CharacterScript<CharacterPeng>
{


	IEnumerator OnInteract()
	{

		yield return E.Break;
	}
}