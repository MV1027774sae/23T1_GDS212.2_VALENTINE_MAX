using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InboxList inboxList;
    [SerializeField] private UIInbox uiInbox;

    private void Awake()
    {
        //inboxList = new InboxList();
        //uiInbox.SetInbox(inboxList);
    }
}