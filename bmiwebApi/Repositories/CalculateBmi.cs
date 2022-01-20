using bmiwebApi.Data;

namespace bmiwebApi.Repositories
{
    public class CalculateBmi
    {

        private readonly DataContext _ctx;

        //public CalculateBmi(DataContext ctx, IBodyRepository bodyRepository)
        //{
        //    _ctx = ctx;
        //}
        //public async Task<Body> CreateBodyCalcAsync(Body body)
        //{

        //    var bmicalc = _ctx.Bodies.Weight / Math.Pow(body.Height, 2);

        //    return bmicalc; // <- error


        //}
        //private Body GetBodyFromDb(Body id)
        //{
        //    //........................................(x.bodyId == id) <= error
        //    var body = _ctx.Bodies.Where(x => x.bodyId == id).FirstOrDefault();
        //    return body;
        //}

        //public Body _body { get; set; }
        //private Body GetBodyFromDb()
        //{
        //    //........................................(x.bodyId == id) <= error
        //    var body = _ctx.Bodies.Where(x => x.bodyId == id).FirstOrDefault();
        //    return _body = body;
        //}
    }
}
