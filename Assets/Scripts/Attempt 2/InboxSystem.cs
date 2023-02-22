using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InboxSystem : MonoBehaviour
{
    private Dictionary<EmailScriptableObject, EmailObject> m_inboxDictionary;
    public List<EmailObject> inbox { get; private set; }

    public void Awake()
    {
        inbox = new List<EmailObject>();
        m_inboxDictionary = new Dictionary<EmailScriptableObject, EmailObject>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
        }
    }

    public void Add(EmailScriptableObject referenceData)
    {
        if(m_inboxDictionary.TryGetValue(referenceData, out EmailObject value))
        {
            value.AddToStack();
        }
        else
        {
            EmailObject newMail = new EmailObject(referenceData);
            inbox.Add(newMail);
            m_inboxDictionary.Add(referenceData, newMail);
        }
    }

    public void Remove(EmailScriptableObject referenceData)
    {
        if(m_inboxDictionary.TryGetValue(referenceData, out EmailObject value))
        {
            value.RemoveFromStack();

            if (value.stackSize == 0)
            {
                inbox.Remove(value);
                m_inboxDictionary.Remove(referenceData);

            }
        }
    }
}
