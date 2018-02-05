using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI Data")]
public class FlexibleUIData : ScriptableObject
{
	public Sprite buttonSprite;
	public SpriteState buttonSpriteState;

	public Color defaultColor;
	public Sprite defaulticon;


	public Color confirmColor;
	public Sprite confirmicon;

	public Color declineColor;
	public Sprite declineicon;

	public Color warningColor;
	public Sprite warningicon;
}