using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InboxList
{
    public event EventHandler OnEmailListChanged;
    private List<Email> emailList;

    public InboxList()
    {
        emailList = new List<Email>();
        Debug.Log("Inbox");

        AddEmail(new Email { emailType = Email.EmailType.Customer1, amount = 1 });
        AddEmail(new Email { emailType = Email.EmailType.Customer2, amount = 1 });
        AddEmail(new Email { emailType = Email.EmailType.Customer3, amount = 1 });
        AddEmail(new Email { emailType = Email.EmailType.Customer4, amount = 1 });
        AddEmail(new Email { emailType = Email.EmailType.Scam1, amount = 1 });
        AddEmail(new Email { emailType = Email.EmailType.Scam2, amount = 1 });
        Debug.Log(emailList.Count);
    }

    public void AddEmail(Email email)
    {
        emailList.Add(email);
        OnEmailListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Email> GetEmailList()
    {
        return emailList;
    }
}
