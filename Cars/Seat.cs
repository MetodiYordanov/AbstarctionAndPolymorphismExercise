using System;

namespace Cars
{
    public class Seat : ICar
    {
        private string _model;
        private string _color;

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
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
            return $"{this.Color} {this.GetType().Name} {this.Model}" +
                $"{Environment.NewLine}{this.Start()}" +
                $"{Environment.NewLine}{this.Stop()}";
        }
    }
}
