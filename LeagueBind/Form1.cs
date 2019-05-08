using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace LeagueBind
{
    public partial class Form1 : Form
    {
        string LoLPath = @"C:\Riot Games\League of Legends\";
        string settingsPath;
        JObject jsonFile;
        List<string> checkedItems = new List<string>();
        string newValue = "[Ctrl][6]";
        string emoteEvt = "evtChampMasteryDisplay";

        public Form1()
        {
            InitializeComponent();

            directoryText.Text = LoLPath;
            settingsPath = LoLPath + @"\Config\PersistedSettings.json";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(settingsPath))
            {
                checkedItems = bindList.CheckedItems.Cast<string>().ToList();
                string tempValue = newValue;
                foreach (string value in checkedItems)
                {
                    newValue += "," + value;
                }

                jsonFile = LoadAsJson(settingsPath);

                JToken settings = jsonFile["files"][1]["sections"][0]["settings"];
                JObject settingsObject = jsonFile["files"][1]["sections"][0]["settings"] as JObject;

                bool existsEmote = false;

                for (int i = 0; i < settings.Count(); i++)
                {
                    if (settings[i]["name"].ToString() == emoteEvt && checkedItems.Count > 0)
                    {


                        settings[i]["value"] = newValue;
                        existsEmote = true;
                    }
                }

                if (existsEmote == false)
                {

                    JArray jo = jsonFile["files"][1]["sections"][0]["settings"] as JArray;
                    JObject emote = JObject.Parse(@"{""name"": ""evtChampMasteryDisplay"",""value"": ""[Ctrl][6]""}");
                    emote["name"] = emoteEvt;
                    emote["value"] = newValue;

                    jo.Add(emote);
                }

                File.WriteAllText(settingsPath, jsonFile.ToString());

                feedbackLabel.Text = "Key successfully bound!";
                newValue = tempValue;
            }
            else
            {
                feedbackLabel.Text = "LoL directory not found!";
            }
        }

        private JObject LoadAsJson(string filepath)
        {
            using (StreamReader r = new StreamReader(filepath))
            {
                string json = r.ReadToEnd();
                JObject o = JObject.Parse(json);
                return o;
            }
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == directoryBrowser.ShowDialog())
            {
                LoLPath = directoryBrowser.SelectedPath;
                directoryText.Text = LoLPath;
            }
        }

        private void directoryText_TextChanged(object sender, EventArgs e)
        {
            LoLPath = directoryText.Text;
            settingsPath = LoLPath + @"\Config\PersistedSettings.json";
        }

        private void MasteryEmote_CheckedChanged(object sender, EventArgs e)
        {
            newValue = "[Ctrl][6]";
            emoteEvt = "evtChampMasteryDisplay";
        }

        private void DanceEmote_CheckedChanged(object sender, EventArgs e)
        {
            newValue = "[Ctrl][3]";
            emoteEvt = "evtEmoteDance";
        }
        private void LaughEmote_CheckedChanged(object sender, EventArgs e)
        {
            newValue = "[Ctrl][4]";
            emoteEvt = "evtEmoteLaugh";
        }
        private void TauntEmote_CheckedChanged(object sender, EventArgs e)
        {
            newValue = "[Ctrl][2]";
            emoteEvt = "evtEmoteTaunt";
        }
        private void JokeEmote_CheckedChanged(object sender, EventArgs e)
        {
            newValue = "[Ctrl][1]";
            emoteEvt = "evtEmoteJoke";
        }
    }
}
