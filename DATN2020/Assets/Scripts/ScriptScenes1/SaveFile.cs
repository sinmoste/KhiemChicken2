using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveFile : MonoBehaviour
{
    public void createText()
    {
        string path = Application.dataPath + "/score.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "highScore \n \n");
        }
        int diem = PlayerPrefs.GetInt("highscore");
        string high = "\nDateTime: " + System.DateTime.Now + "\n High Score: " + diem + "\n";


        File.AppendAllText(path, high);
    }
    public void Start()
    {
        createText();
    }
}
