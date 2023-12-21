using System;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string _model;
        private string _color;
        private int _battery;

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model 
        { 
            get
            {
                return this._model;
            }
            private set
            {
                this._model = value;
            }
        }

        public string Color
        {
            get
            {
                return this._color;
            }
            private set
            {
                this._color = value;
            }
        }

        public int Battery 
        { 
            get
            {
                return this._battery;
            }
            private set
            {
                this._battery = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Break!";
        }

        public override string ToString()
        {
            return $"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries" +
                $"{Environment.NewLine}{this.Start()}" +
                $"{Environment.NewLine}{this.Stop()}";
        }
    }
}
