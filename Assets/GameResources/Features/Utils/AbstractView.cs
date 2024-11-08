namespace Features.Utils
{
    using Features.Parameters;
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Абстрактный View
    /// </summary>
    public abstract class AbstractView : MonoBehaviour
    {
        [SerializeField] protected ParametersModel parametersModel = default;
        [SerializeField] protected Text textField = default;

        protected string parameter = default;
        protected string prefix = string.Empty;

        protected void OnEnable() => SubscribeOnEvent();

        protected void OnDisable() => UnSubscribeOnEvent();

        public abstract void SubscribeOnEvent();

        public abstract void UnSubscribeOnEvent();

        public abstract void ActionOnEvent();
    }
}
