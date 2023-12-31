using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class YarnVarStorage : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [Header("Shortcut for skipping Dialogue")]
    public bool ShortCut;
    [Header("When Goose Is ready, replace Current Goose with Gate Goose")]
    public WispEmotion wispEmotions; // Reference to the WispEmotions script
    public GameObject objectToDisable; // GameObject to disable
    public GameObject objectToEnable;  // GameObject to enable
    public int triggerValue = 50;        // The value to trigger the toggle
    private bool hasTriggered = false;   // To ensure the toggle happens only once
    [Header("Make cutting grass possible for Goose")]
    public GameObject GooseGrass;
    [Header("Destroy Gate Dialogue Trigger once opened and open gate")]
    public GameObject GateTrigger;
    public Animation GateAnimL;
    public Animation GateAnimR;
    [Header("Bool checks for Yarn Script")]
    public bool GateKey;
    public GameObject StrangeKey;
    public bool WhisperChat;
    public bool WhisperClue;
    public bool TinkerChat;
    public bool GateIsOpen;
    public bool VillemoChat;
    public bool VillemoClue;
    public bool TobyChat;
    public bool HaveNuts;
    public bool HaveCheese;
    public bool GooseCheese;
    public CutGrassMiniGame BramblesAreCut;
    public InMemoryVariableStorage variableStorage;
    



    void Update()
    {
        variableStorage.SetValue("$ShortCut", ShortCut);
        variableStorage.SetValue("$GooseGrass", GooseGrass);
        variableStorage.SetValue("$HaveGateKey", GateKey);
        variableStorage.SetValue("$WhisperChat", WhisperChat);
        variableStorage.SetValue("$WhisperClue", WhisperClue);
        variableStorage.SetValue("$TinkerChat", TinkerChat);
        variableStorage.SetValue("$GateIsOpen", GateIsOpen);
        variableStorage.SetValue("$VillemoChat", VillemoChat);
        variableStorage.SetValue("$VillemoClue", VillemoClue);
        variableStorage.SetValue("$TobyChat", TobyChat);
        variableStorage.SetValue("$HaveNuts", HaveNuts);
        variableStorage.SetValue("$HaveCheese", HaveCheese);
        variableStorage.SetValue("$GooseCheese", GooseCheese);
        variableStorage.SetValue("$BramblesAreCut", BramblesAreCut.BramblesAreCut);
        // Check if the trigger condition is met and has not yet triggered
        if (!hasTriggered && wispEmotions.currentHeart >= triggerValue)
        {
            // Enable/Disable the triggers
            if (objectToDisable != null)
                objectToDisable.SetActive(false);

            if (objectToEnable != null)
                objectToEnable.SetActive(true);

            hasTriggered = true; // Set the flag to prevent re-triggering
        }
    }

    [YarnCommand("StrangeKey")]
    public void FoundStrangeKey()
    // Update is called once per frame
    {
        GateKey = true;
        StrangeKey.SetActive(false);
    }

    [YarnCommand("WhisperChat")]
    public void Whisper()
    // Update is called once per frame
    {
        WhisperChat = true;
    }

    [YarnCommand("WhisperClue")]
    public void WhispersClue()
    // Update is called once per frame
    {
        WhisperClue = true;
    }

    [YarnCommand("TinkerChat")]
    public void Tinker()
    // Update is called once per frame
    {
        TinkerChat = true;
    }

    [YarnCommand("GateIsOpen")]
    public void OpenedGate()
    // Update is called once per frame
    {
        GateIsOpen = true;
        Destroy(GateTrigger);
        GateAnimL.Play();
        GateAnimR.Play();
    }

    [YarnCommand("VillemoChat")]
    public void Villemo()
    // Update is called once per frame
    {
        VillemoChat = true;
    }

    [YarnCommand("VillemoClue")]
    public void VillemoTip()
    // Update is called once per frame
    {
        VillemoClue = true;
    }

    [YarnCommand("TobyChat")]
    public void Toby()
    // Update is called once per frame
    {
        TobyChat = true;
    }

    [YarnCommand("GetNuts")]
    public void Nuts()
    // Update is called once per frame
    {
        HaveNuts = true;
    }

    [YarnCommand("GetCheese")]
    public void Cheese()
    // Update is called once per frame
    {
        HaveCheese = true;
    }

    [YarnCommand("GooseCheese")]
    public void GooseHasCheese()
    // Update is called once per frame
    {
        GooseCheese = true;
    }

    [YarnCommand("GooseGrass")]
    public void GooseCutGrass()
    // Update is called once per frame
    {
        GooseGrass.SetActive(true);
    }

    [YarnCommand("ShortCut")]
    public void ShortcutMe()
    // Update is called once per frame
    {
        ShortCut = true;
    }

    [YarnCommand("LoadMenu")]
    public void MenuLoad()
    // Update is called once per frame
    {
        SceneManager.LoadScene(sceneName);
    }
}
