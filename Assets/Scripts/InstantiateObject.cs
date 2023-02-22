using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField] private Transform position;
    [SerializeField] private GameObject[] objectsToInstantiate;
    [SerializeField] private Button[] buttons;
    private GameObject currentEmail;
    private Email email;

    [SerializeField] private Transform canvas;
    [SerializeField] private GameObject emailInfoPrefab;
    private GameObject currentEmailInfo = null;

    void Start()
    {
        InstantiateRandom();
        emailInfoPrefab.SetActive(false);
    }

    void Update()
    {

    }



    public void DisplayEmailInfo(string emailName, string emailContent, Vector2 buttonPos)
    {
        if(currentEmailInfo != null)
        {
            Destroy(currentEmailInfo.gameObject);
        }
        currentEmailInfo = Instantiate(emailInfoPrefab, buttonPos, Quaternion.identity, canvas);
        currentEmailInfo.GetComponent<EmailInfo>().SetUp(emailName, emailContent);
    }

    public void DestroyEmailInfo()
    {
        if(currentEmailInfo != null)
        {
            Destroy(currentEmailInfo.gameObject);
        }
    }

    public void OnCursorEnter()
    {
        emailInfoPrefab.SetActive(true);
    }

    public void OnCursorExit()
    {
        emailInfoPrefab.SetActive(false);
    }

    public void InstantiateRandom()
    {
        int n = UnityEngine.Random.Range(0, objectsToInstantiate.Length);
        GameObject newObject = Instantiate(objectsToInstantiate[n], position.position, objectsToInstantiate[n].transform.rotation);
        newObject.transform.SetParent(position);
    }

    public void AcceptCustomerEmail()
    {
        currentEmail = GameObject.Find("emailTemplate(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        Debug.Log("Next");
    }

    public void DenyCustomerEmail()
    {
        currentEmail = GameObject.Find("emailTemplate(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        Debug.Log("Next");
    }

    public void AcceptScamEmail()
    {
        currentEmail = GameObject.Find("emailTemplate Variant(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        Debug.Log("Next");
    }

    public void DenyScamEmail()
    {
        currentEmail = GameObject.Find("emailTemplate Variant(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        Debug.Log("Next");
    }
}