namespace Features.UI
{
    using Features.Utils;

    /// <summary>
    /// Отображение баланса игрока
    /// </summary>
    public class BalanceView : AbstractView
    {
        private void Start() => ActionOnEvent();

        public override void SubscribeOnEvent() => parametersModel.onBalanceChanged += ActionOnEvent;

        public override void UnSubscribeOnEvent() => parametersModel.onBalanceChanged -= ActionOnEvent;

        public override void ActionOnEvent()
        {
            parameter = parametersModel.Balance.ToString();
            textField.text = prefix + ' ' + parameter;
        }
    }
}