using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInbox : MonoBehaviour
{
    private InboxList inboxList;
    private Transform emailContainer;
    private Transform emailTemplate;
    public Email email;
    //private int x = 0;
    //private int y = 0;
    public GameObject emailContainerGO;
    public GameObject emailTemplateGO;


    private void Awake()
    {
        emailContainer = transform.Find("emailContainer");
        emailTemplate = emailContainer.Find("emailTemplate");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(emailTemplate, emailContainer);
            Debug.Log("Added");

            RefreshInboxEmails();
        }
    }

    public void SetInbox(InboxList inboxList)
    {
        this.inboxList = inboxList;

        inboxList.OnEmailListChanged += Inbox_OnEmailListChanged;
        RefreshInboxEmails();
    }

    private void Inbox_OnEmailListChanged(object sender, System.EventArgs e)
    {
        RefreshInboxEmails();
    }

    private void RefreshInboxEmails()
    {
        //foreach (Transform child in emailContainer)
        {
            //if (child == emailTemplate) continue;
            //Destroy(child.gameObject);
        }

        
        //float emailSlotCellSize = 55f;
        //foreach (Email email in inboxList.GetEmailList())
        {
            //RectTransform emailSlotRectTransform = Instantiate(emailTemplate, emailContainer).GetComponent<RectTransform>();
            //emailSlotRectTransform.gameObject.SetActive(true);

            //emailSlotRectTransform.anchoredPosition = new Vector2(x * emailSlotCellSize, y * emailSlotCellSize);
            //x++;
            //if (x > 0)
            {
                //x = 0;
                //y--;
            }
        }
    }

    public void DeleteMail()
    {
        //inboxList.RemoveEmail(email);
    }

    public void RemoveEmail(Email email)
    {
        //inboxList.Remove(email);
        //Inbox_OnEmailListChanged?.Invoke(this, EventArgs.Empty);
    }
}
