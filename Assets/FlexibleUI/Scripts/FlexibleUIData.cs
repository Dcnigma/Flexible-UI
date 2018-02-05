using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI Data")]
public class FlexibleUIData : ScriptableObject
{
	[Header("Flexible Button Sprites")]
	public Sprite buttonSprite;
	public SpriteState buttonSpriteState;


	[Header("Default")]
	public Color defaultColor;
	public Sprite defaulticon;

	[Header("Confirm")]
	public Color confirmColor;
	public Sprite confirmicon;

	[Header("Decline")]
	public Color declineColor;
	public Sprite declineicon;

	[Header("Warning")]
	public Color warningColor;
	public Sprite warningicon;

	[Header("Text")]
	public string text;
	public Color TextColor;
	public Sprite Texticon;
	public Color TextBlockColor;
}