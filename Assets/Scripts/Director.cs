using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : System.Object
{

    //singlton instance
    private static Director _instance;

    public ISceneController currentSceneController { get; set; }

    // get instance anytime anywhere!
    public static Director getInstance()
    {
        if (_instance == null)
        {
            _instance = new Director();
        }
        return _instance;
    }

    public int getFPS()
    {
        return Application.targetFrameRate;
    }

    public void setFPS(int fps)
    {
        Application.targetFrameRate = fps;
    }


    public interface ISceneController
    {
        void LoadResources();
        void Pause();
        void Resume();
    }
}