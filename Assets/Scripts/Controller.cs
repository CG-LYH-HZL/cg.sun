using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour, Director.ISceneController
{

    // the first scripts
    void Awake()
    {
        Director director = Director.getInstance();
        director.setFPS(60);
        director.currentSceneController = this;
        director.currentSceneController.LoadResources();
    }
    Transform Sun;
    Transform Mercury;
    Transform Venus;
    Transform Earth;
    Transform Mars;
    Transform Jupiter;
    Transform Saturn;
    Transform Uranus;
    Transform Neptune;
    // Loading resources for first scence
    public void LoadResources()
    {
        Sun = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Sun"),
            new Vector3(0, 10, 0), Quaternion.identity);
        Mercury = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Mercury"),
            new Vector3(4, 10, 0), Quaternion.identity);
        Venus = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Venus"),
            new Vector3(7, 10, 0), Quaternion.identity);
        Earth = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Earth"),
            new Vector3(10, 10, 0), Quaternion.identity);
        Mars = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Mars"),
            new Vector3(15, 10, 0), Quaternion.identity);
        Jupiter = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Jupiter"),
            new Vector3(52, 10, 0), Quaternion.identity);
        Saturn = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Saturn"),
            new Vector3(96, 10, 0), Quaternion.identity);
        Uranus = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Uranus"),
            new Vector3(192, 10, 0), Quaternion.identity);
        Neptune = Instantiate<Transform>(
            Resources.Load<Transform>("prefabs/Neptune"),
            new Vector3(301, 10, 0), Quaternion.identity);

        //named the sphere
        Sun.name = "Sun";
        Mercury.name = "Mercury";
        Mercury.transform.parent = Sun.transform;
        Venus.name = "Venus";
        Venus.transform.parent = Sun.transform;
        Earth.name = "Earth";
        Earth.transform.parent = Sun.transform;
        Mars.name = "Mars";
        Mars.transform.parent = Sun.transform;
        Jupiter.name = "Jupiter";
        Jupiter.transform.parent = Sun.transform;
        Saturn.name = "Saturn";
        Saturn.transform.parent = Sun.transform;
        Uranus.name = "Uranus";
        Uranus.transform.parent = Sun.transform;
        Neptune.name = "Neptune";
        Neptune.transform.parent = Sun.transform;
    }

    // Use this for initialization
    void Start()
    {
        //give advice first
    }


    void Update()
    {
        Mercury.RotateAround(Sun.position, new Vector3(0, 1, 0), 5 * Time.deltaTime);
        Mercury.Rotate(Vector3.up * 100 * Time.deltaTime);
        Venus.RotateAround(Sun.position, new Vector3(0, 1, 0), 8 * Time.deltaTime);
        Venus.Rotate(Vector3.up * 100 * Time.deltaTime);
        Earth.RotateAround(Sun.position, new Vector3(0, 1, 0), 10 * Time.deltaTime);
        Earth.Rotate(Vector3.up * 100 * Time.deltaTime);
        Mars.RotateAround(Sun.position, new Vector3(0, 1, 0), 14 * Time.deltaTime);
        Mars.Rotate(Vector3.up * 100 * Time.deltaTime);
        Jupiter.RotateAround(Sun.position, new Vector3(0, 1, 0), 15 * Time.deltaTime);
        Jupiter.Rotate(Vector3.up * 100 * Time.deltaTime);
        Saturn.RotateAround(Sun.position, new Vector3(0, 1, 0), 16 * Time.deltaTime);
        Saturn.Rotate(Vector3.up * 100 * Time.deltaTime);
        Uranus.RotateAround(Sun.position, new Vector3(0, 1, 0), 17 * Time.deltaTime);
        Uranus.Rotate(Vector3.up * 100 * Time.deltaTime);
        Neptune.RotateAround(Sun.position, new Vector3(0, 1, 0), 18 * Time.deltaTime);
        Neptune.Rotate(Vector3.up * 100 * Time.deltaTime);
    }

    public void Pause()
    {

    }

    public void Resume()
    {

    }
}