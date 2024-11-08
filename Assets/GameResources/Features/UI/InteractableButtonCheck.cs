namespace Features.UI
{
    using Features.Parameters;
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Не дает взаимодействовать с кнопкой апгрейда при недостаточном балансе
    /// </summary>
    [RequireComponent(typeof(Button))]
    public class InteractableButtonCheck : MonoBehaviour
    {
        [SerializeField] private ParametersModel parametersModel = default;

        private void Start()
        {
            InteractionManage();
            parametersModel.onBalanceChanged += InteractionManage;
        }

        private void InteractionManage()
        {
            if (parametersModel.Balance >= parametersModel.UpgradePrice)
                GetComponent<Button>().interactable = true;
            else
                GetComponent<Button>().interactable = false;
        }
    }
}