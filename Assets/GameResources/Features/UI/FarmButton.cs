namespace Features.UI
{
    using UnityEngine.UI;
    using UnityEngine;
    using Features.Utils;
    using Features.Parameters;

    /// <summary>
    /// Основная кнопка кликера
    /// </summary>
    [RequireComponent(typeof(Button))]
    public class FarmButton : AbstractButton
    {
        [SerializeField] private ParametersModel parametersModel = default;

        protected override void OnButtonClicked() => parametersModel.Balance += parametersModel.IncomePerClick;
    }
}