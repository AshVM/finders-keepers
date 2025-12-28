using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class CharacterPebbles : CharacterScript<CharacterPebbles>
{


	IEnumerator OnInteract()
	{

		yield return E.Break;
	}

	IEnumerator OnLookAt()
	{

		yield return E.Break;
	}
}