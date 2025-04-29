
namespace Elektrarna.Models
{
    public class ChargingLoad
    {
        public float ChargingPowerKw { get; private set; }
        public float ChargingCapacityKw { get; private set; }
        public float ChargingStateKwh { get; private set; }

        public event EventHandler<float> ChargingStateChanged;
        public event EventHandler FullyCharged;

        public ChargingLoad(float chargingPowerKw, float capacity, float initState)
        {
            ChargingPowerKw = chargingPowerKw;
            ChargingCapacityKw = capacity;
            ChargingStateKwh = initState;
        }

        public void Charged(float v)
        {
            if (ChargingStateKwh + v <= ChargingCapacityKw)
            {
                ChargingStateKwh += v;
                ChargingStateChanged?.Invoke(this, ChargingStateKwh / ChargingCapacityKw);
            }
            else
            {
                Task.Run(() =>
                    FullyCharged?.Invoke(this, EventArgs.Empty));
            }
        }
    }
}