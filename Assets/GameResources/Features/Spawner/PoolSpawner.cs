namespace Features.Spawner
{
    using System.Collections.Generic;
    using UnityEngine;
    using Utils;

    /// <summary>
    /// ��� �������
    /// </summary>
    public class PoolSpawner : CycleSpawner
    {
        [SerializeField] protected List<ItemPool> items = new List<ItemPool>();
        [SerializeField, Min(0)] protected int countPrewarm = 3;
        protected ItemPool tempItem = default;

        /// <summary>
        /// �������� ���������� ����������������� ������, ������� ��� ������ � Awake, ������� �������� ��� ��� ������
        /// </summary>
        /// <param name="_newPrewarm"></param>
        public void ChangePrewarm(int _newPrewarm) => countPrewarm = _newPrewarm;

        protected override void Start()
        {
            for (int i = 0; i < countPrewarm; i++)
            {
                base.Spawn();
                tempItem = LastSpawnedObject.GetComponent<ItemPool>();
                tempItem.Init(this);
                tempItem.gameObject.SetActive(false);
            }
            base.Start();
        }

        /// <summary>
        /// ����� � ������� ����
        /// </summary>
        [ContextMenu("Test Spawn")]
        public override void Spawn()
        {
            if (items.Count <= 0)
            {
                base.Spawn();
                ItemPool itemPool = LastSpawnedObject.GetComponent<ItemPool>();
                itemPool.Init(this);
            }
            else
            {
                items[items.Count - 1].gameObject.SetActive(true);
                items[items.Count - 1].gameObject.ResetLocalPosition(gameObject);
                lastSpawnedObject = items[items.Count - 1].gameObject;
                items.RemoveAt(items.Count - 1);
            }
        }

        public override void Spawn(Transform spawnPoint)
        {
            Spawn();
            lastSpawnedObject.ResetLocalPosition(spawnPoint.gameObject);
        }

        /// <summary>
        /// ������� � ���
        /// </summary>
        /// <param name="itemPool"></param>
        public void ReturnToPool(ItemPool itemPool)
        {
            items.Add(itemPool);
            itemPool.gameObject.SetActive(false);
        }
    }
}
