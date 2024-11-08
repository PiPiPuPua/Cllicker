namespace Features.Parameters
{
    using UnityEngine;

    /// <summary>
    /// Устанавливает базовые значения для модели при запуске сцены
    /// </summary>
    public class ModelInstaller : MonoBehaviour
    {
        [SerializeField] private ParametersModel parametersModel = default;

        private void Awake() => parametersModel.Reset();
    }
}