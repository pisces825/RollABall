using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletShooter : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    private Rigidbody shooterRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        shooterRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // �v���C���[(Sphere)�̌������擾����
            Vector3 movingDirection = shooterRigidBody.velocity.normalized;
            // �e�̃C���X�^���X�𐶐����A�ʒu�Ɖ�]���V���[�^�[�Ɠ����ɐݒ肵�܂��B
            var bulletInstance = Instantiate(bulletPrefab, transform.position + movingDirection * 1.5f, transform.rotation);
            // �e�ɑO�����ɑ��x�������܂��B
            var bulletRigidBody = bulletInstance.GetComponent<Rigidbody>();
            if (bulletRigidBody != null)
            {
                bulletRigidBody.velocity = movingDirection * bulletSpeed;
            }
        }
    }
}