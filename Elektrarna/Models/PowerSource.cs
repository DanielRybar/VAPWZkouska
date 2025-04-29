namespace Elektrarna.Models
{
    public class PowerSource
    {
        public float PowerCapacityKw { get; private set; }
        public float PowerConsumedKwh { get; private set; }
        public int LoadCount => _loads.Count;

        private readonly List<ChargingLoad> _loads = [];

        public PowerSource(float powerCap)
        {
            PowerCapacityKw = powerCap;
            Task.Run(() =>
            {
                var intervalMs = 250;
                var speed = 300;
                while (true)
                {
                    Task.Delay(intervalMs).Wait();
                    lock (_loads)
                    {
                        PowerConsumedKwh += _loads.Sum(x => x.ChargingPowerKw * ((speed * intervalMs / 1000f) / 3600f));
                        foreach (var load in _loads)
                        {
                            load.Charged(load.ChargingPowerKw * ((speed * intervalMs / 1000f) / 3600f));
                        }
                    }
                }
            });
        }

        public bool AttachLoad(ChargingLoad load)
        {
            var currentPower = _loads.Sum(x => x.ChargingPowerKw);
            if (currentPower + load.ChargingPowerKw <= PowerCapacityKw)
            {
                _loads.Add(load);
                load.FullyCharged += (s, e) =>
                {
                    lock (_loads)
                    {
                        _loads.Remove(load);
                    }
                };
                return true;
            }
            return false;
        }
    }
}
