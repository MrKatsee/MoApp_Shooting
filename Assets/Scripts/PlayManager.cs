using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    private static PlayManager instance = null;
    public static PlayManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        StartCoroutine(EnemyRespawn());
    }

    public GameObject enemy;
    float score = 0f;
    public float Score
    {
        get { return score; }
        set { score = value; UIManager.Instance.SetScoreText((int)score); }
    }

    private void Update()
    {
        Score += Time.deltaTime;
    }

    IEnumerator EnemyRespawn()
    {
        while(true)
        {
            GameObject enemyInstance = Instantiate(enemy);
            enemyInstance.GetComponent<EnemyControl>().Init_Enemy();

            yield return new WaitForSeconds(1f);
        }

    }
}
