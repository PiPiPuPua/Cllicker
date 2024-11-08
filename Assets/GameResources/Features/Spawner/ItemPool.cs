namespace Features.Spawner
{
    using UnityEngine;

    /// <summary>
    /// Item Pool, ��������� ��� ��������� �������� �� ���� � �������
    /// </summary>
    public class ItemPool : MonoBehaviour
    {
        protected PoolSpawner spawner = default;

        /// <summary>
        /// ������������� 
        /// </summary>
        /// <param name="_spawner"></param>
        public void Init(PoolSpawner _spawner)
        {
            spawner = _spawner;
        }

        protected virtual void OnDisable()
        {
            if (spawner == null) return;
            spawner.ReturnToPool(this);
        }
    }
}
