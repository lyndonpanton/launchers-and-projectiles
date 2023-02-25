using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A spawner for launcher game objects
/// </summary>
public class LauncherSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabChainsawLauncher;

    [SerializeField]
    GameObject prefabPirateLauncher;

    [SerializeField]
    GameObject prefabZombieLauncher;

    GameObject currentLauncher;

    Timer launcherSpawner;

    int runCount;
    bool spawnedAll = false;

    // Start is called before the first frame update
    void Start()
    {
        launcherSpawner = GetComponent<Timer>();
        launcherSpawner.Duration = 5;
        launcherSpawner.Run();
        runCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (launcherSpawner.Finished && !spawnedAll)
        {
            launcherSpawner.Run();
            
            switch(runCount)
            {
                case 1:
                    currentLauncher = Instantiate(prefabChainsawLauncher);
                    break;
                case 2:
                    Destroy(currentLauncher);
                    currentLauncher = Instantiate(prefabPirateLauncher);
                    break;
                case 3:
                    Destroy(currentLauncher);
                    currentLauncher = Instantiate(prefabZombieLauncher);
                    break;
                case 4:
                    Destroy(currentLauncher);
                    spawnedAll = true;
                    break;
                default:
                    break;
            }

            runCount++;
        }
    }
}
