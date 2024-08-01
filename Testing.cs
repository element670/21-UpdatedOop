using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Testing : MonoBehaviour
{
    public List<Message> messages = new List<Message>();
    [SerializeField] private Transform parent;

    private int maxMessage = 3;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;

    [SerializeField] private ScrollController ScrollController;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendMessage("you pressed the button");
            Debug.Log("space");
        }
    }

    public void SendMessage(string text)
    {
        if (messages.Count >= maxMessage)
        {
            messages.Remove(messages[0]);
            Destroy(messages[0].textObject.gameObject);
        }
        _textMeshProUGUI.text = text;
        
        GameObject obj = Instantiate(_textMeshProUGUI.gameObject, transform.position, Quaternion.identity, parent);
    //    ScrollController.AddView(_textMeshProUGUI);
        Message message = new Message();
        message.textObject = obj;
        message.textObject.GetComponent<TextMeshProUGUI>().color = Color.red;
        messages.Add(message);
    }
}

[System.Serializable]
public class Message
{
    public GameObject textObject;
}