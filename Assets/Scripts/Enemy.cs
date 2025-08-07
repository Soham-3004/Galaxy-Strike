using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyShipVFX;
    [SerializeField] int hitPoints = 2;
    [SerializeField] int scoreValue = 10;

    ScoreBoard scoreBoard;

    private void Start()
    {
        scoreBoard = FindFirstObjectByType<ScoreBoard>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        --hitPoints;

        if (hitPoints <= 0)
        {
            scoreBoard.IncreaseScore(scoreValue);
            Instantiate(destroyShipVFX, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
