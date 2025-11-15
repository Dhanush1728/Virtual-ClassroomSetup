using UnityEngine;
using TMPro;

public class ChatManager : MonoBehaviour
{
    public TMP_InputField questionInput;
    public Transform chatContent;
    public GameObject chatMessagePrefab;

    public void AskQuestion()
    {
        string question = questionInput.text;
        if (!string.IsNullOrEmpty(question))
        {
            // Show user question
            GameObject msg = Instantiate(chatMessagePrefab, chatContent);
            msg.GetComponent<TMP_Text>().text = "You: " + question;
            questionInput.text = "";

            // Get reply
            string answer = GetSimpleReply(question);

            // Show AI reply
            GameObject response = Instantiate(chatMessagePrefab, chatContent);
            response.GetComponent<TMP_Text>().text = "TUTOR: " + answer;
        }
    }

    // Simple rule-based reply generator
    private string GetSimpleReply(string input)
    {
        input = input.ToLower();

        if (input.Contains("hi") || input.Contains("hello"))
            return "Hello! Nice to meet you.";

        else if (input.Contains("morning"))
            return "Good morning! Have a great day ahead.";

        else if (input.Contains("evening"))
            return "Good evening! How was your day?";

        else if (input.Contains("how are you"))
            return "I'm doing great!";

        else if (input.Contains("what is your name"))
            return "I'm your classroom chatbot.";

        else if (input.Contains("bye"))
            return "Goodbye! See you later.";

        else if (input.Contains("help"))
            return "I can respond to greetings like 'hi', 'good morning', 'how are you', and so on.";

        else if (input.Contains("thank"))
            return "You're welcome!";

        // default reply
        return "I don’t know the answer yet.";
    }
}
