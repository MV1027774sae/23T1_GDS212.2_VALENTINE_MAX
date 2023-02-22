using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EmailInfo : MonoBehaviour
{
    public TextMeshProUGUI emailName;
    public TextMeshProUGUI emailContent;

    public void SetUp(string name, string content)
    {
        emailName.text = name;
        emailContent.text = content;
    }
}
