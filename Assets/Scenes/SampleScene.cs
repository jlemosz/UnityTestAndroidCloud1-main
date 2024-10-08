using System;
using Immutable.Passport;
using UnityEngine;
using UnityEngine.UI;
using Environment = Immutable.Passport.Model.Environment;

public class SampleScene : MonoBehaviour
{
    [SerializeField] private Text m_Text;

    private async void Start()
    {
        try
        {
            m_Text.text = "Logging in...";

            var clientId = "ZJL7JvetcDFBNDlgRs5oJoxuAUUl6uQj";
            var environment = Environment.SANDBOX;

            var passport = await Passport.Init(clientId, environment/*, "imxsample://callback"*/,
                logoutRedirectUri: "imxsample://callback/logout");
            await passport.Login();

            m_Text.text = "Done!";
        }
        catch (Exception ex)
        {
            Debug.Log($"Error: {ex.Message}");
            m_Text.text = ex.Message;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}