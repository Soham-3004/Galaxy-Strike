using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject playerDestroyedVFX;
    GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(playerDestroyedVFX, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        gameSceneManager.ReloadLevel();
    }
}
