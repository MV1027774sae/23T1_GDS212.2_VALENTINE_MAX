using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailObject
{
    public EmailScriptableObject data { get; private set; }
    public int stackSize { get; private set; }

    public EmailObject(EmailScriptableObject source)
    {
        data = source;
        AddToStack();
    }

    public void AddToStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }

    public void OnHandleAddEmail()
    {
        //InboxSystem.current.Add(refer)
    }
}
