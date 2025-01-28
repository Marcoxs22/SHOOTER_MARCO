using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulllet;
    [SerializeField]
    private Transform _bulletPivot;

    public void Shoot()
    {
        GameObject.Instantiate(_bulllet, _bulletPivot.position, _bulletPivot.rotation);
    }
}