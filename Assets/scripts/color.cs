using UnityEngine;
using System;
using System.Collections;

public class color : MonoBehaviour {
	public Material mat;
	public Material newmat;

	void Start()
	{
		StartCoroutine (delay (3));
	}

	IEnumerator delay(int time)
	{
		ChangeMaterial (mat);
		yield return new WaitForSeconds (time);
		ChangeMaterial (newmat);
	}

	void ChangeMaterial(Material newMat)
	{
		
		Renderer[] children;
		children = GetComponentsInChildren<Renderer>();
		foreach (Renderer rend in children)
		{
			var mats = new Material[rend.materials.Length];
			for (var j = 0; j < rend.materials.Length; j++)
			{
				mats[j] = newMat;
			}
			rend.materials = mats;
		}
	}
}
