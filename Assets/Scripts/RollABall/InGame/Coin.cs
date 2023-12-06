using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scorevalue = 10; //通常のスコア値
    private int bonusScoreValue = 20; //ボーナススコア値
    private bool isBonus = true;

    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {
        // ここまではボーナスタイムの2秒待つ
        yield return new WaitForSeconds(bonusTime);
        isBonus = false;
        // 消える時間は5秒なので、ボーナスタイムを2秒消費した3秒待つ
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }

    //
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (isBonus)
            {
                ScoreManager.ScoreCount += bonusScoreValue;
            }
            else
            {
                ScoreManager.ScoreCount += scorevalue;
            }
            // コインを消去
            Destroy(gameObject);
        }
    }
}