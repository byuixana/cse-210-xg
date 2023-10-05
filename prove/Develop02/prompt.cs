using System.Collections.Generic;


public class Prompt
{
    string[] prompts = {
        "What helped you feel the Spirit today?",
        "How did you see the hand of God in your life today?",
        "What was the best conversation you had today?",
        "Was there a particular scripture that stood out to you in your study today? Write about why.",
        "What was a difficult trial you overcame or worked towards overcoming today?"
    };

    public string GetPrompt()
    {
        Random randomPrompt = new Random();
        int randomPromptIndex = randomPrompt.Next(prompts.Length);
        string promptGotten = prompts[randomPromptIndex];
        return promptGotten;



    }
}