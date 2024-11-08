namespace Features.UI
{
    using Features.Parameters;
    using UnityEngine;

    /// <summary>
    /// ������ � ���� �������� ���������� ������� �������� ������ �����
    /// </summary>
    public class SetYBound : MonoBehaviour
    {
        [SerializeField] private ParametersModel parametersModel = default;

        private void Awake() => parametersModel.YBound = gameObject.transform.position.y;
    }
}
