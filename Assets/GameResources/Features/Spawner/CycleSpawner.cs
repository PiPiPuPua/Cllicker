namespace Features.Spawner
{
    using System.Collections;
    using UnityEngine;

    /// <summary>
    /// Цикличный спавнер 
    /// </summary>
    public class CycleSpawner : BaseSpawner
    {
        [SerializeField, Min(0)] protected float time = 1.0f;

        protected override void Start()
        {
            base.Start();
            if (isAutoSpawn)
            {
                StartCoroutine(CycleSpawnRoutine());
            }
        }

        protected IEnumerator CycleSpawnRoutine()
        {
            while (isActiveAndEnabled)
            {
                yield return new WaitForSeconds(time);
                Spawn();
            }
        }
    }
}
