using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UsernameUI : MonoBehaviour
{
    public TextMeshProUGUI usernameText;



   private const string GuestUsernameKey = "GuestUsername";

    private void Start()
    {
        usernameText.text = GetGuestUsername();
        // Debug.Log("Guest Username: " + guestUsername);
    }

    string GetGuestUsername()
    {
        // Check if the guest username is already stored in PlayerPrefs
        if (PlayerPrefs.HasKey(GuestUsernameKey))
        {
            return PlayerPrefs.GetString(GuestUsernameKey);
        }
        else
        {
            // Generate a new guest username
            int randomPart = Random.Range(10000, 100000);
            string guestUsername = "guest_" + randomPart.ToString();

            // Store the generated username in PlayerPrefs
            PlayerPrefs.SetString(GuestUsernameKey, guestUsername);
            PlayerPrefs.Save();

            return guestUsername;
        }
    }
}
