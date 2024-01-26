

namespace BMI
{


    public class Bmi
    {
        private int weight;
        private double height;

        public double bmiVal;


        public Bmi(double height, int weight)
        {
            this.height = height / 100;
            this.weight = weight;
            this.bmiVal = 0;
        }

        private void getBmi ()
        {
            bmiVal = (double)weight / (height * height);

        }

        public string bmiResult()
        {
            getBmi();

            switch (bmiVal)
            {
                case < 18.5:
                    return "Underweight";

                case >= 18.5 and < 24.9:
                    return "Normal";

                case >= 24.9 and < 29.9:
                    return "Overweight";

                case <= 30:
                    return "Obese";

                default:
                    return "Nave no answer";
            }
        }

    }
}
