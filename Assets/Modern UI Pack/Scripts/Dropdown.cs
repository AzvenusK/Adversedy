using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour {

	[Header("ANIMATORS")]
	public Animator dropdownAnimator;

	[Header("OBJECTS")]
	public GameObject fieldTrigger;
	public Text selectedText;
	public Image selectedImage;

	[Header("SETTINGS")]
	[Tooltip("IMPORTANT! EVERY DORPDOWN MUST HAVE A DIFFERENT ID")]
	public string DropdownID = "0";

	//public bool darkTrigger = true;

	private bool isOn;
	private string inAnim = "In";
	private string outAnim = "Out";

	private string sText;
	private string sImage;

	void Start ()
	{
		sText = PlayerPrefs.GetString (DropdownID + "SelectedText");
		sImage = PlayerPrefs.GetString (DropdownID + "SelectedImage");

		selectedText.text = sText;
	//	selectedImage.sprite = 
	}

	public void Animate ()
	{
		if (isOn == true) 
		{
			dropdownAnimator.Play (outAnim);
			isOn = false;
			fieldTrigger.SetActive (false);
		}

		else
		{
			dropdownAnimator.Play (inAnim);
			isOn = true;
			fieldTrigger.SetActive (true);
		}
	}

    internal void OnPointerClick(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    internal void OnSubmit(BaseEventData eventData)
    {
        throw new NotImplementedException();
    }
}
