using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField] private Transform position;
    [SerializeField] private GameObject[] objectsToInstantiate;
    private GameObject currentEmail;

    [SerializeField] private Transform canvas;
    [SerializeField] private GameObject emailInfoPrefab;
    private GameObject currentEmailInfo = null;

    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreTMP;
    [SerializeField] private string scoreString;

    void Start()
    {
        InstantiateRandom();
        emailInfoPrefab.SetActive(false);
    }

    //public void DisplayEmailInfo(string emailName, string emailContent, Vector2 buttonPos)
    //{
        //if(currentEmailInfo != null)
        //{
            //Destroy(currentEmailInfo.gameObject);
        //}
        //currentEmailInfo = Instantiate(emailInfoPrefab, buttonPos, Quaternion.identity, canvas);
        //currentEmailInfo.GetComponent<EmailInfo>().SetUp(emailName, emailContent);
    //}

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
        newObject.GetComponent<OnMouseOver>().gameManager = this;
    }

    private void IncreaseScore()
    {
        score++;
        scoreString = score.ToString();
        scoreTMP.text = scoreString;
    }

    private void DecreaseScore()
    {
        score--;
        scoreString = score.ToString();
        scoreTMP.text = scoreString;
    }

    public void AcceptCustomerEmail1()
    {
        currentEmail = GameObject.Find("EmailCustomer1(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }

    public void DenyCustomerEmail1()
    {
        currentEmail = GameObject.Find("EmailCustomer1(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }

    public void AcceptCustomerEmail2()
    {
        currentEmail = GameObject.Find("EmailCustomer2(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }

    public void DenyCustomerEmail2()
    {
        currentEmail = GameObject.Find("EmailCustomer2(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }
    public void AcceptCustomerEmail3()
    {
        currentEmail = GameObject.Find("EmailCustomer3(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }

    public void DenyCustomerEmail3()
    {
        currentEmail = GameObject.Find("EmailCustomer3(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }
    public void AcceptCustomerEmail4()
    {
        currentEmail = GameObject.Find("EmailCustomer4(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }

    public void DenyCustomerEmail4()
    {
        currentEmail = GameObject.Find("EmailCustomer4(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }

    public void AcceptScamEmail1()
    {
        currentEmail = GameObject.Find("EmailScam1(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }

    public void DenyScamEmail1()
    {
        currentEmail = GameObject.Find("EmailScam1(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }
    public void AcceptScamEmail2()
    {
        currentEmail = GameObject.Find("EmailScam2(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }

    public void DenyScamEmail2()
    {
        currentEmail = GameObject.Find("EmailScam2(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }
    public void AcceptScamEmail3()
    {
        currentEmail = GameObject.Find("EmailScam3(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }

    public void DenyScamEmail3()
    {
        currentEmail = GameObject.Find("EmailScam3(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }
    public void AcceptScamEmail4()
    {
        currentEmail = GameObject.Find("EmailScam4(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        DecreaseScore();
        Debug.Log("Incorrect");
    }

    public void DenyScamEmail4()
    {
        currentEmail = GameObject.Find("EmailScam4(Clone)");
        Destroy(currentEmail.gameObject);
        InstantiateRandom();
        IncreaseScore();
        Debug.Log("Correct");
    }
}