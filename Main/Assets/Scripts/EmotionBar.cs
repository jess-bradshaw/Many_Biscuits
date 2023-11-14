using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxHeart(int heart)
	{
		slider.maxValue = heart;
		slider.value = heart;

		fill.color = gradient.Evaluate(1f);
	}

	public void SetHeart(int heart)
	{
		slider.value = heart;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}



}
