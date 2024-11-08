namespace Features.Spawner
{
    using UnityEngine;
    using Utils;

    /// <summary>
    /// ������� ������� �������
    /// </summary>
    public class BaseSpawner : MonoBehaviour
    {
        public GameObject Prefab => prefab;
        public GameObject LastSpawnedObject => lastSpawnedObject;

        public string IdSpawner => idSpawner;

        [SerializeField] protected GameObject prefab = default;
        [SerializeField] protected bool isAutoSpawn = default;
        [SerializeField] protected string idSpawner = string.Empty;
        protected GameObject lastSpawnedObject = default;

        protected virtual void Start()
        {
            if (isAutoSpawn)
            {
                Spawn();
            }
        }

        /// <summary>
        /// �����
        /// </summary>
        public virtual void Spawn()
        {
            lastSpawnedObject = Instantiate(prefab, transform.position, Quaternion.identity);
            lastSpawnedObject.ResetLocalPosition(gameObject);
        }

        /// <summary>
        /// ��������� ����� � ���������� �����
        /// </summary>
        /// <param name="spawnPoint"></param>
        public virtual void Spawn(Transform spawnPoint) => lastSpawnedObject = Instantiate(prefab, spawnPoint);
    }
}
