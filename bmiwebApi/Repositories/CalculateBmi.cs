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

            return bmi; // <- error
            
        }
        private Body GetBodyFromDb(Body id)
        {
            //........................................(x.bodyId == id) <= error
            var body = _ctx.Bodies.Where(x => x.bodyId == id).FirstOrDefault();
            return body;
        }

        public Body _body { get; set; }
        private Body GetBodyFromDb()
        {
            //........................................(x.bodyId == id) <= error
            var body = _ctx.Bodies.Where(x => x.bodyId == id).FirstOrDefault();
            return _body = body;
        }
    }
}
