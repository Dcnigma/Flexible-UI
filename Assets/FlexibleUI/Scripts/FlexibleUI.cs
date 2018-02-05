using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode()]

public class FlexibleUI : MonoBehaviour {

	public FlexibleUIData skinData;

	protected virtual void OnSkinUI()
	{
		
	}

	public virtual void Awake()
	{
		OnSkinUI();
	}
	public virtual void Update()
	{
	//Remove this update function in a big Update because its system resource killer
		if (Application.isEditor) 
		{
			OnSkinUI ();
		}
	}
}