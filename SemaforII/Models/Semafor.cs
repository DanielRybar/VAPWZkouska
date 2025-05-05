namespace SemaforII.Models
{
    public class Semafor
    {
        private bool cervena;
        private bool oranzova;
        private bool zelena;

        private byte stav = 0;

        public event Action<bool[]>? Zmeneno;

        public void Prepni()
        {
            Task.Run(() =>
            {
                switch (stav)
                {
                    case 0:
                        cervena = true;
                        oranzova = false;
                        zelena = false;
                        stav++;
                        break;
                    case 1:
                        cervena = true;
                        oranzova = true;
                        zelena = false;
                        stav++;
                        break;
                    case 2:
                        cervena = false;
                        oranzova = false;
                        zelena = true;
                        stav = 0;
                        break;
                }
                Zmeneno?.Invoke([cervena, oranzova, zelena]);
            });
        }
    }
}