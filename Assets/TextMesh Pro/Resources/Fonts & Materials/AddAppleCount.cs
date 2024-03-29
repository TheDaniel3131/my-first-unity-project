using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddAppleCount : MonoBehaviour
{
    public TextMeshProUGUI textNumberCount;
    int count;

    public void ButtonPressed()
    {
        count++;
        textNumberCount.text = count + "";
    }
}
