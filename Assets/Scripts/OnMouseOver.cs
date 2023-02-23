using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnMouseOver : MonoBehaviour
{
    public InstantiateObject gameManager;

    [SerializeField] TextMeshProUGUI emailTitle;
    [SerializeField] string emailTitleString;

    [SerializeField] TextMeshProUGUI emailBody;
    [SerializeField] string emailBodyString;

    public void OnCursorEnter()
    {
        emailTitle.text = emailTitleString;
        emailBody.text = emailBodyString;
    }
}
