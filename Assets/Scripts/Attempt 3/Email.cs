using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Email
{
    public enum EmailType
    {
        Customer1,
        Customer2,
        Customer3,
        Customer4,
        Scam1,
        Scam2,
    }

    public EmailType emailType;
    public int amount;
}
