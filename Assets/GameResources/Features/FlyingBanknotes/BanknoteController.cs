namespace Features.FlyingBanknotes
{
    using Features.Parameters;
    using Features.Spawner;
    using UnityEngine;

    /// <summary>
    /// Обращается к Spawner'y при необходимости заспавнить банкноты
    /// </summary>
    public class BanknoteController : MonoBehaviour
    {
        [SerializeField] private ParametersModel parametersModel = default;
        private PoolSpawner spawner;

        private void Start()
        {
            gameObject.TryGetComponent(out spawner);
            parametersModel.onFarmButtonClicked += spawner.Spawn;
        }
    }
}