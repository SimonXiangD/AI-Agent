using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using TMPro;

public class AgentMain : MonoBehaviour
{
    public TMP_InputField inputBox;
    public TMP_Text outputBox;
    // Start is called before the first frame update
    void Start()
    {
        // init agent, but currently not available...
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sendText() {
        StartCoroutine("sendTextToAgent");
    }
    IEnumerator sendTextToAgent() {
        if (string.IsNullOrEmpty(inputBox.text) == false)
        {
            // Response Bot AIML
            var answer = "You have typed: ";
            var inputText = inputBox.text;

            inputBox.text = string.Empty;

            outputBox.text = ("Typing.");
            yield return new WaitForSeconds(0.3f);
            outputBox.text = ("Typing..");
            yield return new WaitForSeconds(0.6f);
            outputBox.text = ("Typing...");
            yield return new WaitForSeconds(0.9f);

            // Response BotAIml in the Chat window
            outputBox.text = answer + inputText; 
        }
    }
}
