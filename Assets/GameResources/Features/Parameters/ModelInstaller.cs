namespace Features.Parameters
{
    using UnityEngine;

    /// <summary>
    /// ������������� ������� �������� ��� ������ ��� ������� �����
    /// </summary>
    public class ModelInstaller : MonoBehaviour
    {
        [SerializeField] private ParametersModel parametersModel = default;

        private void Awake() => parametersModel.Reset();
    }
}