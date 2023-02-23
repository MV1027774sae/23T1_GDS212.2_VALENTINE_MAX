using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailNew : MonoBehaviour
{
    // We want two lists (each to be picked from randomly):
    // - Customer Name
    // - Email body text

    [SerializeField] private string[] customerNames =
    {
        "Steve",
        "Sarah"
    };

    [SerializeField]
    private string[] emailBodyTextNormal =
    {
        "Hi! I am late for work.",
        "Hi this is a real email"
    };

    [SerializeField]
    private string[] emailBodyTextSpam =
    {
        "Hi! This is SPPPPAAAAMMMMM",
        "Hellothisisarealemailhahahaha"
    };

    [SerializeField] string spamTextToAppendToEmail = "SPPPAAMMM";

    [SerializeField] private string currentCustomer;
    [SerializeField] private string currentEmailBodyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
