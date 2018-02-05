using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class FlexibleUIButton : FlexibleUI
{

	protected Button button;
	protected Image image;
	protected Image icon;
	public Text text;

	public ButtonType buttonType;

	public enum ButtonType
	{
		Default,
		Confirm,
		Decline,
		Warning,
		Text,
	}

	public override void Awake()
	{
		button = GetComponent<Button>();
		image = GetComponent<Image>();
			
		base.Awake();
	}


	protected override void OnSkinUI()
	{
		button.transition = Selectable.Transition.SpriteSwap;
		button.targetGraphic = image;

		image.sprite = skinData.buttonSprite;
		image.type = Image.Type.Sliced;
		button.spriteState = skinData.buttonSpriteState;

		base.OnSkinUI();
		image = GetComponent<Image> ();
		icon = transform.Find ("Icon").GetComponent<Image> ();
		button = GetComponent<Button> ();

		button.transition = Selectable.Transition.SpriteSwap;
		button.targetGraphic = image;

		image.sprite = skinData.buttonSprite;
		image.type = Image.Type.Sliced;
		button.spriteState = skinData.buttonSpriteState;

		if (text != null) {
			text.text = skinData.text;
		}

	switch (buttonType)
	{
		case ButtonType.Confirm:
			image.color = skinData.confirmColor;
			icon.sprite = skinData.confirmicon;
			text.gameObject.SetActive(false);
		break;
	case ButtonType.Decline:
		image.color = skinData.declineColor;
		icon.sprite = skinData.declineicon;
			text.gameObject.SetActive(false);
		break;
	case ButtonType.Default:
		image.color = skinData.defaultColor;
		icon.sprite = skinData.defaulticon;
			text.gameObject.SetActive(false);
		break;
	case ButtonType.Warning:
		image.color = skinData.warningColor;
		icon.sprite = skinData.warningicon;
			text.gameObject.SetActive(false);
		break;

	case ButtonType.Text:
		text.gameObject.SetActive(true);	
		text.color= skinData.TextColor;
		icon.sprite = skinData.Texticon;
		break;
	}
	

	}}
//}