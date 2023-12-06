using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scorevalue = 10; //�ʏ�̃X�R�A�l
    private int bonusScoreValue = 20; //�{�[�i�X�X�R�A�l
    private bool isBonus = true;

    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {
        // �����܂ł̓{�[�i�X�^�C����2�b�҂�
        yield return new WaitForSeconds(bonusTime);
        isBonus = false;
        // �����鎞�Ԃ�5�b�Ȃ̂ŁA�{�[�i�X�^�C����2�b�����3�b�҂�
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
            // �R�C��������
            Destroy(gameObject);
        }
    }
}