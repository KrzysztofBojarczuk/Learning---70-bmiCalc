namespace bmiwebApi.Dtos
{
    public class BodyGetDto
    {
        public int bodyId { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public double BMIValue
        {
            get
            {
                // bmi = weight in Kgs / height in metres squared

                double bmi = Weight / (Math.Pow(Height, 2));

                return bmi;
            }
        }
    }
}
