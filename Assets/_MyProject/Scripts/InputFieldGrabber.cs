using TMPro;
using UnityEngine;

public class InputFieldGrabber : MonoBehaviour
{
    [Header("The value grabbed from the input field")]
    [SerializeField] string _inputText;

    [Header("Showing reaction to player")]
    [SerializeField] TMP_Text _reactionTextBox;
    [SerializeField] GameObject _reactionGroup;

    public void GrabFromInputField(string input)
    {
        _inputText = input;
        DisplayReactionToInput();
    }

    private void DisplayReactionToInput()
    {
        if (_reactionTextBox == null || _reactionGroup == null) return;
        
        _reactionTextBox.text = _inputText;
        _reactionGroup.SetActive(true);
    }
}
