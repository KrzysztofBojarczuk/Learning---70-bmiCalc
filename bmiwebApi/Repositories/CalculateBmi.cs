using bmiwebApi.Data;

namespace bmiwebApi.Repositories
{
    public class CalculateBmi
    {
        private readonly DataContext _ctx;
        
        public CalculateBmi(DataContext ctx)
        {
            _ctx = ctx;
        }
        public Body CreateBodyCalcAsync(Body body)
        {
            var bmi = body.Weight / Math.Pow(body.Height, 2);

            return bmi;
            
        }
        private Body GetBodyFromDb(Body id)
        {
            var body = _ctx.Bodies.Where(x => x.bodyId == id).FirstOrDefault();
            return body;
        }

        public Body _body { get; set; }
        private Body GetBodyFromDb()
        {
            var body = _ctx.Bodies.Where(x => x.Id == id).FirstOrDefault();
            return _body = body;
        }
    }
}
