namespace Features.Parameters
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Данные о прогрессе игрока
    /// </summary>
    [CreateAssetMenu(fileName = "New ParametersModel", menuName = "Features/Player/ParametersModel")]
    public sealed class ParametersModel : ScriptableObject
    {
        public event Action onBalanceChanged = delegate { };
        public event Action onIncomePerClickChanged = delegate { };
        public event Action onLevelChanged = delegate { };
        public event Action onUpgradePriceChanged = delegate { };
        public event Action onFarmButtonClicked = delegate { };

        public float YBound = default;

        [SerializeField, Min(0)] private int balance = default;
        [SerializeField, Min(1)] private int incomePerClick = default;
        [SerializeField, Min(1)] private int level = default;
        [SerializeField, Min(1)] private int upgradePrice = default;

        private float baseUpgradePrice = 100f;
        private float costMultiplier = 2f;

        private float baseClickIncome = 10f;
        private float clickIncomeMultiplier= 3f;


        public int Balance
        {
            get => balance;
            set
            {
                if (balance != value && value >= 0)
                {
                    if (value > balance)
                        onFarmButtonClicked();

                    balance = value;
                    onBalanceChanged();
                }
            }
        }

        public int IncomePerClick
        {
            get => incomePerClick;
            set
            {
                if (incomePerClick != value && value >= 1)
                {
                    incomePerClick = value;
                    onIncomePerClickChanged();
                }
            }
        }

        public int UpgradePrice
        {
            get => upgradePrice;
            set
            {
                if (upgradePrice < value)
                {
                    upgradePrice = value;
                    onUpgradePriceChanged();
                }
            }
        }

        public int Level
        {
            get => level;
            set
            {
                if (level < value)
                {
                    level = value;
                    onLevelChanged();
                }
            }
        }

        public void LevelUp()
        {
            if (Balance >= UpgradePrice)
            {
                Balance -= UpgradePrice;
                Level++;
                UpgradePrice = UpgradePriceByLevel();
                IncomePerClick = IncomePerClickByLevel();
            }
        }

        public void Reset()
        {
            level = 1;
            incomePerClick = 10;
            upgradePrice = 100;
            balance = 0;
        }

        private int UpgradePriceByLevel() => (int)(baseUpgradePrice * Mathf.Pow(costMultiplier, level));
        private int IncomePerClickByLevel() => (int)(baseClickIncome * Mathf.Pow(clickIncomeMultiplier, level));
    }
}
